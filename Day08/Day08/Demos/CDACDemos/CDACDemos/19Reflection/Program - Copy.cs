
//using System.Reflection;

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
//                MethodInfo[] methods = type.GetMethods();
//                string methodSignature = null;
//                for (int j = 0; j < methods.Length; j++)
//                {
//                    MethodInfo method = methods[j];
//                   // Console.WriteLine(method.Name);
//                   methodSignature = methodSignature + method.ReturnType.ToString() +" "+ 
//                                                method.Name+" "+"( ";
//                    ParameterInfo[] allParams = method.GetParameters();
//                    for (int k = 0; k < allParams.Length; k++)
//                    {
//                        ParameterInfo para = allParams[k];
//                        methodSignature = methodSignature + para.ParameterType.ToString()+" "
//                                               + para.Name + ",";
//                    }
//                    methodSignature = methodSignature.TrimEnd(',');
//                    methodSignature = methodSignature + " )\n";
//                }
//                Console.WriteLine(methodSignature);
//            }
//        }
//    }
//}
