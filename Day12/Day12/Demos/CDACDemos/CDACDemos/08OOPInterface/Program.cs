namespace _08OOPInterface
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your Choice");
            int choice = Convert.ToInt32(Console.ReadLine());

            if (choice == 1)
            {
                IX xobj = new PlatinumMath();
                xobj.Add(2,3);
            }
            else
            {
                IY yObj = new PlatinumMath();
                yObj.Add(2,3);
            }

            #region First approach 
            //if(choice == 1) 
            //{
            //    IX xObj = new CMath();
            //    xObj.Add(2,3);
            //}else if( choice == 2)
            //{
            //    IY yobj = new AdvMath();
            //    yobj.Add(2,3);
            //}
            //else
            //{

            //} 
            #endregion

        }
    }
    public interface IX
    {
        void Add(int x,int y);
        void Sub(int x,int y);
    }
    public interface IY
    {
        void Add(int x,int y);
        void Sub(int x,int y);
        void Square(int x);
    }
    //public class CMath:IX
    //{
    //    public void Add(int x,int y)
    //    {
    //        Console.WriteLine("Add {0}", (x+y));
    //    }
    //    public void Sub(int x, int y)
    //    {
    //        Console.WriteLine("Sub {0}", (x - y));
    //    }
    //}
    //public class AdvMath:IY
    //{
    //    public void Add(int x, int y)
    //    {
    //        Console.WriteLine("Add {0}", (x + y + 100));
    //    }
    //    public void Sub(int x, int y)
    //    {
    //        Console.WriteLine("Sub {0}", (x - y *100));
    //    }
    //    public void Square(int x)
    //    {
    //        Console.WriteLine("Square {0}", (x * x));
    //    }
    //}
    public class PlatinumMath : IX, IY
    {
        void IX.Add(int x, int y)
        {
            Console.WriteLine("Add {0}", (x + y));
        }

        void IY.Add(int x, int y)
        {
            Console.WriteLine("Add {0}", (x + y + 100));
        }

        void IY.Square(int x)
        {
            Console.WriteLine("Square {0}", (x * x)); ;
        }

        void IX.Sub(int x, int y)
        {
            Console.WriteLine("Sub {0}", (x - y));
        }

        void IY.Sub(int x, int y)
        {
            Console.WriteLine("Sub {0}", (x - y * 100));
        }
    }
}
