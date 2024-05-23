using System;
using _Math;

namespace _01DataTypes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Input output code 
            //CMath cmath = new CMath();
            //Console.WriteLine("Enter value for X: ");
            //System.Int32 x = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Enter value for Y: ");
            //System.Int32 y = Convert.ToInt32(Console.ReadLine());
            //int result = cmath.Add(x, y);
            //Console.WriteLine("Result = {0}", result); 
            #endregion

            #region Loops
            //if (10>2)
            //{
            //    Console.WriteLine("true");
            //}
            //for (int j = 0; j < 10; j++)
            //{
            //    Console.WriteLine(j);
            //}
            ////while (true)
            ////{

            ////}
            //Console.WriteLine("Enter op");
            //int op = Convert.ToInt32(Console.ReadLine());

            //switch (op)
            //{
            //    case 0:
            //        Console.WriteLine("You chose Tea");
            //        break;
            //    default:
            //        Console.WriteLine("Invalid Choice");
            //        break;
            //} 
            #endregion

            CMath cmath1 =new CMath(10,20);

            AdvMath advMath = new AdvMath(100, 30, 40);
            Console.ReadLine();
        }
    }
}
