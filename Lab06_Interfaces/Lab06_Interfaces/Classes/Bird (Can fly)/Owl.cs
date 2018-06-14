using System;
using System.Collections.Generic;
using System.Text;
using Lab06_Interfaces.Interface;


namespace Lab06_Interfaces.Classes.Bird__Can_fly_
{
    class Owl : DoesFly, IFly

    {
        public virtual bool Nocturnal { get; set; } = true;
        public override string Sound()
        {
            return "Hoot Hoot";
        }
        public string Fly { get; set; } = "Swoosh";
    }
}
