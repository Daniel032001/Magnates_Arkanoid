using System;
using System.Drawing;
using System.Windows.Forms;
using Magnates_arkanoid.Controller;

namespace Magnates_arkanoid
{
    public partial class Play : UserControl
    {
        private Brick[,] Bricks;
        private PictureBox ball;
        private delegate void BallActions();
        private BallActions action;
        public Play()
        {
            InitializeComponent();
            action=MoveBall;
            action+= bounce;
        }

        protected override CreateParams CreateParams//Mejora en la interfaz grafica 
        {
            get
            {
                CreateParams handleParam = base.CreateParams;
                handleParam.ExStyle |= 0x02000000;
                return handleParam;
            }
        }

        private void Game_Load(object sender, EventArgs e)
        {
            loadBricks();
            lblLifes.Text = " : "+GameData.lifes;
            lblPoints.Text = " " + GameData.points;
            lblLifes.Top =lblPoints.Top= Height-(Height - 30);
            lblPoints.Left = Width - 150;
            ptbTable.Top = Height - ptbTable.Height - 80;
            ptbTable.Left = (Width / 2) - (ptbTable.Width / 2);
            LoadBall();
            ball.Top = ptbTable.Top - ball.Height-20;
            timer1.Start();
        }

        public void LoadBall()
        {
            ball = new PictureBox();
            ball.Width = ball.Height = 30;
            ball.BackgroundImage = Image.FromFile("../../resources/ball.jpg");
            ball.BackgroundImageLayout = ImageLayout.Stretch;
            ball.Left = ptbTable.Left + (ptbTable.Width / 2) - (ball.Width / 2);
            Controls.Add(ball); 
        }
        public void loadBricks()
        {
            int rows = 4, columns = 10;
            int brickHeight = (int) (Height * 0.24) / rows;
            int brickWidth = Width / columns;
            Bricks = new Brick[rows, columns];
            for (int i = 0; i < rows; i++)
            {
                for (int k = 0; k < columns; k++)
                {
                    Bricks[i, k] = new Brick();
                    if (i == 0 || i==2)
                    {
                        Bricks[i, k].hits = 2;
                    }
                    else
                    {
                        Bricks[i, k].hits = 1;
                    }

                    Bricks[i, k].Height = brickHeight;
                    Bricks[i, k].Width = brickWidth;
                    Bricks[i, k].Left = k * brickWidth;
                    Bricks[i, k].Top = i * brickHeight + 80;
                    int numero = RdmNumber();
                    string valor = numero.ToString();
                    Bricks[i, k].BackgroundImage = Image.FromFile("../../resources/" + numero + ".jpg");
                    Bricks[i, k].BackgroundImageLayout = ImageLayout.Stretch;
                    Bricks[i, k].BorderStyle = BorderStyle.Fixed3D;
                    Bricks[i, k].Tag =valor+".jpg";
                    Controls.Add(Bricks[i, k]);
                }
            }
        }

        private int RdmNumber()
        {
            return new Random().Next(1, 6);
        }
        private void Game_MouseMove(object sender, MouseEventArgs e)
        {
            if (!GameData.startedgame)
            {
                if (e.X < (Width - ptbTable.Width))
                {
                    ptbTable.Left = e.X;
                    ball.Left = ptbTable.Left + (ptbTable.Width / 2) - (ball.Width / 2);
                }
            }
            else
            {
                if (e.X < (Width - ptbTable.Width))
                {
                    ptbTable.Left = e.X;
                }
            }
        } 
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (!GameData.startedgame)
                return;
            action?.Invoke();
        }

        private void MoveBall()
        {
            ball.Left += GameData.dirX;
            ball.Top += GameData.dirY;
        }
        private void bounce()
        {
            if (ball.Bottom > Height)
            {
                GameData.lifes --; 
                if (GameData.lifes > 0)
               { 
                    Controls.Remove(ball);
                    ball = null;
                    GameData.dirX=15;
                    GameData.dirY=-GameData.dirX;
                    GameData.startedgame=false; 
                    LoadBall();
                    lblLifes.Text=" : "+GameData.lifes;
                    ball.Top = ptbTable.Top - ball.Height;
                }
                else
                {
                    Application.Exit();
                }
            }

            if (ball.Left < 0 || ball.Right > Width)
            {
                GameData.dirX = -GameData.dirX;
                return;
            }

            if (ball.Bounds.IntersectsWith(ptbTable.Bounds))
            {
                GameData.dirY = -GameData.dirY;
            }

            for (int i = 3; i >= 0; i--)
            {
                for (int j = 0; j < 10; j++)
                {
                    if (Bricks[i, j] != null && ball.Bounds.IntersectsWith(Bricks[i, j].Bounds))
                    {
                        Bricks[i, j].hits--; 
                        if (Bricks[i, j].hits == 0)
                        {
                            GameData.calculatePoints(Bricks[i,j].Tag.ToString());
                            Controls.Remove(Bricks[i, j]);
                            Bricks[i, j] = null;
                            lblPoints.Text = GameData.points.ToString();
                        }
                        else
                        {
                            String imagen = Bricks[i, j].Tag.ToString().Substring(0, 1);
                            String nuevaimagen = imagen+Bricks[i, j].Tag.ToString().Substring(0,2); 
                            Bricks[i,j].BackgroundImage=Image.FromFile("../../resources/"+nuevaimagen+"jpeg");
                            Bricks[i, j].Tag = nuevaimagen + "jpeg";
                        }
                        GameData.dirY = -GameData.dirY;
                        return;
                    }
                }
            }
        }

        private void Play_Click(object sender, EventArgs e)
        {
            if(!GameData.startedgame)
                GameData.startedgame = true;
        }
    }
}