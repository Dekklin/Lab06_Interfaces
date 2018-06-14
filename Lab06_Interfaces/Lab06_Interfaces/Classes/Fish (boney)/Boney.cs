using System;
using System.Collections.Generic;
using System.Text;

namespace Lab06_Interfaces.Classes
{
    abstract class Boney : Fish
    {
        public override bool HasBones { get; set; } = true;
        public override string Sushify()
        {
            return "Yummy";
        }
    }
}
