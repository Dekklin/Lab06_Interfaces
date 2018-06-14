using System;
using System.Collections.Generic;
using System.Text;

namespace Lab06_Interfaces.Classes
{
    abstract class Reptile : Animal
    {
        public override bool IsWarmBlooded { get; set; } = false;
        public override bool HasTeeth { get; set; } = true;
    }
}
