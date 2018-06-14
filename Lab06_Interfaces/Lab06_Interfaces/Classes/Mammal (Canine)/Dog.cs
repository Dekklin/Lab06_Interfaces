using System;
using System.Collections.Generic;
using System.Text;

namespace Lab06_Interfaces.Classes.Mammal__Canine_
{
    class Dog : Canine
    {
        public override bool CanPet { get; set; } = true;
        public override bool MansBestFriend { get; set; } = true;
        
    }
}
