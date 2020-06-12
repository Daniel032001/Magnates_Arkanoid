using System;
using System.Drawing;
using System.Windows.Forms;

namespace Magnates_arkanoid
{
    public partial class StartMenu : UserControl
    {
        public delegate void EventUserControlStart(object sender, EventArgs e);
        public  EventUserControlStart onClickButton,onClickButtonTop,OnClickButtonExit;

        public StartMenu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (onClickButton!= null)
            {
                onClickButton(this,e);
            }
        }

        private void btnTop_Click(object sender, EventArgs e)
        {
            if (onClickButtonTop!= null)
            {
                onClickButtonTop(this,e);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            if (OnClickButtonExit!= null)
            {
                OnClickButtonExit(this,e);
            }
        }
    }

}