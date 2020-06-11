using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace Magnates_arkanoid
{
    public static class PlayerCRUD
    {
        public static List<Player> loadTopPlayers()
        {
            List<Player> list = new List<Player>();
            try
            {
                string sql = "SELECT id,nickname,score from player order by score DESC limit 10";
                DataTable dt = DataBaseConnection.ExecuteQuery(sql);
                foreach (DataRow information in dt.Rows)
                {
                    Player top = new Player();
                    top.id = Convert.ToInt32(information[0].ToString());
                    top.nickname = information[1].ToString();
                    top.score = Convert.ToInt32(information[2].ToString());
                    list.Add(top);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Error" + e);
            }

            return list;
        }

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
        public static void createPlayer(String nickname)
        {
            try
            {
                string sql = String.Format("insert into player(nickname,score)"
                                           + "values('{0}',{1})", nickname, 0);
                    DataBaseConnection.Executenonquery(sql);
                MessageBox.Show("Registered Successfully");
            }
            catch (Exception e)
            {
                MessageBox.Show("An error has ocurred" + e);
            }
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