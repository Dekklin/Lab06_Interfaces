using System;
using System.Collections.Generic;
using System.Text;


namespace Lab06_Interfaces.Classes.Bird__Can_fly_
{
    abstract class DoesFly : Bird
    {
        public override bool CanFly { get; set; } = true;
    }
}
