using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evolution.Core
{
    public class Entity
    {
        protected bool IsPassable;
        public char Symbol { get; protected set; }
        public int X { get; internal set; }
        public int Y { get; internal set; }
        public int step { get; protected set; }
    }
}
