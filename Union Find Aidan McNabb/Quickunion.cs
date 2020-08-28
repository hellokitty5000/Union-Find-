using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Union_Find_Aidan_McNabb
{
    public class Quickunion<T>
    {
        private int[] parents;
        private Dictionary<T, int> map;

        public Quickunion(IEnumerable<T> items)
        {
            parents = new int[items.Count()];
            map = new Dictionary<T, int>(items.Count());
        }
        public int find(T first)
        {
            int value = map[first];
            while (parents[value] != 0)
            {
                value = parents[value];
            }
            return value;
        }
        public bool union(T first, T second)
        {// if false then they were already in the same set
            bool path = areConnected(first, second);
            if(path)
            {
                return false;
            }
            parents[find(second)] = map[first];
            return true;
            
           
        }
        public bool areConnected(T first, T second)
        {
            return find(first) == find(second);
        }
    }
}
