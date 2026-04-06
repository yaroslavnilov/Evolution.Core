using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evolution.Core
{
    class World
    {
        Random random = new Random();
        private int width = 30;
        private int height = 30;
        private Entity[,] map;
        public static readonly Wall GlobalWall = new Wall();

        public List<Creature> _creatures;

        public World()
        {
            map = new Entity[width, height];
            _creatures = new List<Creature>();

            // Заполняем границы в ширину
            for (int i = 0; i < width; i++)
            {
                map[i, 0] = GlobalWall;
                map[i, height - 1] = GlobalWall;
            }

            // Заполняем границы в высоту
            for (int i = 0; i < height; i++)
            {
                map[0, i] = GlobalWall;
                map[width - 1, i] = GlobalWall;
            }

            // Генерируем случайным образом объекты еды на карте
            SpawnFood(0.05);

            // Генерируем сущности
            SpawnCreatures(10);
            
        }

        private void SpawnFood(double chance)
        {
            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < height; j++)
                {
                    if (map[i, j] == null && random.NextDouble() < chance)
                    {
                        map[i, j] = new Food(i, j);
                    }
                }
            }
        }

        private void SpawnCreatures(int count)
        {
            int createdCount = 0;
            Random random = new Random();

            while (createdCount < count)
            {
                int randomX = random.Next(0, width);
                int randomY = random.Next(0, height);

                if (map[randomX, randomY] == null)
                {
                    Creature creature = new Creature(randomX, randomY);
                    map[randomX, randomY] = creature;
                    _creatures.Add(creature);
                    createdCount++;
                }
                else
                {
                    if (createdCount >= width * height)
                    {
                        break;
                    }
                }
            }
        }

        private void MoveCreature()
        {
            foreach (Creature creature in _creatures)
            {
                Direction action = creature.motion;

                var (x, y) = (creature.X, creature.Y);
                var (newX, newY) = NewCoordinates(action, creature.step, creature.X, creature.Y);

                if (newX >= 0 && newY >= 0 && newX < map.GetLength(0) && newY < map.GetLength(1))
                {
                    if (map[newX, newY] == null)
                    {
                        map[x, y] = null;
                        map[newX, newY] = creature;
                    }
                }
                else
                {
                    Console.WriteLine($"New coordinates ({newX}, {newY}) are out of bounds.");
                }
            }
        }

        public (int x, int y) NewCoordinates(Direction dir, int step, int x, int y)
        {
            switch (dir)
            {
                case Direction.Up:
                    return (x, y + 1);
                case Direction.Down:
                    return (x, y - 1);
                case Direction.Right:
                    return (x + 1, y);
                case Direction.Left:
                    return (x - 1, y);
                case Direction.Up_Right:
                    return (x + 1, y + 1);
                case Direction.Up_Left:
                    return (x - 1, y + 1);
                case Direction.Down_Right:
                    return (x + 1, y - 1);
                case Direction.Down_Left:
                    return (x + - 1, y - 1);
                default:
                    throw new Exception("Error: the motion vector is not recognized");
            }
        }

        public void PrintWorld()
        {
            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    if (map[i, j] != null)
                    {
                        Console.Write(map[i, j].Symbol + " ");
                    }
                    else
                    {
                        Console.Write("  ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
