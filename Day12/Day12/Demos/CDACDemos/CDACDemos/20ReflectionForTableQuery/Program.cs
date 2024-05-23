using MyDBAttributes;
using System.Reflection;

namespace _20ReflectionForTableQuery
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Assembly assembly = Assembly.LoadFrom(@"D:\IETCDAC\CDACDemos\Employee\bin\Debug\net6.0\Employee.dll");
            Type [] types = assembly.GetTypes();
            string query = "CREATE TABLE ";
            for (int i = 0; i < types.Length; i++)
            {
                if (!(types[i].FullName.Contains("Microsoft")) && !(types[i].FullName.Contains("System"))) 
                {
                   // Console.WriteLine(types[i].FullName);
                    Type type =  types[i];
                    Attribute[] allAttributes = type.GetCustomAttributes().ToArray();
                   
                    for (int j = 0; j< allAttributes.Length;j++)
                    {
                        Attribute attribute = allAttributes[j];
                        if( attribute is MyTable)
                        {
                            MyTable tableName = attribute as MyTable;
                            query = query + tableName.TableName +" ( ";
                        }
                        // Console.WriteLine(attribute.GetType().ToString());
                        
                    }

                    PropertyInfo[] allProperties = type.GetProperties();
                    for (int k = 0; k < allProperties.Length; k++)
                    {
                        PropertyInfo property = allProperties[k];
                        Attribute[] allPropAttributes = property.GetCustomAttributes().ToArray();
                        for (int p = 0; p < allPropAttributes.Length; p++)
                        {
                            Attribute attr = allPropAttributes[p];
                            if (attr is Columns)
                            {
                                Columns col = (Columns)attr;
                                query = query + col.ColumnName + " " + col.ColumnType + ", ";
                            }
                        }
                    }
                    query = query.TrimEnd(',');
                    query = query + " )";
                    Console.WriteLine(query);
                }
            }
        }
    }
}
