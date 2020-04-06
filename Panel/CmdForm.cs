using Bunifu.Framework.UI;
using System;
using System.Collections;
using System.Drawing;
using System.Windows.Forms;
using WindowsFormsControlLibrary1;

namespace Panel
{
    public partial class CmdForm : Form
    {

        public ArrayList Values;

        public Label CreateLabel(Param p, ref int t, bool indent = false)
        {
            Label l = new Label();
            if (indent)
            {
                l.Location = new Point(43, t + 3);
            }
            else
            {
                l.Location = new Point(17, t);
                t += l.Height + 2;
            }
            l.Text = p.Label;
            l.Width = 300;
            l.Height = 15;
            Controls.Add(l);
            return l;
        }

        public BunifuMetroTextbox CreateTextInput(ref int t)
        {
            BunifuMetroTextbox i = new BunifuMetroTextbox
            {
                Location = new Point(17, t),
                BorderColorFocused = Color.FromArgb(2, 186, 255),
                BorderColorMouseHover = Color.FromArgb(33, 150, 243),
                BorderThickness = 2,
                Height = 30
            };
            t += i.Height + 10;
            Controls.Add(i);
            return i;
        }

        public BunifuCheckbox CreateBoolInput(ref int t)
        {
            BunifuCheckbox i = new BunifuCheckbox
            {
                Location = new Point(17, t),
                ChechedOffColor = Color.FromArgb(132, 135, 140),
                CheckedOnColor = Color.FromArgb(33, 150, 243),
                Checked = true
            };
            t += i.Height + 10;
            Controls.Add(i);
            return i;
        }

        public BunifuCustomTextbox CreateTextBoxInput(ref int t)
        {
            BunifuCustomTextbox i = new BunifuCustomTextbox
            {
                Location = new Point(17, t),
                Multiline = true,
                BackColor = Color.FromArgb(26, 26, 26),
                BorderColor = Color.FromArgb(2, 186, 255),
                ForeColor = Color.FromArgb(64, 64, 64),
                Font = new Font("Consolas", 11),
                BorderStyle = BorderStyle.FixedSingle,
                Width = 370,
                Height = 200
            };
            t += i.Height + 10;
            Controls.Add(i);
            return i;
        }

        public CmdForm(Command cmd)
        {
            InitializeComponent();

            int h = 180, t = 90;
            cmdNameLabel.Text = cmd.FriendlyName;
            storeCheck.Enabled = cmd.CanStore;
            if (cmd.Params != null)
            {
                foreach (Param p in cmd.Params)
                {
                    switch (p.Type)
                    {
                        case "Text":
                            CreateLabel(p, ref t);
                            CreateTextInput(ref t);
                            break;
                        case "Bool":
                            CreateLabel(p, ref t, true);
                            CreateBoolInput(ref t);
                            break;
                        case "TextBox":
                            CreateLabel(p, ref t);
                            CreateTextBoxInput(ref t);
                            break;
                    }
                }
                t += 10;
            }
            Height = h + t - 90;
        }

        private void SendButton_Click(object sender, EventArgs e)
        {
            Values = new ArrayList();
            foreach (Control c in Controls)
            {
                if (c.GetType() == typeof(BunifuMetroTextbox))
                {
                    Values.Add(((BunifuMetroTextbox)c).Text);
                }
                else
                if (c.GetType() == typeof(BunifuCustomTextbox))
                {
                    Values.Add(((BunifuCustomTextbox)c).Text);
                }
                else
                    if (c.GetType() == typeof(BunifuCheckbox))
                {
                    Values.Add(((BunifuCheckbox)c).Checked.ToString());
                }
            }
            DialogResult = DialogResult.OK;
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
