/*
Autor: Jose Vasquez
E-mail: jf.vasquez@outlook.es
*/
using Space_Sound;
using Space_Watcher.Class.Entity;

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
        System.Windows.Forms.Timer tEnemy_Load;
        System.Windows.Forms.Timer tEnemy_Start;
        /*End Timers*/

        /*Levels*/
        int Level = 1;
        int Enemy_Level = 0;
        /*End Levels*/

        /*Ship*/
        PictureBox IShip;
        int live = 5;
        /*End Ship*/

        /*Enemy*/
        Random enemy_random = new();
        PictureBox enemy_show;
        private List<ObjEnemy> list_enemy = [];

        int enemy_x = 40;
        int enemy_y = 40;
        int enemy_init = 1;
        int total_enemy = 0;
        /*Enemy*/


        /*Coin*/
        int coin = 0;
        /*End Coin*/

        /*Stop all*/
        bool Stop_All = false;
        /*End Stop All*/

        public WF_Play()
        {
            InitializeComponent();

            DoubleBuffered = true;
            mouse_path = new();
            soundSystem = new();

            screen_width = this.Width;
            screen_height = this.Height;

            /*Load*/
            BackgroundImage = Image.FromFile(global_assets + "background/bg-001.jpg");
            BackgroundImageLayout = ImageLayout.Stretch;
            soundSystem.Play(global_assets + @"sound\003.wav", "003", "waveaudio");
            /*End Load*/

            /*Init*/
            Init_Enemy();
            /*End Init*/

            /*Ship*/
            IShip = new()
            {
                Image = Image.FromFile(global_assets + "model/ships/s-0.png"),
                BackColor = Color.Transparent,
                Width = 75,
                Height = 120,
                Parent = this,
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            IShip.BringToFront();
            Ship_Location((screen_width / 2) - 50, screen_height - 240);
            /*End Ship*/

            /*PLive_Left*/
            PLive_Left.Location = new Point(10, screen_height - 30);
            ILive_Left.BackgroundImage = Image.FromFile(global_assets + "background/pnl-l-002.png");
            ILive_Left.BackgroundImageLayout = ImageLayout.Stretch;

            ICoin_Left.BackgroundImage = Image.FromFile(global_assets + "background/pnl-l-003.png");
            ICoin_Left.BackgroundImageLayout = ImageLayout.Stretch;
            /*End PLive_Left*/


            /*Event Timer Laser*/
            tLaser = new();
            tLaser.Tick += new EventHandler(TLaser_Tick);
            ILaser.BackgroundImage = Image.FromFile(global_assets + "model/laser/l-001.png");
            ILaser.BackgroundImageLayout = ImageLayout.Stretch;
            ILaser.BackColor = Color.Transparent;
            ILaser.Visible = false;
            /*End Event Timer Laser*/

            /*Event Timer Laser*/
            tEnemy_Load = new();
            tEnemy_Load.Tick += new EventHandler(TEnemyLoad_Tick);
            tEnemy_Start = new();
            tEnemy_Start.Tick += new EventHandler(TEnemyStart_Tick);
            tEnemy_Load.Start();
            /*End Event Timer Laser*/
        }

        protected override void OnKeyDown(KeyEventArgs e)
        {

            base.OnKeyDown(e);
            if (Stop_All) return;
            int x = IShip.Location.X; int y = IShip.Location.Y;

            int delay = 50;

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

                //IShip.BackgroundImage.RotateFlip(RotateFlipType.Rotate90FlipX);
                //IShip.Width = 200; IShip.Height = 100;
                //IShip.Refresh();
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

                ILaser.Location = new Point(IShip.Location.X + 32, IShip.Location.Y);
                ILaser.Parent = this;
                soundSystem.Play(global_assets + "sound/laser-001.wav", "laser-001", "waveaudio");
                tLaser.Start();
            }

            Ship_Location(x, y);

        }
        private void Ship_Location(int x, int y)
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
            ILaser.Top = ILaser.Top - 10;
            ILaser.Refresh();
        }
        private void Init_Enemy()
        {
            if (Level == 1)
            {
                Enemy_Level = 8;
            }
            int enemy_x = Convert.ToInt32(Math.Ceiling(Convert.ToDecimal((screen_width / Enemy_Level))));

        }
        private void TEnemyLoad_Tick(object sender, EventArgs e)
        {

            try
            {
                if (enemy_init <= Enemy_Level)
                {

                    if (enemy_init >= Enemy_Level)
                    {
                        tEnemy_Load.Stop();
                        tEnemy_Start.Start();
                        return;
                    }

                    enemy_show = new()
                    {
                        Name = $"enemy_x_{enemy_init}",
                        BackColor = Color.Transparent,
                        Image = Image.FromFile(global_assets + "model/enemy/level_1/e-001.png"),
                        Location = new Point(enemy_x, enemy_y),
                        Width = 90,
                        Height = 65,
                        Tag = $"enemy_x_{enemy_init}",
                        Parent = this,
                        SizeMode = PictureBoxSizeMode.StretchImage
                    };
                    enemy_show.SendToBack();
                    enemy_show.Refresh();

                    tEnemy_Load.Interval = 250;
                    enemy_x += 140;
                    enemy_init++;

                }

            }
            catch { throw; }
        }
        private void TEnemyStart_Tick(object sender, EventArgs e)
        {
            int x = 0; int y = 0; int enemy_count = 5;
            Random random_enemy = new();
            x = random_enemy.Next(40, screen_height - 100);


            try
            {
                foreach (Control enemy in this.Controls)
                {
                    if (enemy is PictureBox)
                    {
                        if (enemy.Name.Contains("_x_"))
                        {
                            enemy_count++;
                            string enemy_name = enemy.Name;

                            if (enemy.Top < screen_height - 200)
                            {
                                if (enemy.Name == enemy_name)
                                {
                                    enemy.Top += enemy_count;
                                    enemy.Refresh();
                                    tEnemy_Start.Interval = 200;

                                }
                            }
                            else
                            {
                                enemy.Location = new Point(x + 100, y);
                            }


                            if (ILaser.Bounds.IntersectsWith(enemy.Bounds) && enemy.Visible)
                            {
                                Enemy_Level -= 1;
                                soundSystem.Play(global_assets + @"sound\explosion-001.wav", "explosion001", "waveaudio");
                                enemy.BackgroundImage = Image.FromFile(global_assets + "background/explotion-001.gif");
                                enemy.BackgroundImageLayout = ImageLayout.Stretch;
                                enemy.Refresh();
                                enemy.Visible = false;
                                Coin(true);
                            }


                            if (IShip.Bounds.IntersectsWith(enemy.Bounds) && enemy.Visible)
                            {
                                /*Game Over*/
                                if (live <= 0)
                                {
                                    GameOver_Text();
                                    return;
                                }
                                Live(false);
                            }

                            /*Wins*/
                            if (Enemy_Level <= 0)
                            {
                                Wins_Text();
                                return;
                            }
                        }

                    }
                }

            }
            catch { throw; }
        }
        private void Coin(bool a)
        {
            try
            {
                if (!a)
                {
                    coin -= 1;
                }
                if (a)
                {
                    coin += 1;
                }

                lblCoin.Text = coin.ToString();
            }
            catch { throw; }
        }
        private void Live(bool a)
        {
            try
            {
                if (!a)
                {
                    live -= 1;
                }
                if (a)
                {
                    live += 1;
                }

                lblLife.Text = live.ToString();
            }
            catch { throw; }
        }
        private void GameOver_Text()
        {
            Panel panel_gameover = new()
            {
                Location = new Point((screen_width / 2) - 100, (screen_height / 2) - 100),
                BackColor = Color.Transparent,
                BackgroundImage = Image.FromFile(global_assets + "background/bg-003.png"),
                BackgroundImageLayout = ImageLayout.Stretch,
                Width = 200,
                Height = 120,
                Parent = this
            };

            IShip.Enabled = false;
            IShip.Visible = false;
            tLaser.Stop();
            tEnemy_Start.Stop();
            tEnemy_Load.Stop();
            Stop_All = true;
        }
        private void Wins_Text()
        {
            Panel panel_win = new()
            {
                Location = new Point((screen_width / 2) - 170, (screen_height / 2) - 100),
                BackColor = Color.Transparent,
                BackgroundImage = Image.FromFile(global_assets + "background/bg-004.png"),
                BackgroundImageLayout = ImageLayout.Stretch,
                Width = 300,
                Height = 240,
                Parent = this
            };
            IShip.Enabled = false;
            IShip.Visible = false;
            tLaser.Stop();
            tEnemy_Start.Stop();
            tEnemy_Load.Stop();
            Stop_All = true;
        }
    }
}
