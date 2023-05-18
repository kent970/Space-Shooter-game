using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace SpaceShooterv2
{
    public partial class Form1 : Form
    {
        private PictureBox[] _stars;
        private PictureBox[] _protectiles;
        private PictureBox[] _enemies;
        private PictureBox[] _enemieProtectiles;
        private int _backgroundspeed;
        private Random _random;
        private int _playerspeed;
        private int _protectileSpeed;
        private int _enemySpeed;
        private int _enemyProtectileSpeed;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            var backgroundTimer = new System.Timers.Timer();
            backgroundTimer.Interval = 20;
            backgroundTimer.Elapsed += MoveBackground_Elapsed;
            backgroundTimer.Start();


            _backgroundspeed = 4;
            _stars = new PictureBox[20];
            _random = new Random();
            _playerspeed = 4;
            _protectileSpeed = 20;
            _protectiles = new PictureBox[3];
            _enemies = new PictureBox[10];
            _enemySpeed = 20;
            _enemyProtectileSpeed = 4;
            
            
            // Image munition = Image.FromFile("asserts\\munition.png");
            for (int i = 0; i < _protectiles.Length; i++)
            {
                _protectiles[i] = new PictureBox();
                _protectiles[i].Size = new Size(8, 8);
                //   protectiles[i].Image = munition;
                _protectiles[i].BackColor = Color.Black;
                _protectiles[i].SizeMode = PictureBoxSizeMode.Zoom;
                _protectiles[i].BorderStyle = BorderStyle.None;
                this.Controls.Add(_protectiles[i]);
            }

            for (int i = 0; i < _enemies.Length; i++)
            {
                _enemies[i] = new PictureBox();
              //  _enemies[i].Image = new Bitmap(50, 50);
              _enemies[i].BackColor = Color.IndianRed;
              
                _enemies[i].Size = new Size(50, 50);
                _enemies[i].SizeMode = PictureBoxSizeMode.Zoom;
               // _enemies[i].BorderStyle = BorderStyle.None;
                _enemies[i].BorderStyle = BorderStyle.FixedSingle;
                _enemies[i].Visible = false;
                this.Controls.Add(_enemies[i]);
                _enemies[i].Location = new Point((i + 1) * 50, -50);
                
            }


            for (int i = 0; i < _stars.Length; i++)
            {
                _stars[i] = new PictureBox();
                _stars[i].BorderStyle = BorderStyle.None;
                _stars[i].Location = new Point(_random.Next(20, 580), _random.Next(-10, 400));
                if (i % 2 == 1)
                {
                    _stars[i].Size = new Size(3, 3);
                    _stars[i].BackColor = Color.Wheat;
                }
                else
                {
                    _stars[i].Size = new Size(4, 4);
                    _stars[i].BackColor = Color.DarkBlue;
                }

                this.Controls.Add(_stars[i]);
            }
            
            //enemy protectiles here

            _enemieProtectiles = new PictureBox[10];
            for (int i = 0; i < _enemieProtectiles.Length; i++)
            {
                _enemieProtectiles[i] = new PictureBox();
                _enemieProtectiles[i].Size = new Size(2, 25);
                _enemieProtectiles[i].Visible = false;
                _enemieProtectiles[i].BackColor = Color.Yellow;
                int x = _random.Next(0, 10);
                _enemieProtectiles[i].Location = new Point(_enemies[x].Location.X, _enemies[x].Location.Y - 20);
                this.Controls.Add(_enemieProtectiles[i]);
            }
        }

        private void MoveBackground_Elapsed(object sender, ElapsedEventArgs e)
        {
            for (int i = 0; i < _stars.Length / 2; i++)
            {
                _stars[i].Top += _backgroundspeed;
                if (_stars[i].Top >= this.Height)
                {
                    _stars[i].Top = -_stars[i].Height;
                }
            }

            for (int i = _stars.Length / 2; i < _stars.Length; i++)
            {
                _stars[i].Top += _backgroundspeed - 2;
                if (_stars[i].Top >= this.Height)
                {
                    _stars[i].Top = -_stars[i].Height;
                }
            }
        }

        private void RightMove_Elapsed(object sender, ElapsedEventArgs e)
        {
            if (Player.Right < 550)
            {
                Player.Left += _playerspeed;
            }
        }

        private void UpMove_Elapsed(object sender, ElapsedEventArgs e)
        {
            if (Player.Top > 10)
            {
                Player.Top -= _playerspeed;
            }
        }

        private void LeftMove_Elapsed(object sender, ElapsedEventArgs e)
        {
            if (Player.Left > 10)
            {
                Player.Left -= _playerspeed;
            }
        }

        private void DownMove_Elapsed(object sender, ElapsedEventArgs e)
        {
            if (Player.Top < 600)
            {
                Player.Top += _playerspeed;
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right)
            {
                RightMove.Start();
            }

            if (e.KeyCode == Keys.Left)
            {
                LeftMove.Start();
            }

            if (e.KeyCode == Keys.Up)
            {
                UpMove.Start();
            }

            if (e.KeyCode == Keys.Down)
            {
                DownMove.Start();
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            RightMove.Stop();
            LeftMove.Stop();
            DownMove.Stop();
            UpMove.Stop();
        }


        private void MoveProtectile_Elapsed(object sender, ElapsedEventArgs e)
        {
            for (int i = 0; i < _protectiles.Length; i++)
            {
                if (_protectiles[i].Top > 0)
                {
                    _protectiles[i].Visible = true;
                    _protectiles[i].Top -= _protectileSpeed;
                    
                    CheckCollision();
                }
                else
                {
                    _protectiles[i].Visible = false;
                    _protectiles[i].Location = new Point(Player.Location.X + 20, Player.Location.Y - i * 30);
                }
            }
        }

        private void MoveEnemies(PictureBox[] enemies, int speed)
        {
            for (int i = 0; i < enemies.Length; i++)
            {
                enemies[i].Visible = true;
                enemies[i].Top += speed;

                if (enemies[i].Top > this.Height)
                {
                    enemies[i].Location = new Point((i + 1) * 50, -200);
                }

                if (enemies[i].Location.Y == Player.Location.Y)
                {
                    this.BackColor=Color.Chartreuse;
                }
            
            }

        }

        private void MoveEnemy_Elapsed(object sender, ElapsedEventArgs e)
        {
            MoveEnemies(_enemies, _enemySpeed);
        }

        private void CheckCollision()
        {
            for (int i = 0; i < _enemies.Length; i++)
            {
                if ((_protectiles[0].Bounds.IntersectsWith(_enemies[i].Bounds)) ||
                    (_protectiles[1].Bounds.IntersectsWith(_enemies[i].Bounds)) ||
                    (_protectiles[2].Bounds.IntersectsWith(_enemies[i].Bounds)))
                {
                    _enemies[i].Location = new Point((i + 1) * 50, -100);
                }

                if (Player.Bounds.IntersectsWith(_enemies[i].Bounds))
                {
                    Player.Visible = false;
                    GameOver("Game Over");
                }
            }
        }

        private void GameOver(string str)
        {
            MoveEnemy.Stop();
            MoveProtectile.Stop();
            
        }


        private void EnemyProtectiles_Elapsed(object sender, ElapsedEventArgs e)
        {
            for (int i = 0; i < _enemieProtectiles.Length; i++)
            {
                if (_enemieProtectiles[i].Top < this.Height)
                {
                    _enemieProtectiles[i].Visible = true;
                    _enemieProtectiles[i].Top += _enemyProtectileSpeed;
                }
                else
                {
                    _enemieProtectiles[i].Visible = false;
                    int x = _random.Next(0, 10);
                    _enemieProtectiles[i].Location =
                        new Point(_enemies[x].Location.X + 20, _enemies[x].Location.Y + 30);
                }
            }
        }
    }
}