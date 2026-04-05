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
            SpawnObjects<Food>(0.05);

            // Генерируем сущности
            SpawnObjects<Creature>(0.03);
            
        }

        private void SpawnObjects<T>(double chance) where T : Entity, new()
        {
            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < height; j++)
                {
                    if (map[i, j] == null)
                    {
                        map[i, j] = random.NextDouble() < chance ? new T() : null;
                    }
                }
            }
        }

        public void PrintWorld()
        {
            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    if (map[i, j] != null) // Проверяем, что карта не пустая
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
