using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace Magnates_arkanoid
{
    public static class PlayerCRUD
    {
        public static int id_player=0 ,score= 0;
        public static void getPlayerId()//obtenemos el ultimo id registrado en el caso de los jugadores nuevos para actualizar
        {                                 //el puntaje si gana
            try
            {
                string sql = "SELECT max(id_player) from player ";
                DataTable dt = DataBaseConnection.ExecuteQuery(sql);
                foreach (DataRow information in dt.Rows)
                { 
                    id_player = Convert.ToInt32(information[0].ToString());  
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Error" + e.Message);
            } 
        }

        public static bool VerifyPlayer(String player)//se verifica si el jugador ya esta registrado
        {
            bool flag = false; 
            try
            {
                string sql = $"SELECT id_player from player where player='{player}'";
                DataTable dt = DataBaseConnection.ExecuteQuery(sql); 
                    foreach (DataRow information in dt.Rows)
                    {
                        id_player = Convert.ToInt32(information[0].ToString());
                        flag = true;
                    } 
            }
            catch (Exception e)
            {
                MessageBox.Show("Error" + e.Message);
            }
            return flag;
        }

        public static void createScore()//registramos al jugador inicialmente con 0 puntos
        {
            try
            {
                string sql = String.Format("insert into score(points,id_player)"
                                           + "values({0},{1})", 0,id_player);
                DataBaseConnection.Executenonquery(sql);
                MessageBox.Show("Registered Successfully");
                getPlayerId();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
        public static bool createPlayer(String nickname)//creamos jugador
        {
            bool flag =false;
            try
            {
                string sql = String.Format("insert into player(player)"
                                           + "values('{0}')", nickname);
                DataBaseConnection.Executenonquery(sql); 
                getPlayerId();//obtenemos ultimo id
                createScore();
                flag = true;
            }
            catch (Exception e)
            {
                MessageBox.Show("An error has ocurred" + e.Message);
            }
            return flag;
        }

        public static void getScore()//obtenemos el score para sumarlo al que obtuvo en la partida 
        {
            try
            {
                string sql = $"SELECT points from score where id_player='{id_player}'";
                DataTable dt = DataBaseConnection.ExecuteQuery(sql); 
                foreach (DataRow information in dt.Rows)
                {
                    score = Convert.ToInt32(information[0].ToString()); 
                } 
            }
            catch (Exception e)
            {
                MessageBox.Show("An error has ocurred" + e.Message);
            }
        }
        public static void updatePlayerScore(int points,int id)//actualizamos score
        {
            try
            {
                getScore();
                if(score<points)
                {
                    //sustituimos la mayor puntuacion del jugador
                    string sql = String.Format(
                        "update score set points={0} where id_player={1};",
                        points,id);
                    DataBaseConnection.Executenonquery(sql);   
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("An error has ocurred" + e.Message);
            }
        }
    }
}