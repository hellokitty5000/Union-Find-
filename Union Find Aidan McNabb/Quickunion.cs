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
            int count = 0;
            foreach (var item in items)
            {
                map[item] = count;
                parents[count] = count;
                count++;
            }
        }
        public int find(T first)
        {
            int value = parents[map[first]];
            while(value != parents[value])
            {
                value = parents[value];
            }
            return value;
        }
        public bool union(T first, T second)
        {// if false then they were already in the same set

            var a = find(first);
            var b = find(second);

            if (a == b)
            {
                return false;
            }
            parents[b] = map[first];
            return true;
            
           
        }
        public bool areConnected(T first, T second)
        {
            return find(first) == find(second);
        }
        private List<int> groupLeaders()
        {
            List<int> groupLeaders = new List<int>();
            foreach (var item in map.Keys)
            {
                groupLeaders.Add(find(item));
            }
            return groupLeaders;
        }

        public int friendGroups => groupLeaders().Distinct().ToList().Count;
        //list each person in all of the friend groups
        //print largest and smallest group
        //pass in a 0,1,2,3.... for which size group
    }
}
