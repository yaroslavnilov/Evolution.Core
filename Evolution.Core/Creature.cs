using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evolution.Core
{
    class Creature : Entity
    {
        public Direction motion;

        public Creature(int x, int y)
        {
            Symbol = 'B';
            step = 1;
            X = x;
            Y = y;
        }



        

    }
}
