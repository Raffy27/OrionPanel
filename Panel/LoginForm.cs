using System;
using System.Collections.Specialized;
using System.Net;
using System.Windows.Forms;


namespace Panel
{
    public partial class LoginForm : Form
    {

        int Attempts = 0;

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        public CWebClient Client = new CWebClient();

        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            loginButton.Enabled = false;
            var Params = new NameValueCollection
            {
                { "user", UserEdit.Text },
                { "pass", PassEdit.Text }
            };
            Uri u = new Uri(Properties.Settings.Default.GateLocation + "login");
            Client.UploadValuesAsync(u, "POST", Params);
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            System.Net.ServicePointManager.ServerCertificateValidationCallback = delegate { return true; };
            UserEdit.Text = Properties.Settings.Default.Username;
            Client.UploadValuesCompleted += (_sender, _e) =>
            {
                if (_e.Error is WebException)
                {
                    Attempts++;
                    MessageBox.Show("Login failed: " + _e.Error.Message);
                    if (Attempts >= 3)
                        DialogResult = DialogResult.Abort;
                }
                else
                {
                    Properties.Settings.Default.Username = UserEdit.Text;
                    Properties.Settings.Default.Save();
                    DialogResult = DialogResult.OK;
                }
                loginButton.Enabled = true;
            };
        }

        private void PassEdit_Enter(object sender, EventArgs e)
        {
            if (!PassEdit.isPassword)
            {
                PassEdit.Text = "";
                PassEdit.isPassword = true;
            }
        }
    }
}
