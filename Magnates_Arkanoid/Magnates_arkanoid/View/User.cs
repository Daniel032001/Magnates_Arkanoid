using System;
using System.Windows.Forms;

namespace Magnates_arkanoid
{
    public partial class User : UserControl
    {
        public StartMenu.EventUserControlStart onClickAdd;
        public User()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (onClickAdd!= null)
            {
                onClickAdd(this,e);
            }
        }
    }
}