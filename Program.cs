using System;
using System.Collections.Generic;
using System.IO;

namespace Finder
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Given string: "+args[0]);

            Dictionary<char,int> directory = new Dictionary<char, int>();
            int i;
            for(i=0;i<args[0].Length;i++)
            {
                if (directory.ContainsKey(args[0][i]))
                {
                    directory[args[0][i]] += 1;
                    continue;
                }
                directory.Add(args[0][i],1);
            }
            for (i = 0; i < args[0].Length; i++)
            {
                if (directory.ContainsKey(args[0][i]) && directory[args[0][i]] == 1)
                {
                    
                    Console.WriteLine($"First found letter: '{args[0][i]}'");
                    break;
                }
            } 

            Console.ReadLine();
        }
    }
}
