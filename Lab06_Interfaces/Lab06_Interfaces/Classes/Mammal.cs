using System;
using System.Collections.Generic;
using System.Text;

namespace Lab06_Interfaces.Classes
{
    abstract class Mammal : Animal
    {
        public override bool IsWarmBlooded { get; set; } = true;
        public override bool HasTeeth { get; set; } = true;
        public virtual bool CanPet { get; set; } = true;
        public virtual int HasLives { get; set; } = 1;
    }
}
