using System;
using System.Collections.Generic;
using System.Text;
using Lab06_Interfaces.Interface;


namespace Lab06_Interfaces.Classes.Bird__Can_fly_
{
    class Eagle : DoesFly, IFly
    {
        public virtual bool Majestic { get; set; } = true;
        public string Fly()
        {
            return "fffffffffffffffwooooooooooosssshhhhh";
        }
    }
}
