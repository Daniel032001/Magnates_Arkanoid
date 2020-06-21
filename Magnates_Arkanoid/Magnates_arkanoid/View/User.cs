using System;
using System.Windows.Forms;

namespace Magnates_arkanoid
{
    public partial class User : UserControl
    {
        public StartMenu.EventUserControlStart onClickAdd,onClickBack;
        public User()
        {
            InitializeComponent(); 
        }
        private void btnPlay_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text.Trim().Equals(""))
            {
                MessageBox.Show("You have to write your Nickname!");
            }
            else
            {
                if (PlayerCRUD.VerifyPlayer(txtUsuario.Text))
                {
                    MessageBox.Show("Welcome back "+txtUsuario.Text+"!");
                    if (onClickAdd != null)
                    {
                        onClickAdd(this, e);
                    }
                }
                else
                {
                    if (PlayerCRUD.createPlayer(txtUsuario.Text))
                    {
                        if (onClickAdd != null)
                        {
                            onClickAdd(this, e);
                        }
                    }    
                }
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if (onClickBack != null)
            {
                onClickBack(this, e);
            }
        }
    }
}