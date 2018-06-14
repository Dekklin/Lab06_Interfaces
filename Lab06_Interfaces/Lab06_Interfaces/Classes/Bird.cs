using System;
using System.Collections.Generic;
using System.Text;

namespace Lab06_Interfaces.Classes
{
    abstract class Bird : Animal
    {
        public abstract bool CanFly { get; set; }
        public override bool IsWarmBlooded { get; set; } = true;
        public virtual bool HasFeathers { get; set; } = true;
        public override bool HasTeeth { get; set; } = false;
        public virtual int LayEggs()
        {
            return 5;
        }
        public virtual string Sing()
        {
            return "tweet tweet tweet";
        }
    }
}
