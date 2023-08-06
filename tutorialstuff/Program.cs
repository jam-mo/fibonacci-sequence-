using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace tutorialstuff
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            var counter = 0;
            var fibonacciNumbers = new List<int> {0,1};
            while (counter < 21) {
                var previous = fibonacciNumbers[fibonacciNumbers.Count - 1];
                var previous2 = fibonacciNumbers[fibonacciNumbers.Count - 2];

                fibonacciNumbers.Add(previous + previous2);
                counter++;
            }
            foreach (var number in fibonacciNumbers)
                Console.WriteLine(number);
            
            
            Console.ReadLine();
        }
    }
}
