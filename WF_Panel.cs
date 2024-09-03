/*
Autor: Jose Vasquez
E-mail: jf.vasquez@outlook.es
*/
using Space_Sound;

namespace Space_Watcher
{
    public partial class WF_Panel : Form
    {

        private int screen_width = 0;
        private int screen_height = 0;
        private string global_assets = Path.GetFullPath("./assets/");
        private System.Drawing.Drawing2D.GraphicsPath mouse_path;
        private SoundSystem soundSystem;

        public WF_Panel()
        {
            InitializeComponent();

            DoubleBuffered = true;
            mouse_path = new();
            soundSystem = new();

            /*Load*/
            this.BackgroundImage = Image.FromFile(global_assets + "background/bg-001.jpg");
            this.BackgroundImageLayout = ImageLayout.Stretch;

            soundSystem.Play(global_assets + @"sound\001.wav", "001", "waveaudio");
            /*End Load*/

            screen_width = this.Width;
            screen_height = this.Height;

            /*Buttom Play*/
            btnPlay.Tag = "Play";
            btnPlay.Location = new Point((screen_width / 2) - 160, screen_height / 2);
            btnPlay.BackColor = Color.Transparent;
            btnPlay.BackgroundImage = Image.FromFile(global_assets + "background/btn-001.png");
            btnPlay.BackgroundImageLayout = ImageLayout.Stretch;
            lblTextPlay.Click += new EventHandler(Event_Click);
            lblTextPlay.MouseHover += new EventHandler(Hover);
            lblTextPlay.MouseLeave += new EventHandler(Leave);
            /*End Buttom Play*/
        }

        protected void Hover(object sender, EventArgs e)
        {
            try
            {
                var obj = ((Control)sender).Tag;
                switch (obj)
                {
                    case "Play":
                        btnPlay.BackgroundImage = Image.FromFile(global_assets + "background/btn-h-001.png");
                        btnPlay.BackgroundImageLayout = ImageLayout.Stretch;
                        DoubleBuffered = true;
                        soundSystem.Play(global_assets + @"sound\002.wav", "002", "waveaudio");
                        break;
                }
            }
            catch { throw; }
        }

        protected void Leave(object sender, EventArgs e)
        {
            try
            {
                var obj = ((Control)sender).Tag;
                switch (obj)
                {
                    case "Play":
                        btnPlay.BackgroundImage = Image.FromFile(global_assets + "background/btn-001.png");
                        btnPlay.BackgroundImageLayout = ImageLayout.Stretch;
                        break;
                }
            }
            catch { throw; }
        }

        protected override void OnAutoSizeChanged(EventArgs e)
        {
            screen_height = this.Height;
            screen_width = this.Width;
            base.OnAutoSizeChanged(e);
        }

        private void Event_Click(object sender, EventArgs e)
        {
            try
            {
                var obj = ((Control)sender).Tag;
                switch (obj)
                {
                    case "Play":
                        soundSystem.Close("001");
                        WF_Play wF_Play = new();
                        this.Hide();
                        wF_Play.ShowDialog();
                        break;
                }
            }
            catch { throw; }
        }
    }
}
