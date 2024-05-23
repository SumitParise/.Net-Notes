using System.Collections;

namespace _22CSharpFeatures
{
    public delegate bool MyDelegate(int x);
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Partial Class 
            //CMath cmath = new CMath();
            //Console.WriteLine(cmath.Add(10, 20));
            //Console.WriteLine(cmath.Sub(30,5)); 
            #endregion

            #region Nullable Types
            //int ? i = null;

            //Nullable<int> Age = 70; 

            //if(Age.HasValue)
            //{
            //    Console.WriteLine("Age = {0}", Age);
            //}
            //else
            //{
            //    Console.WriteLine("Age can not be null !!");
            //} 
            #endregion

            #region Normal call using delegate
            //MyDelegate del = new MyDelegate(Check);

            //Console.WriteLine("Enter int value");
            //int i = Convert.ToInt32(Console.ReadLine());

            //bool result = del(i);

            //if(result)
            //    Console.WriteLine("{0} is greater than 10",i);
            //else
            //    Console.WriteLine("{0} is less than 10",i); 
            #endregion

            #region Anonymous Methods 
            //MyDelegate del = delegate(int i)
            //                         {
            //                             return i > 10;
            //                         };

            //Console.WriteLine("Enter int value");
            //int i = Convert.ToInt32(Console.ReadLine());

            //bool result = del(i);

            //if (result)
            //    Console.WriteLine("{0} is greater than 10", i);
            //else
            //    Console.WriteLine("{0} is less than 10", i); 
            #endregion

            #region Lambada Expression 
            ////MyDelegate del = (i) =>
            ////                        {
            ////                            return i == 10;
            ////                        };

            //MyDelegate del = (i) => { return i == 10;};
            //bool result = del(100);
            //Console.WriteLine(result); 

            #endregion

            #region Object Initializer
            //int[] arr = new int[3];
            //arr[0] = 100;
            //arr[1] = 200;
            //arr[2] = 300;

            #region Object Initializer
            ////declaration and initialization of object at same time.
            ////Object Initializer
            //int[] arr2 = new int[] { 100, 200, 300, 400};
            //for (int i = 0; i < arr2.Length; i++) 
            //{
            //    Console.WriteLine(arr2[i]);
            //}

            //Emp emp =new Emp() {Id =14, Name="Hugh Jackman" , Address= "New York"};

            //Emp emp1 = new Emp() { Id = 14, Address = "New York" };

            //ArrayList arrayList = new ArrayList() {emp, "abc" , 100, 23.33,emp1}; 
            #endregion

            #endregion

            #region Iterator
            ////ArrayList arr1 =new ArrayList();
            ////foreach (int element in arr1)
            ////{ 

            ////}
            ////object[] objarr= new object[Count];

            //Week week = new Week();
            //foreach (string day in week)
            //{
            //    Console.WriteLine(day);
            //} 
            #endregion

        }
        public static bool Check(int i)
        {
            return i > 10;
        }
    }

    public class Week : IEnumerable
    {
        private string[] Days = new string[] 
                                            {
                                                "Monday",
                                                "Tuesday",
                                                "Wednesday",
                                                "Thrusday",
                                                "Friday"
                                            };

        public IEnumerator GetEnumerator()
        {
            for (int i = 0; i < Days.Length; i++) 
            {
                yield return Days[i];
            }
        }
    }
    public class Emp
    {
        private int _ID;
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


        public int Id
        {
            get { return _ID; }
            set { _ID = value; }
        }

    }
}
