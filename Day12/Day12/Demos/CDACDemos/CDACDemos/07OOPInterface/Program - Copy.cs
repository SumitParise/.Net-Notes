//namespace _07OOPInterface
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            string op = null;
//            do
//            {
//                Console.WriteLine("Enter your DB Choice :");
//                Console.WriteLine("1.Sql Server, 2.Oracle Server");
//                int dbChoice = Convert.ToInt32(Console.ReadLine());
//                switch (dbChoice)
//                {
//                    case 1:
//                        SQLServer sqlObj = new SQLServer();
//                        Console.WriteLine("Enter your DB Operation Choice:");
//                        Console.WriteLine("1.Insert, 2. Update,3.Delete");
//                        int opChoice = Convert.ToInt32(Console.ReadLine());
//                        switch (opChoice)
//                        {
//                            case 1:
//                                sqlObj.Insert();
//                                break;
//                            case 2:
//                                sqlObj.Update();
//                                break;
//                            case 3:
//                                sqlObj.Delete();
//                                break;
//                            default:
//                                break;
//                        }
//                        break;
//                    case 2:
//                        OracleServer oracleObj = new OracleServer();
//                        Console.WriteLine("Enter your DB Operation Choice:");
//                        Console.WriteLine("1.Insert, 2. Update,3.Delete");
//                        int opChoice1 = Convert.ToInt32(Console.ReadLine());
//                        switch (opChoice1)
//                        {
//                            case 1:
//                                oracleObj.Insert();
//                                break;
//                            case 2:
//                                oracleObj.Update();
//                                break;
//                            case 3:
//                                oracleObj.Delete();
//                                break;
//                            default:
//                                break;
//                        }
//                        break;
//                    default:
//                        Console.WriteLine("Invalid Choice");
//                        break;
//                }
//                Console.WriteLine("Do you want to continue? y/n");
//                op = Console.ReadLine();
//            } while (op != "n");
//        }
        
       
//    }
//    public interface IDatabase
//    {
//        void Insert();
//        void Update();
//        void Delete();
//    }
//    public class SQLServer:IDatabase
//    {
//        public void Insert()
//        {
//            Console.WriteLine("Data Inserted into SQL Server Successfully!!");
//        }
//        public void Update()
//        {
//            Console.WriteLine("Data Updated into SQL Server Successfully!!");
//        }
//        public void Delete()
//        {
//            Console.WriteLine("Data Delete into SQL Server Successfully!!");
//        }
//    }
//    public class OracleServer:IDatabase
//    {
//        public void Insert()
//        {
//            Console.WriteLine("Data Inserted into Oracle Server Successfully!!");
//        }
//        public void Update()
//        {
//            Console.WriteLine("Data Updated into Oracle Server Successfully!!");
//        }
//        public void Delete()
//        {
//            Console.WriteLine("Data Delete into Oracle Server Successfully!!");
//        }
//    }
//    }
