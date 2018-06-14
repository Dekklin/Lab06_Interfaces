using System;
using System.Collections.Generic;
using System.Text;

namespace Lab06_Interfaces.Classes.Mammal__Feline_
{
    class Kitty : Feline
    {
        public override bool AvoidHumans { get; set; } = false;
        public virtual bool OwnsHumans { get; set; } = true;
        public override string Sound()
        {
            return "meow";
        }
        public virtual string KnockOverStuff(string obj)
        {
            return $"Broken {obj}";
        }
    }
}
