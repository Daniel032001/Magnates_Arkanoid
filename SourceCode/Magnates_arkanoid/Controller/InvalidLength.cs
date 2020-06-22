using System;

namespace Magnates_arkanoid.Controller
{
    public class InvalidLength:Exception
    {
        public InvalidLength(string message):base(message){}
    }
}