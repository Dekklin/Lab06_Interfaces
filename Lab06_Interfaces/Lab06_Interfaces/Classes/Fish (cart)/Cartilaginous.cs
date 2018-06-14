using System;
using System.Collections.Generic;
using System.Text;

namespace Lab06_Interfaces.Classes
{
    abstract class Cartilaginous : Fish
    {
        public override bool HasBones { get; set; } = false;
    }
}
