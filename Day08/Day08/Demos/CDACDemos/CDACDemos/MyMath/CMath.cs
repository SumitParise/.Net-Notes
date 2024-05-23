using MyCustomAttribute;
namespace MyMath
{
    [Serializable]
    [Company(CompanyName ="(C)UpthrustSystems")]
    public class CMath
    {
        public int Add(int x,int y)
        {
            return x + y;
        }

        public int Sub(int x,int y) 
        { 
            return x - y; 
        }
    }
}
