using System.Collections;
using System.Security.Cryptography;

namespace _23CSharpFeatures
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Implicit Type - var 
            ////int i = 100;
            ////Emp emp =new Emp() { No =1, Name="Hugh Jackman", Address="New York"};

            ////object i = 100;
            ////object emp = new Emp() { No = 1, Name = "Hugh Jackman", Address = "New York" };

            ////var i = 100;
            ////Console.WriteLine(i.GetType().ToString());

            ////var emp = new Emp() { No = 1, Name = "Hugh Jackman", Address = "New York" };
            ////Console.WriteLine(emp.GetType().ToString());

            ////var has always local scope
            //// Implicit type var is getting defination at compile tile
            ////depending upon right hand sde of = operator var gets its type.
            ////var can not be used as a method Parameter type or return type.

            //Console.WriteLine("Enter choice");
            //var choice = Convert.ToInt32(Console.ReadLine());
            ////var temp; //-- not allowed by compiler 

            //var containerForSomething = Demo.GetMeSomething(choice);
            //Console.WriteLine(containerForSomething.GetType().ToString());
            //if(containerForSomething is Emp)
            //{
            //    Emp e = (Emp)containerForSomething;
            //    Console.WriteLine("No= {0}, Name ={1}",e.No,e.Name);
            //}
            //ArrayList arr =new ArrayList() { 1,2,3,4,5};
            //foreach(var item in arr)
            //{
            //    Console.WriteLine(item);
            //} 
            #endregion

            #region Anonymous Types 
            //////Property Name and Sequence the way we declared and initialized ,
            //////matters while creating multiple objects of Anonymous Types
            ////// Emp emp = new Emp() { No = 1, Name = "Hugh Jackman", Address = "New York" };

            //////var emp = new Emp() { No = 1, Name = "Hugh Jackman", Address = "New York" };

            //var v1 = new { No = 1, Name = "Hugh Jackman", Address = "New York" };
            // v1.Name = "Pasad";

            //Console.WriteLine(v1.GetType().ToString());

            //var v2 = new { No = 2, Name = "Sagar", Address = "Mumbai" };
            //Console.WriteLine(v2.GetType().ToString());

            //var v5 = new { No = 2, Name = 1000, Address = "Mumbai" };
            //Console.WriteLine(v5.GetType().ToString());

            //var v4 = new { No = 2, Nm = "Sagar", add = "Mumbai" };
            //Console.WriteLine(v4.GetType().ToString());

            //var v3 = new { Address = "Pune", No = 12, Name = "Sagar" };
            //Console.WriteLine(v3.GetType().ToString());
            #endregion

            #region Partial Methods 
            //CMath obj =new CMath();
            //obj.First = 100;
            //obj.Second = 200; 
            #endregion

            #region Auto Properties
            //Customer customer = new Customer() {CId =20,CName="Ben Stiller",CAddress="New Jersey" };
            //Console.WriteLine(customer.GetCustomerDetails()); 
            ////customer.CId = 100;
            ////customer.CAddress = "Pune"; 
            #endregion

            #region Extension Methods 

            #region Inbuilt Extension methods for Array type
            //int[] arr = { 1, 2, 3, 4, 5 };
            //double avg = arr.Average();
            //int addition = arr.Sum();
            //double[] d = { 11.11,22.22};

            //Console.WriteLine(addition);
            #endregion

            //Console.WriteLine("Enter your email id");

            //string ?emailStr= Console.ReadLine();
            // MyString strObj = new MyString();
            //bool isValid =strObj.CheckForValidEmail(emailStr);

            // bool isValid =MyString.CheckForValidEmail(emailStr);

            //bool isValid = emailStr.CheckForValidEmail(10,23.33);
            //string str = "abcd@google.com";
            //bool result = str.CheckForValidEmail(2345,3333.3333);
            //int no = 20;
            //no.CheckForValidEmail<int>(2,3);
            //bool isValid = emailStr.CheckForValidEmail();
            //if (isValid)
            //{
            //    Console.WriteLine("{0} is valid email id", emailStr);
            //}
            //else
            //{
            //    Console.WriteLine("{0} is not valid email", emailStr);
            //} 


            #endregion


            #region Extention Method for List<string>
            //string[] str = {"ab","abc","abcd","abcde" };
            //List<string> lst = str.ConvertToList();
            //foreach (string s in lst)
            //{
            //    Console.WriteLine(s);
            //} 
            #endregion

            List<Emp> emps = new List<Emp>() {
                new Emp(){No=11, Name="Ganesh",Address="Pune" },
                new Emp(){No=12, Name="Suresh",Address="Mumbai" },
                new Emp(){No=13, Name="Ramesh",Address="Delhi" },
                new Emp(){No=14, Name="Sarvesh",Address="Pune" },
                new Emp(){No=15, Name="Jignesh",Address="Pune" },
                new Emp(){No=16, Name="Rakesh",Address="Mumbai" },
                new Emp(){No=17, Name="Mahesh",Address="Pune" },
                new Emp(){No=18, Name="Nagesh",Address="Delhi" },
                new Emp(){No=19, Name="Aadesh",Address="Mumbai" }
            };
            Console.WriteLine("Enter city");
            //string city = Console.ReadLine();

            #region Normal C# approach to filter emp
            //List<Emp> filteredEmpCollection = new List<Emp>();
            //foreach (Emp emp in emps)
            //{
            //    if (emp.Address.ToLower().StartsWith("m"))
            //    {
            //        filteredEmpCollection.Add(emp);
            //    }
            //    //if(emp.Address.ToLower() == city.ToLower())
            //    //{
            //    //    filteredEmpCollection.Add(emp); 
            //    //}
            //}
            #endregion

            #region LINQ - Lazy Loading of LINQ
            // //LINQ - Language Integrated Query 
            //// IEnumerable<T>
            ////Lazy Loading of LINQ
            //var filteredEmpCollection =  from emp in emps
            //                             where emp.Address.ToLower() == city.ToLower()
            //                             select emp;
            // emps.Add(new Emp() { No = 20, Name = "Nilesh", Address = "Pune" });

            // Console.WriteLine("----------------");
            // foreach (Emp filteredEmp in filteredEmpCollection)
            // {
            //     Console.WriteLine("No = {0}, Name ={1}, Address={2}",filteredEmp.No,
            //         filteredEmp.Name,filteredEmp.Address);
            // } 
            #endregion

            #region ToList() in LINQ
            //var filteredEmpCollection = (from emp in emps
            //                            where emp.Address.ToLower() == city.ToLower()
            //                            select emp).ToList();
            //emps.Add(new Emp() { No = 20, Name = "Nilesh", Address = "Pune" });

            //Console.WriteLine("----------------");
            //foreach (Emp filteredEmp in filteredEmpCollection)
            //{
            //    Console.WriteLine("No = {0}, Name ={1}, Address={2}", filteredEmp.No,
            //        filteredEmp.Name, filteredEmp.Address);
            //} 
            #endregion

            #region emp.Name
            //var filteredEmpCollection = (from emp in emps
            //                             where emp.Address.ToLower() == city.ToLower()
            //                             select emp.Name).ToList();

            //Console.WriteLine("----------------");
            //foreach (string nm in filteredEmpCollection)
            //{
            //    Console.WriteLine("Name ={0}",nm);
            //} 
            #endregion

            #region List<Holder> in LINQ
            //Holder holder = new Holder();
            //holder.Name = emp.Name;
            //holder.Address = emp.Address;

            //var filteredCollection = (from emp in emps
            //                          where emp.Address.ToLower() == city.ToLower()
            //                          select
            //                          new Holder() { Name = emp.Name, Address = emp.Address }).ToList();

            //Console.WriteLine("----------------");
            //foreach (Holder hd in filteredCollection)
            //{

            //    Console.WriteLine("Name ={0}, Address ={1}", hd.Name, hd.Address);
            //}
            #endregion

            #region List<Anonymous Type> in LINQ
            //var filteredCollection = (from emp in emps
            //                          where emp.Address.ToLower() == city.ToLower()
            //                          select
            //                          new { Name = emp.Name, Address = emp.Address }).ToList();

            //Console.WriteLine("----------------");
            //foreach (var hd in filteredCollection)
            //{

            //    Console.WriteLine("Name ={0}, Address ={1}", hd.Name, hd.Address);
            //} 
            #endregion

            #region Order by in LINQ
            //int[] arr = { 1, 4, 2, 3, 7, 9, 6, 5, 8 };

            //var result = (from emp in emps
            //              where emp.Address.ToLower()==city.ToLower()
            //              orderby emp.No ascending
            //              select emp.No).ToList();
            //foreach (int item in result)
            //{
            //    Console.WriteLine(item);
            //} 
            #endregion


            Test test = new Test();
            test.SomeMethod(1);
            test.SomeMethod(2, name: "abcd");//named parameter
            Console.ReadLine();
        }
    }
    public class Test
    {
        public T Add<T>(T x,T y)
        {
            dynamic temp1 = x;
            dynamic temp2 = y;
            dynamic result = temp1 + temp2;
            return temp2+temp1;
        }
        public void SomeMethod(int no, string address="NY", string name = "Hugh Jackman")//optional parameter
        {
            Console.WriteLine("No ={0}, Name={1}, Address={2}",no,name,address);
        }
    }
    public static class MyString 
    {
        public static List<string> ConvertToList(this string[] arr) 
        {
            List<string> lst = new List<string>();
            for (int i = 0; i < arr.Length; i++) 
            {
                lst.Add(arr[i]);
            }
            return lst;
        }

        //Extension methods should be static in static class
        // use this keyword infront of datatype :
        // for which you want to extend the functionality 
        //and you can have other type parameters also in method.
        #region Generic Extension Method 
        //public static bool CheckForValidEmail<T>(this T email, int x, double d)
        //{
        //    Console.WriteLine("{0} {1}", x, d);
        //    bool isValid = false;
        //    //foreach (char ch in email)

        //    //{
        //    //    if (ch == '@')
        //    //    {
        //    //        isValid = true;
        //    //    }
        //    //}
        //    return isValid;
        //} 
        #endregion

        #region Extension Method along with other parameters.
        //public static bool CheckForValidEmail(this string email, int x, double d)
        //{
        //    Console.WriteLine("{0} {1}",x,d);
        //    bool isValid = false;
        //    foreach (char ch in email)

        //    {
        //        if (ch == '@')
        //        {
        //            isValid = true;
        //        }
        //    }
        //    return isValid;
        //} 
        #endregion

        public static bool CheckForValidEmail(this string email)
        {
            bool isValid = false;
            foreach (char ch in email)

            {
                if (ch == '@')
                {
                    isValid = true;
                }
            }
            return isValid;
        }
    }
    public class Demo
    {
        //var can not be used as a method Parameter type or return type.
        public static object GetMeSomething(int choice)
        {
            if(choice == 1)
            {
                return 100;
            }
            else
            {
                return new Emp() { No = 1, Name = "Hugh Jackman", Address = "New York" };
            }
        }
    }
    public class Emp
    {
        private int _No;
        private string _Name;
        private string _Address;

        public string Address
        {
            get { return _Address; }
            set { _Address = value; }
        }


        public string Name
        {
            get { return _Name; }
            set { _Name = value; }
        }


        public int No
        {
            get { return _No; }
            set { _No = value; }
        }

    }

    public class Holder
    {
        public string Name { get; set; }
        public string Address { get; set; }
    }

    public class Customer
    {
        //Compiler is generating private members 
        //along with getters and setters for that member.
        //When the use of this class is to hold data for the temporary basis
        //and we are never writting any validation logic in context with fields ar getters
        // and setters, then we can go for Auto Properties.
        public int CId { get; set; }

        public string CName { get; set; }
        public string CAddress { get; set; }

        //public int Salary { get; }
        public string GetCustomerDetails()
        {
            return string.Format("{0} {1} {2}", CId, CName, CAddress);
        }


    }
}
