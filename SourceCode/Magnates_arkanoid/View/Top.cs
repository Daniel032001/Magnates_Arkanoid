using System;
using System.Windows.Forms;

namespace Magnates_arkanoid
{
    public partial class Top : UserControl
    {
        public StartMenu.EventUserControlStart onClickBackTop;
        public Top()
        {
            InitializeComponent();
            dtgTop.DataSource = ScoreCRUD.loadTopPlayers();//cargamos el top 10 y ocultamos id player y el id de los puntajes
            dtgTop.Columns[2].Visible = false;
            dtgTop.Columns[0].Visible = false;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if (onClickBackTop != null)
            {
                onClickBackTop(this, e);
            }
        }
    }
}