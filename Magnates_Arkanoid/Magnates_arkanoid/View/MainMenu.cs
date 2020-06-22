using System;
using System.Collections.Concurrent;
using System.Drawing;
using System.Windows.Forms;
using Magnates_arkanoid.Controller;
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
        private void MainMenu_Load(object sender, EventArgs e)//inicializamos todos los users para cargarlos en el form
        {
            start=new StartMenu();
            start.Dock = DockStyle.Fill;
            start.Width = Width;
            start.Height = Height;
            loadGameComponents();
            start.onClickButton += onClickPlay;//metodos suscritos a los delegates para cambiar entre user controls
            start.onClickButtonTop += onClickTop; 
            start.OnClickButtonExit += onClickExit;
            Controls.Add(start);
        }

        public void loadGameComponents()//cargamos user controls
        {
            user=new User();
            user.Dock = DockStyle.Fill;
            user.Width = Width;
            user.Height = Height;
            play = new Play();
            play.Dock = DockStyle.Fill;
            play.Width = Width;
            play.Height = Height;
            top= new Top();
            top.Dock = DockStyle.Fill;
            top.Width = Width;
            top.Height = Height;
            user.onClickBack+=onClickBack;
            user.onClickAdd += onClickAdd;
            play.endedGame += onFinishGame;
            top.onClickBackTop += onClickBackTop;
        }
        public void reloadGame()//reiniciamos los user controls al finalizar una partida
        {
            play= null;
            user = null;
            top = null;
            PlayerCRUD.updatePlayerScore(GameData.points,PlayerCRUD.id_player);
            GameData.lifes = 3;
            GameData.points = 0;
            GameData.dirX = 20;
            GameData.dirY = -GameData.dirX;
            GameData.startedgame = false;
            loadGameComponents();
        }
        public void onClickTop(object sender, EventArgs e)
        {
            Controls.Remove(start);
            Controls.Add(top);
        }
        public void onClickExit(object sender, EventArgs e)
        {
            MessageBox.Show("Thanks for play!");
            Application.Exit();
        }//cambiamos entre user controls
        public void onClickPlay(object sender, EventArgs e)
        {
            Controls.Remove(start);
            Controls.Add(user);
        }

        public void onClickAdd(object sender, EventArgs e)
        {
            Controls.Remove(user); 
            Controls.Add(play);
        }

        public void onFinishGame()
        {
            Controls.Remove(play);
            Controls.Add(start);
            reloadGame();
        }
        public void onClickBack(object sender, EventArgs e)
        {  
            Controls.Remove(user); 
            Controls.Add(start);
            user = null;
            user=new User();
            user.Dock = DockStyle.Fill;
            user.Width = Width;
            user.Height = Height; 
            user.onClickBack+=onClickBack;
            user.onClickAdd += onClickAdd;
        }

        public void onClickBackTop(object sender, EventArgs e)
        {
            Controls.Remove(top);
            Controls.Add(start);
        }
    }
}