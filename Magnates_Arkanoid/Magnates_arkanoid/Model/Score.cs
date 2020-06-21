namespace Magnates_arkanoid
{
    public class Score
    {
        public int id{ get; set; } 
        public string player { get;set; } 
        public int id_player { get;set;}
        public int points{ get; set; }
        public Score()
        {
            id = 0;
            points = 0;
            player = "";
            id_player = 0;
        }
    }
}