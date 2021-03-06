﻿using System;
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
        //usamos delegates para usarlos en el form para cambiar entre user controls:
        private void btnPlay_Click(object sender, EventArgs e)
        {
            if (onClickButton!= null)
            {
                onClickButton(this,e);
            }
        }

        private void btnTop_Click_1(object sender, EventArgs e)
        {
            if (onClickButtonTop!= null)
            {
                onClickButtonTop(this,e);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (OnClickButtonExit!= null)
            {
                OnClickButtonExit(this,e);
            }
        }
    }

}