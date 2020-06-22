using System;

namespace Magnates_arkanoid.Controller
{
    public class InvalidTag:Exception
    {
        public InvalidTag(string message):base(message)
        {
        }
    }
}