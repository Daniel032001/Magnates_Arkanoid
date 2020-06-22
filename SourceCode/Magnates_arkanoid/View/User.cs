using System;
using System.Windows.Forms;
using Magnates_arkanoid.Controller;

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
            try
            {
                if (txtUser.Text.Trim().Equals("")) //validamos que no quede el campo vacio
                {
                    throw new NullNickname("You have to write your nick name");
                }
                else if (txtUser.Text.Length > 15)
                {
                    throw new InvalidLength("You have to write a nickname with less letters");
                }
                else
                {
                    if (PlayerCRUD.VerifyPlayer(txtUser.Text)
                    ) //verificamos si ya hay un jugador inscrito con ese nickname
                    {
                        MessageBox.Show("Welcome back " + txtUser.Text + "!");
                        if (onClickAdd != null)
                        {
                            onClickAdd(this, e);
                        }
                    }
                    else
                    {
                        if (PlayerCRUD.createPlayer(txtUser.Text)) //creamos un nuevo jugador
                        {
                            if (onClickAdd != null)
                            {
                                onClickAdd(this, e);
                            }
                        }
                    }
                }
            }
            catch (InvalidLength inv)
            {
                MessageBox.Show(inv.Message);
            }
            catch (NullNickname nullnick)
            {
                MessageBox.Show(nullnick.Message);
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