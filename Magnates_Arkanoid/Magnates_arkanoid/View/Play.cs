using System;
using System.Drawing;
using System.Windows.Forms;
using Magnates_arkanoid.Controller;
using NpgsqlTypes;

namespace Magnates_arkanoid
{
    public partial class Play : UserControl
    {
        private Brick[,] Bricks;
        private PictureBox ball;
        private delegate void BallActions();
        private BallActions action;
        private int Bricksdestroyed;
        public delegate void finishGame();
        public  finishGame endedGame;
        public Play()
        {
            InitializeComponent();
            action=MoveBall;
            action+= bounce;
            Bricksdestroyed = 0;
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
            loadBricks();//cargamos los bloques, las labels para indicar las vidas,puntos,la bola y la tabla
            lblLifes.Text = " : "+GameData.lifes;
            lblPoints.Text = " " + GameData.points;
            lblLifes.Top =lblPoints.Top= Height-(Height - 30);
            lblPoints.Left = Width - 150;
            ptbTable.Top = Height - ptbTable.Height - 80;
            ptbTable.Left = (Width / 2) - (ptbTable.Width / 2);
            LoadBall();
            ball.Top = ptbTable.Top - ball.Height-20;
            tmGame.Start();
        }

        public void LoadBall()//metodo que carga la bola y la configura
        {
            ball = new PictureBox();
            ball.Width = ball.Height = 30;
            ball.BackgroundImage = Image.FromFile("../../resources/ball.png");
            ball.BackgroundImageLayout = ImageLayout.Stretch; 
            ball.BackColor=Color.Transparent;
            ball.Left = ptbTable.Left + (ptbTable.Width / 2) - (ball.Width / 2);
            Controls.Add(ball); 
        }
        public void loadBricks()//cargamos los bloques en un arreglo 
        {
            int rows = 4, columns = 10;
            int brickHeight = (int) (Height * 0.24) / rows;//delimitamos el alto de los bloques
            int brickWidth = Width / columns;//delimitamos el ancho de los bloques
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
                    int numero = RdmNumber();//agregamos los tipos de bloques aleatoriamente 
                    string valor = numero.ToString();
                    Bricks[i, k].BackgroundImage = Image.FromFile("../../resources/" + numero + ".jpg");
                    Bricks[i, k].BackgroundImageLayout = ImageLayout.Stretch;
                    Bricks[i, k].BorderStyle = BorderStyle.Fixed3D;
                    //usamos la propiedad tag para poder identificar la imagen a cambiar
                    //en el caso de los bloques que necesitan mas de un golpe
                    Bricks[i, k].Tag =valor+".jpg";
                    Controls.Add(Bricks[i, k]);
                }
            }
        }

        private int RdmNumber()//numero aleatorio
        {
            return new Random().Next(1, 6);
        }
        private void Game_MouseMove(object sender, MouseEventArgs e)
        {
            if (!GameData.startedgame)//antes de iniciar el juego movemos la bola y la tabla de igual forma
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
            action?.Invoke();//delegate que contiene suscritos los movimientos de la bola
        }

        private void MoveBall()//movemos la bola
        {
            ball.Left += GameData.dirX;
            ball.Top += GameData.dirY;
        }
        private void bounce()//metodo para que la bola rebote
        {
            if (ball.Bottom > Height)//si la bola cae
            {
                GameData.lifes --; 
                if (GameData.lifes > 0)
                { 
                    Controls.Remove(ball);//reubicamos la bola,restamos las vidas
                    ball = null;
                    GameData.dirX=20;
                    GameData.dirY=-GameData.dirX;
                    GameData.startedgame=false; 
                    LoadBall();
                    lblLifes.Text=" : "+GameData.lifes;
                    ball.Top = ptbTable.Top - ball.Height;
                }
                else//si se acaban las vidas
                {
                    tmGame.Stop();
                    MessageBox.Show("Has perdido");
                    endedGame?.Invoke();//llamamos al delegate que termina la partida y reinicia algunos componentes
                }
            }

            if (ball.Top < (int) (Height * 0.24)/4)//validacion para que la bola no pase del limite de los bloques de la ultima fila
            {
                GameData.dirY = -GameData.dirY;
                return;
            }
            if (ball.Left < 0 || ball.Right > Width)//validacion para que la bola no pase de los lados 
            {
                GameData.dirX = -GameData.dirX;
                return;
            }

            if (ball.Bounds.IntersectsWith(ptbTable.Bounds))//hacemos que rebote si la bola toca la tabla
            {
                GameData.dirY = -GameData.dirY;
            }
            for (int i = 3; i >= 0; i--)
            {
                for (int j = 0; j < 10; j++)
                {
                    if (Bricks[i, j] != null && ball.Bounds.IntersectsWith(Bricks[i, j].Bounds))//bola toca un bloque
                    {
                        Bricks[i, j].hits--; 
                        if (Bricks[i, j].hits == 0)//se destruye si el bloque ya alcanzo el limite de golpes
                        {
                            GameData.calculatePoints(Bricks[i,j].Tag.ToString());//se suman puntos
                            Controls.Remove(Bricks[i, j]);
                            Bricks[i, j] = null;//se elimina el bloque
                            lblPoints.Text = GameData.points.ToString();
                            Bricksdestroyed++;//sumamos la cantidad de bloques destruidos
                            if (Bricksdestroyed==40)//limite de bloques en el juego
                            {
                                // actualizamos el puntaje y reiniciamos algunos componentes en caso de empezar otra partida
                                tmGame.Stop(); 
                                PlayerCRUD.updatePlayerScore(GameData.points,PlayerCRUD.id_player);
                                GameData.lifes = 3;
                                GameData.points = 0;
                                GameData.dirX = 20;
                                GameData.dirY = -GameData.dirX;
                                GameData.startedgame = false;
                                endedGame?.Invoke();
                            }
                        }
                        else
                        {   //aplica en bloques que soportan mas de un golpe
                            //cambiamos la imagen dependiendo del color para indicar que el bloque ha sido dañado 
                            String imagen = Bricks[i, j].Tag.ToString().Substring(0, 1);
                            String nuevaimagen = imagen+Bricks[i, j].Tag.ToString().Substring(0,2); 
                            Bricks[i,j].BackgroundImage=Image.FromFile("../../resources/"+nuevaimagen+"jpeg");
                            Bricks[i,j].Tag = nuevaimagen + "jpeg";
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