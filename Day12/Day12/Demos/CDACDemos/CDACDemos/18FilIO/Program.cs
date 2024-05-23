using System.Collections;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization.Formatters.Soap;
using System.Xml.Linq;
using System.Xml.Serialization;


namespace _18FilIO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string filePath = @"D:\IETCDAC\MyData.txt";

            #region StreamWriter 
            //FileStream fs = new FileStream(filePath,
            //                            FileMode.OpenOrCreate | FileMode.Append,
            //                            FileAccess.Write);
            //StreamWriter write = new StreamWriter(fs);
            //Console.WriteLine("Enter thye text");
            //string txt = Console.ReadLine();
            //write.WriteLine(txt);
            //write.AutoFlush = true;
            //write.Close();
            //fs.Close();
            //Console.WriteLine("Done"); 
            #endregion

            #region StteamReader
            //FileStream fs=new FileStream(filePath,FileMode.Open,FileAccess.Read);
            //StreamReader sr =new StreamReader(fs);
            //string opData= sr.ReadToEnd();
            //Console.WriteLine(opData); 
            #endregion

            #region Persist Object in txt using StreamWrite Class
            //string filePath1 = @"D:\IETCDAC\MyData1.txt";
            //FileStream fs = null;
            //if (File.Exists(filePath))
            //{
            //    fs = new FileStream(filePath1, FileMode.Append, FileAccess.Write);
            //}
            //else
            //{
            //    fs = new FileStream(filePath1, FileMode.CreateNew, FileAccess.Write);
            //}
            //Customer customer = new Customer();
            //Console.WriteLine("Enter ID :");
            //customer.Id = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Enter name ");
            //customer.CName = Console.ReadLine();
            //Console.WriteLine("Enter address");
            //customer.CAddress = Console.ReadLine(); 


            //StreamWriter write = new StreamWriter(fs);
            //write.Write(customer);
            //write.AutoFlush = true;
            //write.Close();
            //fs.Close();
            //Console.WriteLine("Done"); 
            #endregion

            #region Serialize - Binary Formatter
            //string filePath1 = @"D:\IETCDAC\MyData5.txt";
            //FileStream fs = null;
            //if (File.Exists(filePath1))
            //{
            //    fs = new FileStream(filePath1, FileMode.Append, FileAccess.Write);
            //}
            //else
            //{
            //    fs = new FileStream(filePath1, FileMode.CreateNew, FileAccess.Write);
            //}
            //ArrayList arr =new ArrayList() {
            //new Emp(){EName="abc",Salary=20000},
            //new Customer(){Id=1,CName="pqr",CAddress="pune"}
            //};
            //BinaryFormatter bf = new BinaryFormatter();
            //bf.Serialize(fs, arr);

            //if (File.Exists(filePath1))
            //{
            //    fs = new FileStream(filePath1, FileMode.Open, FileAccess.Read);
            //}
            //ArrayList lst = bf.Deserialize(fs) as ArrayList;
            //foreach (var item in lst)
            //{

            //}
            //fs.Close();
            //Console.WriteLine("done");
            //Customer customer = new Customer();
            //Console.WriteLine("Enter ID :");
            //customer.Id = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Enter name ");
            //customer.CName = Console.ReadLine();
            //Console.WriteLine("Enter address");
            //customer.CAddress = Console.ReadLine();

            //Emp emp = new Emp();
            //emp.Salary = 20000;
            //emp.EName = "PErsy Jackson";

            ////Serializtion :Converting complex Object data into some other form*
            ////so that we can transfer it over the network or we can persist it
            ////on hard drive.
            //BinaryFormatter bf = new BinaryFormatter();
            //bf.Serialize(fs, emp);
            //fs.Close();
            //Console.WriteLine("Done");
            #endregion

            #region DeSerialize - BinaryFormatter
            //string filePath1 = @"D:\IETCDAC\MyData1.txt";
            //FileStream fs = null;
            //if (File.Exists(filePath))
            //{
            //    fs = new FileStream(filePath1, FileMode.Open, FileAccess.Read);
            //}

            //Serializtion: Converting complex Object data into some other form*
            //so that we can transfer it over the network or we can persist it
            //on hard drive.

            //    BinaryFormatter bf = new BinaryFormatter();
            //object classObj = bf.Deserialize(fs);

            //Customer customerObj = bf.Deserialize(fs) as Customer;
            //Console.WriteLine(customerObj.GetCustomerDetails());
            #endregion

            #region Non Serializable member of a class
            //string filePath1 = @"D:\IETCDAC\MyData2.txt";
            //FileStream fs = null;
            //if (File.Exists(filePath))
            //{
            //    fs = new FileStream(filePath1, FileMode.Append, FileAccess.Write);
            //}
            //else
            //{
            //    fs = new FileStream(filePath1, FileMode.CreateNew, FileAccess.Write);
            //}
            //Customer customer = new Customer();
            //Console.WriteLine("Enter ID :");
            //customer.Id = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Enter name ");
            //customer.CName = Console.ReadLine();
            //Console.WriteLine("Enter address");
            //customer.CAddress = Console.ReadLine();

            //////Serializtion :Converting complex Object data into some other form*
            //////so that we can transfer it over the network or we can persist it
            //////on hard drive.
            //BinaryFormatter bf = new BinaryFormatter();
            //bf.Serialize(fs, customer);
            //fs.Close();
            //Console.WriteLine("Done"); 
            #endregion


            #region XmlSerializer - Serialize()
            //string filePath1 = @"D:\IETCDAC\MyData3.xml";
            //FileStream fs = null;
            //if (File.Exists(filePath))
            //{
            //    fs = new FileStream(filePath1, FileMode.Append, FileAccess.Write);
            //}
            //else
            //{
            //    fs = new FileStream(filePath1, FileMode.CreateNew, FileAccess.Write);
            //}
            //Customer customer = new Customer();
            //Console.WriteLine("Enter ID :");
            //customer.Id = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Enter name ");
            //customer.CName = Console.ReadLine();
            //Console.WriteLine("Enter address");
            //customer.CAddress = Console.ReadLine();

            ////Type type = customer.GetType();
            ////XmlSerializer xmlSerializer = new XmlSerializer(type);
            //XmlSerializer xmlSerializer = new XmlSerializer(typeof(Customer));
            //xmlSerializer.Serialize(fs, customer);

            //fs.Close();
            //Console.WriteLine("Done"); 
            #endregion

            #region XMlSerializer - DeSerialize()
            //string filePath1 = @"D:\IETCDAC\MyData3.xml";
            //FileStream fs = null;
            //if (File.Exists(filePath))
            //{
            //    fs = new FileStream(filePath1, FileMode.Open, FileAccess.Read);
            //}
            //Customer customer = new Customer();

            ////Type type = customer.GetType();
            ////XmlSerializer xmlSerializer = new XmlSerializer(type);
            //XmlSerializer xmlSerializer = new XmlSerializer(typeof(Customer));
            //Customer refOfCustomerObj = xmlSerializer.Deserialize(fs) as Customer;
            //Console.WriteLine(refOfCustomerObj.GetCustomerDetails()); 
            #endregion

            #region Soap Formatter - Serialize ()
            //string filePath1 = @"D:\IETCDAC\MyData4.txt";
            //FileStream fs = null;
            //if (File.Exists(filePath))
            //{
            //    fs = new FileStream(filePath1, FileMode.Append, FileAccess.Write);
            //}
            //else
            //{
            //    fs = new FileStream(filePath1, FileMode.CreateNew, FileAccess.Write);
            //}
            //Customer customer = new Customer();
            //Console.WriteLine("Enter ID :");
            //customer.Id = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Enter name ");
            //customer.CName = Console.ReadLine();
            //Console.WriteLine("Enter address");
            //customer.CAddress = Console.ReadLine();

            //SoapFormatter sf = new SoapFormatter();
            //sf.Serialize(fs,customer);

            //fs.Close();
            //Console.WriteLine("Done"); 

            #endregion

            #region SoapFormatter - Deserialize() 
            //string filePath1 = @"D:\IETCDAC\MyData4.txt";
            //FileStream fs = null;
            //if (File.Exists(filePath))
            //{
            //    fs = new FileStream(filePath1, FileMode.Open, FileAccess.Read);
            //}
            //Customer customer = new Customer();
            //SoapFormatter sf = new SoapFormatter();
            //Customer refToCustomerObj = sf.Deserialize(fs) as Customer;
            //Console.WriteLine(refToCustomerObj.GetCustomerDetails());

            //fs.Close();
            //Console.WriteLine("Done"); 
            #endregion

        }
    }
    [Serializable]
    public class Customer
    {
        private int _CId;
        private string _CName;
        private string _CAddress;

       // [NonSerialized]
        private string _Password = "123456";

        public string Password
        {
            get { return _Password = "123456"; }
            set { _Password = value; }
        }


        public string CAddress
        {
            get { return _CAddress; }
            set { _CAddress = value; }
        }


        public string CName
        {
            get { return _CName; }
            set { _CName = value; }
        }


        public int Id
        {
            get { return _CId; }
            set { _CId = value; }
        }
        public string GetCustomerDetails()
        {
            string str = "CID "+_CId + "CName "+ _CName+ " CAddress " + _CAddress + " PAssword "+_Password;
            return str;
        }
    }
    [Serializable]
    public class Emp
    {
        private int _Sal;
        private string _EName;

        public string EName
        {
            get { return _EName; }
            set { _EName = value; }
        }


        public int Salary
        {
            get { return _Sal; }
            set { _Sal = value; }
        }


    }
}

// Logger class - Log method.. 
//Write Log int muLog.txt file 
