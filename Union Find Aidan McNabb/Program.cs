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
            Quickunion<string> quickUnion = new Quickunion<string>(new List<string> {
            "Chandler",
            "Joey",
            "Phoebe",
            "Ross",
            "Monica",
            "Rachael",
            "Michael",
            "Jim",
            "Pam",
            "Dwight",
            "Kelly",
            "Ryan",
            "Creed"});
            quickUnion.union("Chandler", "Joey");
            quickUnion.union("Joey", "Phoebe");
            quickUnion.union("Monica", "Rachael");
            quickUnion.union("Chandler", "Ross");
            quickUnion.union("Jim", "Pam");
            quickUnion.union("Pam", "Dwight");
            quickUnion.union("Michael", "Ryan");
            quickUnion.union("Ryan", "Kelly");
            quickUnion.union("Dwight", "Creed");
            quickUnion.union("Joey", "Creed");

            Console.WriteLine("Phoebe is friends with Rachael: " + quickUnion.areConnected("Phoebe", "Rachael"));
            Console.WriteLine("Jim is friends with Creed: " + quickUnion.areConnected("Jim", "Creed"));
            Console.WriteLine("Michael is friends with Pam: " + quickUnion.areConnected("Michael", "Pam"));
            Console.WriteLine("Chandler is friends with Creed: " + quickUnion.areConnected("Chandler", "Creed"));

            Console.WriteLine("Friend Groups: " + quickUnion.friendGroups);
            Console.ReadKey();
            //Quickunion<int> quickUnion;
        }
    }
}
