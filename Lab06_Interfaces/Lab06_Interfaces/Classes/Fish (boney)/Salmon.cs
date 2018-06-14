using System;
using System.Collections.Generic;
using System.Text;

namespace Lab06_Interfaces.Classes
{
    class Salmon : Boney
    {
        public override bool IsWarmBlooded { get; set; } = true;
        public override string Sushify()
        {
            return "Yummy";
        }
    }
}
