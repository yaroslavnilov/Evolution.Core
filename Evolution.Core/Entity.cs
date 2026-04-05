using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evolution.Core
{
    public class Entity
    {
        protected int x, y;
        protected bool IsPassable;
        public char Symbol { get; protected set; }
    }
}
