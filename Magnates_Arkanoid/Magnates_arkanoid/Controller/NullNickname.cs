using System;

namespace Magnates_arkanoid.Controller
{
    public class NullNickname:Exception
    {
        public NullNickname(string message):base(message){}
    }
}