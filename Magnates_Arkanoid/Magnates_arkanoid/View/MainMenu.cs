using System;
using System.Collections.Concurrent;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.SqlServer.Server;

namespace Magnates_arkanoid
{
    public partial class MainMenu : Form
    {
        private StartMenu start; 
        private Top top;
        private User user;
        private Play play;
        public MainMenu()
        {
            InitializeComponent();
            Height = ClientSize.Height;
            Width = ClientSize.Width;
            WindowState = FormWindowState.Maximized;
        }
       
        protected override CreateParams CreateParams//Mejora en la interfaz grafica 
        {
            get
            {
                CreateParams handleParam = base.CreateParams;
                handleParam.ExStyle |= 0x02000000;
                return handleParam;
            }
        }
        private void MainMenu_Load(object sender, EventArgs e)
        {
            
            start=new StartMenu();
            start.Dock = DockStyle.Fill;
            start.Width = Width;
            start.Height = Height;
            play = new Play();
            play.Dock = DockStyle.Fill;
            play.Width = Width;
            play.Height = Height;
            top= new Top();
            top.Dock = DockStyle.Fill;
            top.Width = Width;
            top.Height = Height;
            Controls.Add(start);
            user=new User();
            user.Dock = DockStyle.Fill;
            user.Width = Width;
            user.Height = Height;
            user.onClickAdd += onClickAdd;
            start.onClickButton += onClickJugar;
            start.onClickButtonTop += OnClickTop; 
            start.OnClickButtonExit += OnClickExit;
            user.onClickBack+=onClickBack;
        }

        public void OnClickTop(object sender, EventArgs e)
        {
            Controls.Remove(start);
            Controls.Add(top);
        }
        public void OnClickExit(object sender, EventArgs e)
        {
            Application.Exit();
        }
        public void onClickJugar(object sender, EventArgs e)
        {
            Controls.Remove(start); ;
            Controls.Add(user);
        }

        public void onClickAdd(object sender, EventArgs e)
        { 
           // if(user.txtUsuario.Text.Trim().Equals(""))
            Controls.Remove(user); 
            Controls.Add(play);
        }
        public void onClickBack(object sender, EventArgs e)
        { 
            // if(user.txtUsuario.Text.Trim().Equals(""))
            Controls.Remove(user); 
            Controls.Add(start);
        }
    }
}