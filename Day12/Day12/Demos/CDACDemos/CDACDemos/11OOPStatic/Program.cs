namespace _11OOPStatic
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
                Database db = dataBaseFactory.GetDataBase(dbChoice);

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
    public abstract class Database
    {
        protected Logger logger = null;
        public Database()
        {
            logger = Logger.GetLogger();
        }
        public abstract void DoInsert();
        public abstract void DoUpdate();
        public abstract void DoDelete();
        public abstract string GetDataBaseName();
        public void Insert()
        {
            DoInsert();
            logger.Log("Insert in "+ GetDataBaseName() +" Done");
        }
        public void Update()
        {
            DoUpdate();
            logger.Log("Update in "+ GetDataBaseName() +"  Done");
        }
        public void Delete()
        {
            DoDelete();
            logger.Log("Delete in "+ GetDataBaseName() +"  Done");
        }
    }
   
    //Factory Pattern
    public class DataBaseFactory //Factory Classes
    {
        public Database GetDataBase(int dbChoice)//Factory Methods
        {
            if (dbChoice == 1)
            {
                return new SQLServer();
            }
            else if (dbChoice == 2)
            {
                return new OracleServer();
            }
            else if (dbChoice == 3)
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
    public class SQLServer : Database
    {
        public override void DoInsert()
        {
            Console.WriteLine("Data Inserted into SQL Server Successfully!!");
            //logger.Log("Insert in SQLServer Done");
        }
        public override void DoUpdate()
        {
            Console.WriteLine("Data Updated into SQL Server Successfully!!");
           // logger.Log("Update in SQLServer Done");
        }
        public override void DoDelete()
        {
            Console.WriteLine("Data Delete into SQL Server Successfully!!");
            //logger.Log("Delete in SQLServer Done");
        }
        public override string GetDataBaseName()
        {
            return "SQl Server";
        }
    }
    public class OracleServer : Database
    {
        //private Logger logger = null;
        //public OracleServer()
        //{
        //    logger = Logger.GetLogger();
        //}
        public override void DoInsert()
        {
            Console.WriteLine("Data Inserted into Oracle Server Successfully!!");
            //logger.Log("Insert in OracleServer Done");
        }
        public override void DoUpdate()
        {
            Console.WriteLine("Data Updated into Oracle Server Successfully!!");
            //logger.Log("Update in OracleServer Done");
        }
        public override void DoDelete()
        {
            Console.WriteLine("Data Delete into Oracle Server Successfully!!");
            //logger.Log("Delete in OracleServer Done");
        }
        public override string GetDataBaseName()
        {
            return "Oracle Server";
        }
    }
    public class MySQLServer : Database
    {
        //private Logger logger = null;
        //public MySQLServer()
        //{
        //    logger = Logger.GetLogger();
        //}
        public override void DoInsert()
        {
            Console.WriteLine("Data Inserted into MySQL Server Successfully!!");
            //logger.Log("Insert in MySql Done");

        }
        public override void DoUpdate()
        {
            Console.WriteLine("Data Updated into MySQL Server Successfully!!");
            //logger.Log("Update in MySql Done");
        }
        public override void DoDelete()
        {
            Console.WriteLine("Data Delete into MySQL Server Successfully!!");
            //logger.Log("Delete in MySql Done");
        }
        public override string GetDataBaseName()
        {
            return "MySql Server";
        }
    }
    //Single Responsibility Pattern
    public class Logger //Singleton
    {
        private static Logger logger = new Logger();
        //private static Logger logger1 = new Logger();
        private Logger()
        {
            Console.WriteLine("---Logger Object Created For First Time ---");
        }
        public static Logger GetLogger()
        {
            return logger;
        }
        //public static Logger GetLogger1()
        //{
        //    return logger1;
        //}
        public void Log(string msg)
        {
            Console.WriteLine("--- Logged msg {0} at {1}", msg, DateTime.Now.ToString());
        }
    }
}
