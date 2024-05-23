using System;
using MyMathLib;

namespace _14CalulatorApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyMath myMathObj =new MyMath();
            myMathObj.Add(2, 3);
            CMath cmath =new CMath();
            cmath.MyDiv();
            Console.ReadLine();
            
        }
    }
    public class CMath:MyMath
    {
        public void MyDiv()
        {
            this.Mult(2, 3);
            this.Square(10);

        }
    }
}
