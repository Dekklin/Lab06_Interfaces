using System;
using System.Collections.Generic;
using System.Text;

namespace Lab06_Interfaces.Classes
{
    abstract class Animal
    {
        public abstract bool IsWarmBlooded { get; set; }
        public abstract bool HasTeeth { get; set; }
        public virtual string Sound()
        {
            return "...";
        }
        public virtual string Sleep()
        {
            return "ZzzzZzz";
        }
        public virtual string Eat()
        {
            return "Nom nom nom";
        }
    }
}
