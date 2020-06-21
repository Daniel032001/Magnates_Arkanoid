using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace Magnates_arkanoid
{
    public static class PlayerCRUD
    {
        public static List<Player> getPlayerId()
        {
            List<Player> list = new List<Player>();
            try
            {
                string sql = "SELECT max(id) from player ";
                DataTable dt = DataBaseConnection.ExecuteQuery(sql);
                foreach (DataRow information in dt.Rows)
                {
                    Player players= new Player();
                    players.id = Convert.ToInt32(information[0].ToString()); 
                    list.Add(players);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Error" + e);
            }
            return list;
        }

        public static bool VerifyPlayer(String player)
        {
            bool flag = false;
            List<Player> list = new List<Player>();
            try
            {
                string sql = $"SELECT id_player from player where player='{player}'";
                DataTable dt = DataBaseConnection.ExecuteQuery(sql); 
                    foreach (DataRow information in dt.Rows)
                    {
                        Player players = new Player();
                        players.id = Convert.ToInt32(information[0].ToString());
                        list.Add(players);
                        flag = true;
                    } 
            }
            catch (Exception e)
            {
                MessageBox.Show("Error" + e);
            }
            return flag;
        }
        public static bool createPlayer(String nickname)
        {
            bool flag =false;
            try
            {
                string sql = String.Format("insert into player(player)"
                                           + "values('{0}')", nickname);
                    DataBaseConnection.Executenonquery(sql);
                MessageBox.Show("Registered Successfully");
                flag = true;
            }
            catch (Exception e)
            {
                MessageBox.Show("An error has ocurred" + e);
            }

            return flag;
        }

        public static void updatePlayerScore(int score,int id)
        {
            try
            {
                string sql = String.Format(
                    "update player set score={0} where id={1};",
                    score,id);
                DataBaseConnection.Executenonquery(sql);
                MessageBox.Show("Updated Score");
            }
            catch (Exception e)
            {
                MessageBox.Show("An error has ocurred" + e);
            }
        }
    }
}