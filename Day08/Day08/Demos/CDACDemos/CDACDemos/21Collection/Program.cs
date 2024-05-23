using System.Collections;
using System.Runtime.Serialization.Formatters.Binary;

namespace _21Collection
{
    public delegate T MyDelegate<T>(T x, T y);
    internal class Program
    {
        static void Main(string[] args)
        {
            #region int [] , foreach loop
            //int[] arr = new int[3];
            //arr[0] = 100;
            //arr[1] = 200;
            //arr[2] = 300;

            //foreach (int item in arr)
            //{
            //    Console.WriteLine(item);
            //}

            //for (int i = 0; i < arr.Length; i++)
            //{
            //    Console.WriteLine(arr[i]);
            //} 
            #endregion


            #region Array.Sort()
            //int[] arr = new int[8];
            ////Array initialization by accepting user inputs
            //for (int i = 0; i < arr.Length; i++) 
            //{
            //    Console.WriteLine("Enter int value");
            //    int val = Convert.ToInt32(Console.ReadLine());
            //    arr[i] = val;
            //}
            ////Sort Array
            //Array.Sort(arr);
            //Console.WriteLine("Sorted Array :");
            //foreach (int item in arr)
            //{
            //    Console.WriteLine(item);
            //} 
            #endregion

            #region string [] , input from user
            //string[] strArr = new string[3];
            //for (int i = 0; i < strArr.Length; i++) 
            //{
            //    Console.WriteLine("Enter value :");
            //    strArr[i] = Console.ReadLine();
            //}
            //Console.WriteLine("You Entered below values:");
            //foreach (string str in strArr) 
            //{
            //    Console.WriteLine(str);
            //} 
            #endregion

            #region Emp[]  with user inputs and searching randon records.
            // Emp[] emps = new Emp[3];
            // for (int i = 0; i < emps.Length; i++)
            // {
            //     Emp emp = new Emp();
            //     Console.WriteLine("Enter Id :");
            //     emp.Id = Convert.ToInt32(Console.ReadLine());
            //     Console.WriteLine("Enter Name :");
            //     emp.Name = Console.ReadLine();
            //     Console.WriteLine("Enter Address :");
            //     emp.Address = Console.ReadLine();
            //     emps[i] = emp;
            // }
            // Console.WriteLine("Enter EID for the Employee to be Searched");
            // int IdToBeSearched = Convert.ToInt32(Console.ReadLine());
            // Emp empToBeSearched = null;
            // bool isFound = false;
            // foreach (Emp emp in emps)
            // {
            //     if(emp.Id == IdToBeSearched)
            //     {
            //         empToBeSearched = emp;
            //         isFound = true;
            //         break;
            //     }
            //     //Console.WriteLine(emp.GetEmpDetails());
            // }
            //if(isFound)
            // {
            //     Console.WriteLine(empToBeSearched.GetEmpDetails());
            // }
            //else
            // {
            //     Console.WriteLine("No records Found!");
            // }
            #endregion

            Emp emp1 =new Emp();
            emp1.Id = 1;
            emp1.Name = "Nikhil";
            emp1.Address = "Baramati";

            Emp emp2 = new Emp();
            emp2.Id = 2;
            emp2.Name = "Sagar";
            emp2.Address = "Beed";

            Emp emp3 = new Emp();
            emp3.Id = 3;
            emp3.Name = "Siddhi";
            emp3.Address = "Pune";

            Book book1 = new Book();
            book1.Auther = "J.K. Rowling";
            book1.BookName = "Harry Potter: Order of Pheonix";

            #region Object [] of fixed size
            //object[] objArr = new object[6];
            //objArr[0] = 100;//Boxing
            //objArr[1] = "some nonsense value";
            //objArr[2] = emp1;
            //objArr[3] = 23.33;
            //objArr[4] = emp2;
            //objArr[5] = book1;
            //foreach (object obj in objArr)
            //{
            //    if (obj is int)
            //    {
            //        int j = Convert.ToInt32(obj);
            //        Console.WriteLine("Int value = {0}", j);
            //    }
            //    if (obj is double)
            //    {
            //        double d = Convert.ToDouble(obj);
            //        Console.WriteLine("Double value = {0}", d);
            //    }
            //    if(obj is string)
            //    {
            //        string s = Convert.ToString(obj);
            //        Console.WriteLine("String value = {0}",s);
            //    }
            //    if (obj is Emp)
            //    {
            //        Emp emp = obj as Emp;
            //        Console.WriteLine(emp.GetEmpDetails());
            //    }
            //    if (obj is Book)
            //    {
            //        Book book = obj as Book;
            //        Console.WriteLine("Auther = {0}, Book Name ={1}", book.Auther, book.BookName);
            //    }
            //}
            #endregion

            #region ArrayList with int type elements 
            //ArrayList - Its a .NET collection.
            //It creates object Type- growable collection

            ArrayList arr = new ArrayList();
            arr.Add(100);
            arr.Add(200);
            arr.Add(300);
            //while (true)
            //{
            //    Console.WriteLine("enter value of type int");
            //    int inputvalue = Convert.ToInt32(Console.ReadLine());
            //    arr.Add(inputvalue);
            //    Console.WriteLine("do you want to continue? y/n");
            //    string choice = Console.ReadLine();
            //    if (choice == "n")
            //    {
            //        break;
            //    }
            //}

            foreach (object obj in arr)
            {
                if (obj != null)
                {
                    // console.writeline(obj);//its not recommended
                    if (obj is int)
                    {
                        int j = (int)obj;
                        Console.WriteLine(j);
                    }
                }
            }
            #endregion

            #region Assignment - to persist multip[le type object data in txt using serializationand deserialization 
            //ArrayList arrForTxt = new ArrayList();
            //arrForTxt.Add(book1);
            //arrForTxt.Add(emp1);

            //BinaryFormatter bf =new BinaryFormatter();
            //bf.Serialize(fs,emp1)
            //bf.Serialize(fs,bool1)
            //Emp emp = bf.Deserialize(fs) as Emp;
            //bf.Serialize (fs, arrForTxt);
            //ArrayList allRecordsFromTxt = bf.Deserialize(fs) as ArrayList;
            //foreach (object obj in allRecordsFromTxt)
            //{
            //    if(obj is Emp)
            //    {

            //    }
            //    if(obj is Book)
            //    {

            //    }
            //} 
            #endregion

            #region Nested ArrayList and collection with random Types
            //ArrayList arr =new ArrayList();
            //arr.Add(book1);
            //arr.Add(23.33);
            //arr.Add("something something");
            //arr.Add(emp1);
            //arr.Add(1000);
            //arr.Add(emp2);
            //ArrayList arr1=new ArrayList();
            //arr.Add(arr1);

            //foreach (object obj in arr) 
            //{
            //    if (obj is int)
            //    {
            //        int j = Convert.ToInt32(obj);
            //        Console.WriteLine("Int value = {0}", j);
            //    }
            //    if (obj is double)
            //    {
            //        double d = Convert.ToDouble(obj);
            //        Console.WriteLine("Double value = {0}", d);
            //    }
            //    if (obj is string)
            //    {
            //        string s = Convert.ToString(obj);
            //        Console.WriteLine("String value = {0}", s);
            //    }
            //    if (obj is Emp)
            //    {
            //        Emp emp = obj as Emp;
            //        Console.WriteLine(emp.GetEmpDetails());
            //    }
            //    if (obj is Book)
            //    {
            //        Book book = obj as Book;
            //        Console.WriteLine("Auther = {0}, Book Name ={1}", book.Auther, book.BookName);
            //    }
            //    if(obj is ArrayList)
            //    {
            //        ArrayList reToarr1 = obj as ArrayList;
            //        foreach (object obj1 in reToarr1)
            //        {
            //            //if()
            //        }
            //    }
            //} 
            #endregion

            #region Arraylist : Assignment 2
            //ArrayList arr2 =new ArrayList();
            //arr2.Add(emp1);
            //arr2.Add(emp2);
            ////add records dynamically .. 
            //Console.WriteLine("Enter Id to be searched ..");
            ////write code - to find and display employee 
            #endregion


            #region Hashtable

            #region Hashtable with random types
            //Hashtable ht = new Hashtable();
            //ht.Add(1, 100);
            //ht.Add("abc", "something");
            //ht.Add("IT", emp1);
            //ht.Add("fictional", book1);
            //foreach (object key in ht.Keys)
            //{
            //    Console.WriteLine("Key = {0}, Value ={1}", key, ht[key]);
            //    if (ht[key] is Emp)
            //    {
            //        Emp emp = ht[key] as Emp;
            //        Console.WriteLine(emp.GetEmpDetails());
            //    }
            //} 
            #endregion

            #region Hashtable - random search
            //Hashtable ht = new Hashtable();
            //ht.Add(1, emp1);
            //ht.Add(2, emp2);
            //ht.Add(3, emp3);
            //Console.WriteLine("Enter id to be searched");
            //int id = Convert.ToInt32(Console.ReadLine());

            //foreach (object key in ht.Keys)
            //{
            //    Emp emp = ht[key] as Emp;
            //    if(emp.Id == id)
            //    {
            //        Console.WriteLine(emp.GetEmpDetails());
            //    }
            //    //if(ht.ContainsKey())
            //    //{
            //    //    Console.WriteLine("record found");
            //    //}
            //    //if (ht[key] is Emp)
            //    //{
            //    //    Emp emp = ht[key] as Emp;
            //    //    Console.WriteLine(emp.GetEmpDetails());
            //    //}
            //} 
            #endregion



            #endregion

            #region stack and Queue

            //Stack stack = new Stack();
            //stack.Push(10);
            //stack.Push(20);
            //stack.Push(30);
            //stack.Push(40);
            //foreach (object obj in stack)
            //{
            //    //int val = (int)stack.Pop();
            //    int val = (int)obj;
            //    Console.WriteLine(val);
            //}
            //Queue queue = new Queue();
            //queue.Enqueue(10);
            //queue.Dequeue(); 
            #endregion

            #region Generic Class

            //CMath<int> cmath = new CMath<int>();
            //int x = 10, y = 20;
            //Console.WriteLine("Before Swap x ={0} , y ={1}",x,y);
            //cmath.Swap(ref x,ref y);
            //Console.WriteLine("After Swap x ={0} , y ={1}",x,y);

            //CMath<string> cmath1 = new CMath<string>();
            //string str1 = "abc", str2 = "pqr";
            //Console.WriteLine("Before Swap x ={0} , y ={1}", str1, str2);
            //cmath1.Swap(ref str1, ref str2);
            //Console.WriteLine("After Swap x ={0} , y ={1}", str1, str2);

            //cmath1.SayHi();
            //int result =cmath1.Add(10, 20);
            //Console.WriteLine(result);

            #endregion

            #region Non Generic class with Generic and non generic Methods
            // CMath cmath = new CMath();

            // int result = cmath.Add(100, 200);
            // Console.WriteLine("Add result ={0}", result);

            // string str1 = "abc", str2 = "pqr";
            //// int str1 = 10, str2 = 20;

            // Console.WriteLine("Before Swap str1 ={0} , str2 ={1}", str1, str2);

            // cmath.Swap<string>(ref str1, ref str2);

            // Console.WriteLine("After Swap str1 ={0} , str2 ={1}", str1, str2);

            // cmath.SayHi(); 
            #endregion

            #region Generic MEthod with multiple Generic Parameters
            //MyClass obj =new MyClass();
            //bool result= obj.Fun1<int, bool, string>(10, true, "something something");
            //Console.WriteLine(result); 
            #endregion

            #region Generic Collection  : List<int>
            //List<int> lstIntegers = new List<int>();
            //lstIntegers.Add(100);
            //lstIntegers.Add(200);
            //lstIntegers.Add(300);

            //foreach (int i in lstIntegers)
            //{
            //    Console.WriteLine(i);
            //} 
            #endregion

            #region Generic Collection  : List<Emp>
            //List<Emp> emps = new List<Emp>();
            //emps.Add(emp1);
            //emps.Add(emp2);
            //emps.Add(emp3);
            //foreach (Emp emp in emps)
            //{
            //    Console.WriteLine(emp.GetEmpDetails());
            //} 
            #endregion

            #region Dictionary<>
            //Dictionary<int,Emp> dt=new Dictionary<int, Emp>();
            //  dt.Add(1, emp1);
            //  dt.Add(2, emp2);
            //      dt.Add(3, emp3);
            //  foreach (int  key in dt.Keys)
            //  {
            //      Emp emp = dt[key];
            //      Console.Write("Key = {0}",key);
            //      Console.WriteLine(" -- Value {0}",emp.GetEmpDetails());
            //  } 
            #endregion


            Console.ReadLine();
        }
    }
    public class MyClass
    {
        public Q Fun1<P,Q,R>(P para1, Q para2 , R para3)
        {
            //if( para1.GetType() == para3.GetType())
            return para2;
        }
    }
    public class CMath //Non Generic Class
    {
        public void SayHi()//Non Generic Method
        {
            Console.WriteLine("Hi there !");
        }
        public int Add(int x, int y) //Non Generic Method
        {
            return x + y;
        }
        public void Swap<T>(ref T x, ref T y)//Generic Method
        {
            T temp;
            temp = x;
            x = y;
            y = temp;
        }
    }


    #region CMath<T> with Generic and Non Generic methods
    //public class CMath<T> //Generic Class
    //{
    //    public void SayHi()
    //    {
    //        Console.WriteLine("Hi there !");
    //    }
    //    public int Add(int x, int y)
    //    {
    //        return x + y;
    //    }
    //    public void Swap(ref T x,ref T y)//Generic Method
    //    {
    //        T temp;
    //        temp = x;
    //        x = y;
    //        y=temp;
    //    }
    //    //public void Swap(string x, string y)
    //    //{
    //    //    string temp;
    //    //    temp = x;
    //    //    x = y;
    //    //    y = temp;
    //    //}
    //} 
    #endregion
    public class Book
    {
        private string _Auther;
        private string _BookName;

        public string BookName
        {
            get { return _BookName; }
            set { _BookName = value; }
        }


        public string Auther
        {
            get { return _Auther; }
            set { _Auther = value; }
        }

    }
    public class Emp
    {
        private int _EId;
        private string _EName;
        private string _EAddress;

        public string Address
        {
            get { return _EAddress; }
            set { _EAddress = value; }
        }


        public string Name
        {
            get { return _EName; }
            set { _EName = value; }
        }


        public int Id
        {
            get { return _EId; }
            set { _EId = value; }
        }

        public string GetEmpDetails()
        {
            return string.Format("Id ={0}, Name ={1}, Address ={2}", _EId, _EName, _EAddress);
        }

    }
}
