using System;
using System.Collections.Generic;
using System.Text;

namespace Lab06_Interfaces.Classes
{
    class Eel : Cartilaginous
    {
        public override bool HasTeeth { get; set; } = false;
        public virtual bool IsNocturnal { get; set; } = true;
        public override string Sushify()
        {
            return "Yummy";
        }
    }

}
