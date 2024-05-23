using System;


namespace MyMathLib
{
    public class MyMath
    {
        //Public - Accessible within Assembly and Outside Assembly ,
        //throughtout Application
        public void Add(int x,int y)
        {
            Console.WriteLine("Add = {0}", (x+y));
        }
        //Private - Accessible within Class only ,
        //not in same assembly or Outside Assembly ,
        private void sub(int x, int y)
        {
            Console.WriteLine("Sub = {0}", (x - y));
        }
        //Protected - Accessible within hierarchy of inherited classes
        //and accessible Outside Assembly but only through inherited classes,
        protected void Mult(int x, int y)
        {
            Console.WriteLine("Mult = {0}", (x * y));
        }
        //Internal - Accessible within Assembly,throughtout Application
        //Not accessible Outside Assembly ,
        internal void Div(int x, int y)
        {
            Console.WriteLine("Div = {0}", (x / y));
        }
        //Protected internal - Accessible within and outside Assembly,
        //but only within inherited hierarchy of classes.
        protected internal void Square(int x)
        {
            Console.WriteLine("Square = {0}", (x * x));
        }
    }
}
