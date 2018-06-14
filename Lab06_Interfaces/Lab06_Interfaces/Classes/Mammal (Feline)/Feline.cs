using System;
using System.Collections.Generic;
using System.Text;

namespace Lab06_Interfaces.Classes
{
    abstract class Feline : Mammal
    {
        public virtual bool IsSassy { get; set; } = true;
        public override int HasLives { get; set; } = 9;
        public virtual bool AvoidHumans { get; set; } = false;
    }
}
