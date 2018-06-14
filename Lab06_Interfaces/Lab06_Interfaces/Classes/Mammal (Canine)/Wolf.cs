using System;
using System.Collections.Generic;
using System.Text;

namespace Lab06_Interfaces.Classes.Mammal__Canine_
{
    class Wolf : Canine
    {
        public override bool CanPet { get; set; } = false;
        public override bool MansBestFriend { get; set; } = false;
    }
}
