using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace Magnates_arkanoid
{
    public static class ScoreCRUD
    {
        public static List<Score> loadTopPlayers()//cargamos el top 10 de jugadores 
        {
            List<Score> list = new List<Score>();
            try
            {
                string sql = "SELECT id_score,player,points from player,score where player.id_player=score.id_player"+
                " order by points DESC limit 10";
                DataTable dt = DataBaseConnection.ExecuteQuery(sql);
                foreach (DataRow information in dt.Rows)
                {
                    Score top=new Score();
                    top.id = Convert.ToInt32(information[0].ToString());
                    top.player= information[1].ToString();
                    top.points= Convert.ToInt32(information[2].ToString());
                    list.Add(top);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Error : " + e.Message);
            }
            return list;
        }
    }
}