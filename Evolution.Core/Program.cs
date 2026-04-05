using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evolution.Core
{
    class Program
    {
        static void Main(string[] args)
        {
            World world = new World();

            world.PrintWorld();

            Console.ReadLine();
        }
    }
}
