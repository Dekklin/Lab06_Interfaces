using System;
using System.Collections.Generic;
using System.Text;

namespace Lab06_Interfaces.Classes
{
    class Sharks : Cartilaginous
    {
        public virtual bool IsHunter { get; set; } = true;
        public virtual bool CanGrowTeeth { get; set; } = true;
    }
}
