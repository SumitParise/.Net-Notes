using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _Math
{
    public class CMath
    {
        //private int _X, _Y;
        private int x,_Y;

        public CMath()
        {
            Console.WriteLine("CMath Parameterless Ctor");
        }
        public CMath(int x, int y)
        {
            this.x = x;
            _Y = y;
            Console.WriteLine("X ={0}, Y ={1}", x, _Y);
        }
        public int  Add(int x, int y)
        {
            return x + y;
        }
    }
    public class AdvMath:CMath
    {
        private int _P;
        public AdvMath()
        {
            Console.WriteLine("AdvMath Parameterless Ctor");
        }
        public AdvMath(int p, int x,int y):base(x,y)
        {
            _P = p;
            Console.WriteLine("_P = {0}",_P);
        }
        //public void Display()
        //{
        //    base.Add();
        //}
    }
}
