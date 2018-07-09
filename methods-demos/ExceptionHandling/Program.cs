using System;
using System.IO;

namespace ExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            var text = File.ReadAllLines("../../../test1.txt");
            
            foreach(var line in text)
            {
                Console.WriteLine(line);
            }
        }
    }
}
