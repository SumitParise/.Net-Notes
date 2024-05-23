using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01DataTypes
{
    internal class Demo
    {
        public void Func() 
        {
            Console.WriteLine("Enter a number :");
            // ref to value type convertion - Unboxing
            int x = Convert.ToInt32(Console.ReadLine());
            int y = x;
            int j = 10;
            double d = 23.33;
            j = (int)d;
            
            // value type to ref type convertion - Boxing
            string str = Convert.ToString(y);
            
            string greet = "Hi";
            Object obj = greet; //Type-Casting
            string greetAgain = obj.ToString();//Type-Casting
           // String str1 = new String();
        }
    }
}
