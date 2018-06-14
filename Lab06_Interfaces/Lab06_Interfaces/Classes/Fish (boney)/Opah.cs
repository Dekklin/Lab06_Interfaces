using System;
using System.Collections.Generic;
using System.Text;

namespace Lab06_Interfaces.Classes
{
    class Opah : Boney
    {
        public override bool IsWarmBlooded { get; set; } = true;
        public virtual string FlapFins()
        {
            return "metabolism, movement, and reaction time increased";
        }
    }
}
