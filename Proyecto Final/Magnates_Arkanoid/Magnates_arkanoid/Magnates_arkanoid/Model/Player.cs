namespace Magnates_arkanoid
{
    public class Player
    {
        public int id{ get; set; } 
        public string nickname { get;set; } 
        public int score { get; set; }
        public Player()
        {
            id = 0;
            score = 0;
            nickname = "";
        }
    }
}