using System.Windows.Forms;

namespace Magnates_arkanoid
{
    public class Brick: PictureBox
    {
        public int hits { get; set; }

        public Brick() : base()
        {
        }
    }
}