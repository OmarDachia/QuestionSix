using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestionSix
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("#4 Write a Promgram to find average of 7 numbers.");
            Console.WriteLine("=========================================================================================");
            Console.WriteLine("User input:->");
            Console.WriteLine("+++++++++++++");

            double sub1 = 0, sub2 = 0, sub3 = 0, sub4 = 0, sub5 = 0, sub6 = 0, sub7 = 0, average = 0;
            Console.WriteLine("Enter the Number 1:->");
            double.TryParse(Console.ReadLine(), out sub1);
            Console.WriteLine("Enter the Number 2:->");
            double.TryParse(Console.ReadLine(), out sub2);
            Console.WriteLine("Enter the Number 3:->");
            double.TryParse(Console.ReadLine(), out sub3);
            Console.WriteLine("Enter the Number 4:->");
            double.TryParse(Console.ReadLine(), out sub4);
            Console.WriteLine("Enter the Number 5:->");
            double.TryParse(Console.ReadLine(), out sub5);
            Console.WriteLine("Enter the Number 6:->");
            double.TryParse(Console.ReadLine(), out sub6);
            Console.WriteLine("Enter the Number 7:->");
            double.TryParse(Console.ReadLine(), out sub7);



            average = ((sub1 + sub2 + sub3 + sub4 + sub5 + sub6 + sub7) / 7);

            Console.WriteLine("Result:->");
            Console.WriteLine("*********");
            Console.WriteLine(string.Format("Average {0} ", average));
            Console.ReadKey();
        }
    }
}
