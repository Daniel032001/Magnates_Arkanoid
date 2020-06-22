using System.Windows.Forms;

namespace Magnates_arkanoid
{
    public class Brick: PictureBox//clase usada para manejar los bloques como picturebox
    {
        public int hits { get; set; }

        public Brick() : base()
        {
        }
    }
}