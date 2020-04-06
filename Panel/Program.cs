using System;
using System.Net;
using System.Windows.Forms;

namespace Panel
{

    public class CWebClient : WebClient
    {
        public CookieContainer Cookies = new CookieContainer();
        public WebProxy _Proxy = new WebProxy(IPAddress.Loopback.ToString(), 7979);

        public void UseTor(bool Enable)
        {
            if (Enable)
            {
                Proxy = _Proxy;
            }
            else
            {
                Proxy = null;
            }
        }

        protected override WebRequest GetWebRequest(Uri address)
        {
            WebRequest request = base.GetWebRequest(address);

            if (request is HttpWebRequest)
                ((HttpWebRequest)request).CookieContainer = Cookies;

            return request;
        }
    }

    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            using (LoginForm fLogin = new LoginForm())
            {
                bool Tor = Properties.Settings.Default.Tor;
                if (Tor)
                {
                    Form1.RunTor();
                    fLogin.Client.UseTor(Tor);
                }
                if (fLogin.ShowDialog() == DialogResult.OK)
                {
                    Form1 fMain = new Form1();
                    fMain.Client.Cookies = fLogin.Client.Cookies;
                    fMain.Client.UseTor(Tor);
                    fMain.Client2.Cookies = fLogin.Client.Cookies;
                    fMain.Client2.UseTor(Tor);
                    Application.Run(fMain);
                }
                else
                {
                    Application.Exit();
                }
            }
        }
    }
}
