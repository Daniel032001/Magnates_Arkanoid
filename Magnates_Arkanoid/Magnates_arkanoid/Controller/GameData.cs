using System;

namespace Magnates_arkanoid.Controller
{
    public static class GameData
    {
        public static bool startedgame = false;
        public static int dirX = 15, dirY = -dirX;
        public static int lifes = 3;
        public static int points= 0;
        public static void calculatePoints(String brick)
        {
            switch (brick)
            {
                case "11.jpeg":
                case "44.jpeg":
                    points += 12;
                    break;
                case "22.jpeg":
                    points += 15;
                    break;
                case "33.jpeg":
                    points += 10;
                    break; 
                case "55.jpeg":
                    points += 8;
                    break;
                case "1.jpg":
                    points += 1;
                    break;
                case "2.jpg":
                    points += 2;
                    break;
                case "3.jpg":
                    points += 3;
                    break;
                case "4.jpg":
                    points += 2;
                    break;
                case "5.jpg":
                    points += 1;
                    break;
            } 
        }
    }
}