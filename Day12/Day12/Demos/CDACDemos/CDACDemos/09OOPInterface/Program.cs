namespace _09OOPInterface
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //CMath cMath = new CMath();
            //cMath.Add(2, 3);
            IMath iMath = new CMath();
            iMath.Add(2, 3);
            Console.ReadLine();
        }
    }
    public interface IMath
    {
        public void Add(int x,int y)
        {
            Console.WriteLine("Interface ADD {0}",x + y);
        }

    }
    public class CMath : IMath
    {
        //public void Add(int x, int y)
        //{
        //    Console.WriteLine("Add {0}", (x + y+ 100));
        //}

        public void Sub(int x, int y)
        {
            Console.WriteLine("Sub {0}", (x - y));
        }
    }
   
}
