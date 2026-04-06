using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evolution.Core
{
    class Food : Entity
    {
        private int EnergyValue;

        public Food(int x, int y)
        {
            Symbol = '*';
            X = x;
            Y = y;
        }
    }
}
