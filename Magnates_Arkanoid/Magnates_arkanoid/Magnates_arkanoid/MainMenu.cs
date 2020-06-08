using System.Collections.Concurrent;
using System.Drawing;
using System.Windows.Forms;

namespace Magnates_arkanoid
{
    public partial class MainMenu : Form
    { 
        public MainMenu()
        {
            InitializeComponent();
            Height = ClientSize.Height;
            Width = ClientSize.Width;
            WindowState = FormWindowState.Maximized; 
        }
    }
}