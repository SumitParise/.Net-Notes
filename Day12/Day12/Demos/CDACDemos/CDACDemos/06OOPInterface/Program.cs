namespace _06OOPInterface
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ColdDrink coldObj=new ColdDrink();
            Console.WriteLine(coldObj.GetDrink()); ;
        }
    }
    public interface IDrink
    {
        string GetDrink();
    }
    public class ColdDrink : IDrink
    {
        public string GetDrink()
        {
            return "Coke";
        }
    }
    public class HotDrink:IDrink
    {
        public string GetDrink()
        {
            return "Tea";
        }
    }
    public class Mocktails : IDrink
    {
        public string GetDrink()
        {
            return "Mojito";
        }
    }
}
