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
            loadBricks();
        }
        
        public void loadBricks()
        {
            int rows = 10, columns = 5;
            int pHeight = (int)(Height*0.3)/columns;
            int pWidth = Width/ rows;
            Bricks=new Brick[rows,columns];
            for (int i = 0; i < columns; i++)
            {
                for (int k = 0; k < rows; k++)
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
                    Bricks[i, k].Height = pHeight;
                    Bricks[i, k].Width = pWidth;
                    Bricks[i, k].Left = k * pWidth;
                    Bricks[i, k].Top = i * pHeight;
                    Bricks[i, k].BackgroundImage=Image.FromFile("../../Resources/1"+".JPG");
                    Bricks[i, k].BackgroundImageLayout = ImageLayout.Stretch;
                    Bricks[i, k].Tag = "TileTag";
                    Controls.Add(Bricks[i,k]);
                }
            }
        }
    }
}