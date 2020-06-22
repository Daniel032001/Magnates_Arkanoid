using System;
using System.Windows.Forms;

namespace Magnates_arkanoid.Controller
{
    public static class GameData
    {
        public static bool startedgame = false;
        public static int dirX = 20, dirY = -dirX;
        public static int lifes = 3;
        public static int points= 0;
        public static void calculatePoints(String brick)//dependiendo del valor de la propiedad tag de los bloques
        {                                            //asignamos una cantidad de puntos y la imagen del bloque agrietado si 
                                                    //resiste mas de un golpe
            try
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
                    default:
                        throw new InvalidTag("Invalid image name");
                        break;
                } 
            }
            catch (InvalidTag i)
            {
                MessageBox.Show(i.Message);
            }
        }
    }
}