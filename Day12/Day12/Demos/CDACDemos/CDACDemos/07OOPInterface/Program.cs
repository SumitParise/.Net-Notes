namespace _07OOPInterface
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string op = null;
            do
            {
                Console.WriteLine("Enter your DB Choice :");
                Console.WriteLine("1.Sql Server, 2.Oracle Server 3. MySQL Server");
                int dbChoice = Convert.ToInt32(Console.ReadLine());
                DataBaseFactory dataBaseFactory = new DataBaseFactory();
                IDatabase db = dataBaseFactory.GetDataBase(dbChoice);
                
                Console.WriteLine("Enter your DB Operation Choice:");
                Console.WriteLine("1.Insert, 2. Update,3.Delete");
                int opChoice1 = Convert.ToInt32(Console.ReadLine());
                switch (opChoice1)
                {
                      case 1:
                            db.Insert();
                                break;
                      case 2:
                            db.Update();
                                break;
                      case 3:
                           db.Delete();
                                break;
                            default:
                                break;
                        }
                Console.WriteLine("Do you want to continue? y/n");
                op = Console.ReadLine();
            } while (op != "n");
        }
        
       
    }
    public interface IDatabase
    {
        void Insert();
        void Update();
        void Delete();
    }
    //Factory Pattern
    public class DataBaseFactory //Factory Classes
    {
        public IDatabase GetDataBase(int dbChoice)//Factory Methods
        {
            if(dbChoice == 1)
            {
                return new SQLServer();
            }
            else if(dbChoice == 2)
            {
                return new OracleServer();
            }
            else if(dbChoice==3)
            {
                MySQLServer mysqlObj = new MySQLServer();
                return mysqlObj;
            }
            else
            {
                return null;
            }
        }
    }
    public class SQLServer:IDatabase
    {
        public void Insert()
        {
            Console.WriteLine("Data Inserted into SQL Server Successfully!!");
        }
        public void Update()
        {
            Console.WriteLine("Data Updated into SQL Server Successfully!!");
        }
        public void Delete()
        {
            Console.WriteLine("Data Delete into SQL Server Successfully!!");
        }
    }
    public class OracleServer:IDatabase
    {
        public void Insert()
        {
            Console.WriteLine("Data Inserted into Oracle Server Successfully!!");
        }
        public void Update()
        {
            Console.WriteLine("Data Updated into Oracle Server Successfully!!");
        }
        public void Delete()
        {
            Console.WriteLine("Data Delete into Oracle Server Successfully!!");
        }
    }
    public class MySQLServer : IDatabase
    {
        public void Insert()
        {
            Console.WriteLine("Data Inserted into MySQL Server Successfully!!");

        }
        public void Update()
        {
            Console.WriteLine("Data Updated into MySQL Server Successfully!!");
        }
        public void Delete()
        {
            Console.WriteLine("Data Delete into MySQL Server Successfully!!");
        }
    }
   
}
