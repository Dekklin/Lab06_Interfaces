using System;
using System.Collections.Generic;
using System.Text;

namespace Lab06_Interfaces.Classes
{
    class Cougar : Feline
    {
        public override bool CanPet { get; set; } = false;
        public override bool AvoidHumans { get; set; } = true;
    }
}
