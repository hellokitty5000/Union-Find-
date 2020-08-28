using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Union_Find_Aidan_McNabb
{
    public class Quickfind<T>
    {
        private int[] sets;
        private Dictionary<T,int> map;

        public Quickfind(IEnumerable<T> items)
        {
            sets = new int[items.Count()];
            map = new Dictionary<T,int>(items.Count());
            int i = 0;
            foreach (var item in items)
            {
                sets[i] = i;
                map[item] = i;
                i++;
            }
        }
        public int find(T first) => sets[map[first]];

        public bool union(T first, T second)// if false then they were already in the same set
        {
            if (map[first] == map[second])
                return false;

            sets[map[first]] = sets[map[second]];
            map[first] = map[second];
            return true;

                
        }
        


    }
}
