using System;
using System.Collections.Generic;
using System.Text;

namespace Lab06_Interfaces.Classes.Reptile__Snake_
{
    abstract class Snake : Reptile
    {
        public abstract bool CanCode { get; set; }
        public override string Eat()
        {
            return "Gulp";
        }
        
    }
}
