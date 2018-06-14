using System;
using System.Collections.Generic;
using System.Text;
using Lab06_Interfaces.Interface;


namespace Lab06_Interfaces.Classes.Reptile__Lizard_
{
    class Crocodile : Lizard, ISwim
    {
        public override int LayEggs()
        {
            return 3;
        }
        // ISwim interface 
        public string Swim()
        {
            return "Ahh scary!";
        }

        public override string Eat()
        {
            return "chomp chomp";
        }
    }
}
