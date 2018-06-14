using System;
using System.Collections.Generic;
using System.Text;

namespace Lab06_Interfaces.Classes.Bird__Can_t_Fly_
{
    abstract class DoesntFly : Bird
    {
        public override bool CanFly { get; set; } = false;
        public virtual bool IsHappy { get; set; }
        //this is technically a test for myself to see if penguin can evoke the true if statement.
        public virtual string Dance()
        {
            if (IsHappy == true)
                return "Happy Feet";
            else
                return "...";
        }
    }
}
