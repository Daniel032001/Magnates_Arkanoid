using System;
using System.Windows.Forms;

namespace Magnates_arkanoid
{
    public partial class Top : UserControl
    {
        public Top()
        {
            InitializeComponent();
            dtgTop.DataSource = ScoreCRUD.loadTopPlayers();
            dtgTop.Columns[2].Visible = false;
            dtgTop.Columns[0].Visible = false;
        }
    }
}