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
            dtgTop.DataSource = ScoreCRUD.loadTopPlayers();//cargamos el top 10 y 
            dtgTop.Columns[2].Visible = false;// ocultamos id player
            dtgTop.Columns[0].Visible = false;//y el id de los puntajes
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