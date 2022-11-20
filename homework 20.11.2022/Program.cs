using System.Net.WebSockets;
using System.Xml.Schema;

namespace homework_20._11._2022
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");

            #region method Calculator (+;-;*;/)
            Console.WriteLine(Sum(20, 30));
            Console.WriteLine(Subt(50, 10));
            Console.WriteLine(Mult(5.4, 2.5));
            Console.WriteLine(Divide(50, 2));


        }

        static int Sum(int num1, int num2)
        {
            return num1 + num2;
        }

        static int Subt(int num1, int num2)
        {
            return num1 - num2;
        }

        static double Mult(double num1, double num2)
        {
            return num1 * num2;
        }

        static int Divide(int num1, int num2)
        {
            return num1 / num2;
        } 
        #endregion


    }
}