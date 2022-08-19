using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calctt
{
    internal class Program
    {
        

        static void Main(string[] args)
        {
            //------Objects
            var Course1 = new Implentation();
            var Course2 = new Implentation();
            var Course3 = new Implentation();
            var Course4 = new Implentation();
            var Course5 = new Implentation();
            var Course6 = new Implentation();
            var Course7 = new Implentation();
           




            //-----Results
            Console.WriteLine("Total");
            Console.WriteLine(Course1.CalcFunc("ACC 102", 2, 4));
            Console.WriteLine(Course2.CalcFunc("PSY 101", 2, 4));
            Console.WriteLine(Course3.CalcFunc("BF 101", 2, 1));
            Console.WriteLine(Course2.CalcFunc("MTH 112", 2, 3));
            Console.WriteLine(Course4.CalcFunc("MAN 142", 3, 5));
            Console.WriteLine(Course5.CalcFunc("GSP 102", 2, 2));
            Console.WriteLine(Course2.CalcFunc("GSP 106", 2, 5));
            



            Console.ReadLine();


        }
    }
}
