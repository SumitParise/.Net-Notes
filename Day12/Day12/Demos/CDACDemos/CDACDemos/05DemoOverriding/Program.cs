namespace _05DemoOverriding
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
        }
    }
    public class CMath
    {
        public virtual void Add(int x, int y)
        {
            Console.WriteLine("Add = {0}",(x+y));
        }
        public void Sub(int x, int y)
        {
            Console.WriteLine("Sub = {0}", (x - y));
        }
        public virtual void Mul(int x, int y)
        {
            Console.WriteLine("Mul = {0}", (x * y));
        }
        public virtual void Div(int x, int y)
        {
            Console.WriteLine("Div = {0}", (x / y));
        }
    }
    public class AdvMath:CMath
    {
        public override void Add(int x, int y)
        {
            Console.WriteLine("Add = {0}", (x + y +100));
        }
        public void Square(int x)
        {
            Console.WriteLine("Square = {0}", (x*x));
        }

        public override void Mul(int x, int y)
        {
            // base.Mul(x, y);
            Console.WriteLine("Square = {0}", (x * y * 20));
        }
    }
}
