using System;
using System.Collections.Generic;
using System.Text;
using Lab06_Interfaces.Interface;

namespace Lab06_Interfaces.Classes.Mammal__Canine_
{
   abstract class Canine : Mammal, ISwim
    {
        public abstract bool MansBestFriend { get; set; }
        public override string Sound()
        {
            return "Woof Woof";
        }
        // implements Swim interface
        public string Swim()
        {
            return "Now thats what I call a doggy paddle ;D";
        }
    }
}
