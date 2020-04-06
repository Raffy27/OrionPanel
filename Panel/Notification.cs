using System;
using System.Drawing;
using System.Windows.Forms;

namespace Panel
{
    public partial class Notification : Form
    {

        Timer t = new Timer();
        Timer w = new Timer();
        Timer c = new Timer();

        public Notification(string Title, string Text)
        {
            InitializeComponent();
            TitleLabel.Text = Title;
            TextLabel.Text = Text;
        }

        private void Notification_Load(object sender, EventArgs e)
        {
            Location = new Point(Screen.PrimaryScreen.WorkingArea.Width - Width,
                       Screen.PrimaryScreen.WorkingArea.Height - Height);
            t.Interval = 50;
            t.Tick += new EventHandler(FadeIn);
            w.Interval = 10000;
            w.Tick += new EventHandler(Expired);
            c.Interval = 50;
            c.Tick += new EventHandler(FadeOut);
            t.Start();
        }

        private void FadeIn(object sender, EventArgs e)
        {
            if (Opacity >= 1)
            {
                t.Stop();
                w.Start();
            }
            else
            {
                Opacity += 0.05;
            }
        }

        private void Expired(object sender, EventArgs e)
        {
            w.Stop();
            c.Start();
        }

        private void FadeOut(object sender, EventArgs e)
        {
            if (Opacity <= 0)
            {
                c.Stop();
                Close();
            }
            else
            {
                Opacity -= 0.05;
            }
        }

        private void Clicked(object sender, EventArgs e)
        {
            Application.OpenForms[0].BringToFront();
            Close();
        }
    }
}
