using System.Security.Cryptography;

namespace _17Delegate
{
    public delegate void MyDelegate1();
    public delegate void MyDelegate2(string name);
    public delegate bool MyDelegate3(int rating);
    internal class Program
    {       
        static void Main(string[] args)
        {
            #region MyRegion
            //MyDelegate1 myDel1 = new MyDelegate1(SayHi);
            //myDel1();
            //MyDelegate2 myDel2 =new MyDelegate2(SayBye);
            //Console.WriteLine("Enter your name: ");
            //string nm = Console.ReadLine();
            //myDel2(nm); 
            #endregion

            //Console.WriteLine("Enter rating for employee based on observations:");
            //int rating = Convert.ToInt32(Console.ReadLine());
            //Employee employee = new Employee();
            //MyDelegate3 myDel3 = new MyDelegate3(employee.Increment);
            //bool result = myDel3(rating);
            //if(result)
            //{
            //    Console.WriteLine("Congratualtions!");
            //}

        }
        public static void SayHi()
        {
            Console.WriteLine("Hi");
        }
        public static void SayBye(string name)
        {
            Console.WriteLine("Bye {0}", name);
        }
    }

    public class Employee
    {
        public bool Increment(int rating)
        {
            if(rating >7)
            {
                return true;
            }
            else
            {
                return false
;            }
        }
    }
}

//Assignment : Write app : invoke series of events .
// Report demo.Parse->Validate-->Revalidate->Save : invoke these methods
// in series by using events and delegate concept.
//Client special request - to save time please do not revalidate.
// then run sequence in such a way: as  - Parse->Validate-->Save