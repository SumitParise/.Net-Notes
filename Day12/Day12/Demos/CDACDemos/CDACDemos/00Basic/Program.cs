using System;
using abc;

namespace _00Basic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n1 = 100;
            double d = 23.33;
            string str = "Hi";
            #region Hello World   
            //Console.WriteLine("Hello World!!");
            //Display(); 
            #endregion

            #region IF 
            //if (args.Length > 0) { }
            #endregion

            WordApp obj = new WordApp();

            CMath cmath = new CMath();
            cmath.Add(10, 20);
            cmath.Sub(40, 10);
            AdvanceMath advmath = new AdvanceMath();
            advmath.Add(10, 20);
            advmath.Add(10, 20, 30);
            advmath.Square(10);
            CMath cmath1=new AdvanceMath();
            cmath1.Add(10, 20);

            Console.ReadLine();
        }
        static void Display()
        {
            Console.WriteLine("Welcome To C#");
        }
    }
    public class MyClass:CMath
    {

    }
    public class CMath
    {
        public void Add(int x ,int y)
        {
            Console.WriteLine("Add :" + (x+y));
        }
        public void Sub(int x, int y)
        {
            Console.WriteLine("Sub : {0}",x - y);
            Console.WriteLine("X = {0}, Y = {1}",x,y);
        }
    }
    public class AdvanceMath :CMath
    {
        //overloading acress the classes
        //Shadowing 
        public new void Add(int x, int y)
        {
            Console.WriteLine("Add :" + (x + y +100));
        }
        public void Add(int x, int y, int z)
        {
            Console.WriteLine("Add :" + (x + y + z));
        }
        public void Square( int x)
        {
            Console.WriteLine("Square {0}", (x*x));
        }
    }

    #region Nested Namespace Demo 
    //ctr + K +C - comment
    //ctr+K+U - uncomment 
    //namespace IET
    //{
    //    class MyClass
    //    {

    //    }
    //}
    #endregion
}
