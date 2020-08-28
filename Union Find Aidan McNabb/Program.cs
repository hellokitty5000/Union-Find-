using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

namespace Union_Find_Aidan_McNabb
{
    class Program
    {
        static void Main(string[] args)
        {


            //Quickfind<char> quickfind = new Quickfind<char>(new List<char> { 'a', 'b', 'c', 'd', 'e' });
            Quickunion<char> quickUnion = new Quickunion<char>(new List<char> { 'a', 'b', 'c', 'd', 'e' });
            Console.WriteLine(quickUnion.union('a', 'b'));
           
            Console.ReadKey();
            //Quickunion<int> quickUnion;
        }
    }
}
