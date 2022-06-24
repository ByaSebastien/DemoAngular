using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    public class Map
    {
        public string nom;
        public int age;
        private List<List<int>> _Map = new List<List<int>>();
        public Map()
        {
            for(int i = 0; i < 5; i++)
            {
                List<int> ints = new List<int>();
                for(int j = 0; j < 5; j++)
                {
                    ints.Add(i * j);
                }
                _Map.Add(ints);
            }
        }
        public int this[int x, int y]
        {
            get => _Map[x][y];
            set => _Map[x][y] = value;
        }
        public void Methode()
        {
        }
    }
}
