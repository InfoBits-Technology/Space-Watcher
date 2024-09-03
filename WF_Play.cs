/*
Autor: Jose Vasquez
E-mail: jf.vasquez@outlook.es
*/
using Space_Sound;

namespace Space_Watcher
{
    public partial class WF_Play : Form
    {
        private int screen_width = 0;
        private int screen_height = 0;
        private string global_assets = Path.GetFullPath("./assets/");
        private System.Drawing.Drawing2D.GraphicsPath mouse_path;
        private SoundSystem soundSystem;

        /*Timers*/
        System.Windows.Forms.Timer tLaser;
        /*End Timers*/

        public WF_Play()
        {
            InitializeComponent();

            DoubleBuffered = true;
            mouse_path = new();
            soundSystem = new();

            screen_width = this.Width;
            screen_height = this.Height;

            /*Load*/
            this.BackgroundImage = Image.FromFile(global_assets + "background/bg-001.jpg");
            this.BackgroundImageLayout = ImageLayout.Center;
            soundSystem.Play(global_assets + @"sound\003.wav", "003", "waveaudio");
            /*End Load*/

            /*Ship*/
            IShip.BackColor = Color.Transparent;
            Ship(((screen_width / 2) - 50), (screen_height - 240));
            IShip.BackgroundImage = Image.FromFile(global_assets + "model/ships/s-0.png");
            /*End Ship*/

            /*PLive_Left*/
            PLive_Left.Location = new Point(10, screen_height - 30);
            ILive_Left.BackgroundImage = Image.FromFile(global_assets + "background/pnl-l-002.png");
            ILive_Left.BackgroundImageLayout = ImageLayout.Stretch;
            /*End PLive_Left*/


            /*Event Timer*/
            tLaser = new();
            tLaser.Tick += new EventHandler(TLaser_Tick);
            ILaser.BackgroundImage = Image.FromFile(global_assets + "model/laser/l-001.png");
            ILaser.BackgroundImageLayout = ImageLayout.Stretch;
            ILaser.Visible = false;
            /*End Event Timer*/
        }

        protected override void OnKeyDown(KeyEventArgs e)
        {
            int x = IShip.Location.X; int y = IShip.Location.Y;
            int fixed_x = 50; int fixed_y = 240;
            int delay = 30;
            if (e.KeyCode == Keys.Right)
            {
                if (x >= (screen_width - 160))
                {
                    x = screen_width - 160;
                }
                else
                {
                    x += delay;
                }
            }

            if (e.KeyCode == Keys.Left)
            {

                if (x <= 0)
                {
                    x = 10;
                }
                else
                {
                    x -= delay;
                }
            }

            if (e.KeyCode == Keys.Up)
            {
                if (y <= 0)
                {
                    y = 10;
                }
                else
                {
                    y -= delay;
                }
            }

            if (e.KeyCode == Keys.Down)
            {
                if (y >= (screen_height - 240))
                {
                    y = screen_height - 240;
                }
                else
                {
                    y += delay;
                }
            }

            if (e.KeyCode == Keys.Space)
            {
                
                ILaser.Location = new Point(x + 45, y-30);
                soundSystem.Play(global_assets+"sound/laser-001.wav","laser-001", "waveaudio");
                tLaser.Start();
            }

            Ship(x, y);
            base.OnKeyDown(e);
        }

        private void Ship(int x, int y)
        {
            try
            {
                IShip.Location = new Point(x, y);
            }
            catch { throw; }
        }

        private void TLaser_Tick(object sender, EventArgs e)
        {
            ILaser.Visible = true;
            tLaser.Interval = 10;
            ILaser.Top = ILaser.Top - 20;
        }
    }
}
