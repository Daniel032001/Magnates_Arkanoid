using System;
using System.Windows.Forms;

namespace Magnates_Arkanoid
{
    public partial class MainMenu : UserControl
    {
    private UserControl current = null;
        public MainMenu()
        {
            InitializeComponent();
           
        }

        private void buttonPlay_Click(object sender, EventArgs e)
        {
            //EVENTO DEL BOTON JUGAR
        }

        private void buttonScore_Click(object sender, EventArgs e)
        {
            //EVENTO DEL BOTON PUNTAJES
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            //EVENTO DEL BOTON SALIR
        }
        
    }
}