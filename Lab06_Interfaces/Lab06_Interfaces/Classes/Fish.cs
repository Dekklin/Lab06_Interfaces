using System;
using System.Collections.Generic;
using System.Text;
using Lab06_Interfaces.Interface;


namespace Lab06_Interfaces.Classes
{
    abstract class Fish : Animal, ISwim
    {
        public abstract bool HasBones { get; set; }
        public override bool HasTeeth { get; set; } = true;
        public override bool IsWarmBlooded { get; set; } = false;
        public virtual bool HasScales { get; set; } = true;
        public virtual bool HasGills { get; set; } = true;
        public string Swim()
        {
            return "Swimming swimming swimming, what do we do we swim swim AH AHAH AAHAHAHAAH";
        }
        public virtual string Sushify()
        {
            return "Yucky";
        }
    }
}
