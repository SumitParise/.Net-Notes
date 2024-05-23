
//using System.Reflection;
//using MyCustomAttribute;

//namespace _19Reflection
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            Assembly assembly = Assembly.LoadFrom(@"D:\IETCDAC\CDACDemos\MyMath\bin\Debug\net6.0\MyMath.dll");
//            Type [] allTypes = assembly.GetTypes();
//            for (int i = 0; i < allTypes.Length; i++) 
//            {
//                Type type = allTypes[i];
//                Console.WriteLine(type.FullName);
//                Attribute [] allAttrinutes = type.GetCustomAttributes().ToArray();
//                for (int j = 0; j < allAttrinutes.Length; j++) 
//                {
//                    Attribute attribute = allAttrinutes[j];
//                    if(attribute is SerializableAttribute)
//                    {
//                        Console.WriteLine("{0} is marked as Serializable.",type.FullName);
//                    }
//                    if(attribute is Company)
//                    {
//                        Company company = attribute as Company;
//                        Console.WriteLine("{0} is belong to {1} company", type.FullName,company.CompanyName);
//                    }
//                }
//            }
//        }
//    }
//}
