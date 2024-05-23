
using System.Reflection;
using MyCustomAttribute;

namespace _19Reflection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Assembly assembly = Assembly.LoadFrom(@"D:\IETCDAC\CDACDemos\MyMath\bin\Debug\net6.0\MyMath.dll");
            Type [] allTypes = assembly.GetTypes();
            for (int i = 0; i < allTypes.Length; i++) 
            {
                Type type = allTypes[i];
                object DynamicallyCreatedObject = assembly.CreateInstance(type.FullName);
                MethodInfo [] allMethods = type.GetMethods();
                for (int j = 0; j < allMethods.Length; j++)
                {
                    MethodInfo method = allMethods[j];
                    Console.WriteLine("For {0}:", method.Name);
                    ParameterInfo[] parameters = method.GetParameters();
                    object[] inputValues = new object[parameters.Length];
                    for (int k = 0; k < parameters.Length; k++)
                    {
                        ParameterInfo para = parameters[k];
                        Console.WriteLine("Enter value for parameter {0} of Type {1}",
                                                    para.Name,para.ParameterType.ToString());
                        string ?inputs = Console.ReadLine();
                        inputValues[k] = Convert.ChangeType(inputs, para.ParameterType);
                    }

                    object ?result = type.InvokeMember(method.Name,
                                                     BindingFlags.Public |
                                                     BindingFlags.Instance |
                                                     BindingFlags.InvokeMethod,
                                                     null,
                                                     DynamicallyCreatedObject,
                                                     inputValues);
                    // new object[] { 10, 20 });
                    Console.WriteLine("Result of {0} is {1}", method.Name, result.ToString());
                }
                        
            }
        }
    }
}
