using System;
using System.Collections.Generic;
using System.Text;

namespace Lab06_Interfaces.Classes.Reptile__Lizard_
{
    abstract class Lizard : Reptile
    {
        public virtual int LayEggs()
        {
            //6 eggs
            return 6;
        }
    }
}
