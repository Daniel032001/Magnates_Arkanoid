using System;
using System.Collections.Concurrent;
using System.Drawing;
using System.Windows.Forms;

namespace Magnates_arkanoid
{
    public partial class MainMenu : Form
    {
        private StartMenu start; 
        private Top top;
        private User user;
        public MainMenu()
        {
            InitializeComponent();
            Height = ClientSize.Height;
            Width = ClientSize.Width;
            WindowState = FormWindowState.Maximized;
            start=new StartMenu();
            start.Dock = DockStyle.Fill;
            start.Width = Width;
            start.Height = Height;
            Controls.Add(start);
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
            start.onClickButton += onClickJugar;
            start.onClickButtonTop += OnClickTop; 
            start.OnClickButtonExit += OnClickExit;
        }

        public void OnClickTop(object sender, EventArgs e)
        {
            Controls.Remove(start);
            top= new Top();
            top.Dock = DockStyle.Fill;
            top.Width = Width;
            top.Height = Height;
            Controls.Add(top);
        }
        public void OnClickExit(object sender, EventArgs e)
        {
            Application.Exit();
        }
        public void onClickJugar(object sender, EventArgs e)
        {
            Controls.Remove(start);
            user=new User();
            user.Dock = DockStyle.Fill;
            user.Width = Width;
            user.Height = Height;
            user.onClickAdd += onClickAdd;
            Controls.Add(user);
        }

        public void onClickAdd(object sender, EventArgs e)
        {
            this.Hide();
            Game juego = new Game();
            juego.Show();
        }
    }
}