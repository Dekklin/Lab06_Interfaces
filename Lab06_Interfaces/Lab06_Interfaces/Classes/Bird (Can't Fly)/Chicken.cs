using System;
using System.Collections.Generic;
using System.Text;

namespace Lab06_Interfaces.Classes.Bird__Can_t_Fly_
{
    class Chicken : DoesntFly
    {
        public override bool IsHappy { get; set; } = false;

        public override int LayEggs()
        {
            return 9000;
        }
    }
}
