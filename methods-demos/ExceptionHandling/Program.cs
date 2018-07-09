using System;
using System.IO;

namespace ExceptionHandling
{
    class Program
    {
        static void Main(string[] args)

        {
            try
            {
                var text = File.ReadAllLines("../../../test1.txt");
                foreach (var line in text)
                {
                    Console.WriteLine(line);
                }
            }
            catch(FileNotFoundException ex)
            {
               // throw new FileNotFoundException();
                Console.WriteLine(ex.Message);
            }
            
        }
    }
}
