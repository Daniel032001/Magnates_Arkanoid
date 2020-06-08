using System;
using System.Drawing;
using System.Windows.Forms;

namespace Magnates_arkanoid
{ 
    public partial class Game : Form
    {
        private Brick[,] Bricks;
        public Game()
        {
            InitializeComponent();
            Height = ClientSize.Height;
            Width = ClientSize.Width;
            WindowState = FormWindowState.Maximized;
            
        }
        
        public void loadBricks()
        {
            int rows = 3, columns = 8;
            int brickHeight = (int)(Height*0.20)/rows;
            int brickWidth = Width/ columns;
            Bricks=new Brick[rows,columns]; 
            for (int i = 0; i < rows; i++)
            {
                for (int k = 0; k < columns; k++)
                {
                    Bricks[i, k] = new Brick();
                    if (i == 0)
                    {
                        Bricks[i, k].hits = 2;
                    }
                    else
                    {
                        Bricks[i, k].hits = 1;
                    } 
                    Bricks[i, k].Height =brickHeight;
                    Bricks[i, k].Width = brickWidth;
                    Bricks[i, k].Left = k * brickWidth;
                    Bricks[i, k].Top = i* brickHeight+80;
                    Bricks[i, k].BackgroundImage =Image.FromFile("../../resources/"+RdmNumber()+".jpg");
                    Bricks[i, k].BackgroundImageLayout = ImageLayout.Stretch;
                    Bricks[i, k].BorderStyle = BorderStyle.Fixed3D;
                    Bricks[i, k].Tag = "tileTag";
                    Controls.Add(Bricks[i,k]); 
                }
            }
        }

        private int RdmNumber()
        {
            return new Random().Next(1,6);
        }
        private void Game_Load(object sender, EventArgs e)
        {
            loadBricks();
            ptbTable.Left = Width / 2;
            ptbTable.Top = Height-100;
        }

        private void Game_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.D)
            {
                ptbTable.Left += 40;
            }
            else if (e.KeyData == Keys.A)
            {
                ptbTable.Left -= 40;
            }
        }
    }
}