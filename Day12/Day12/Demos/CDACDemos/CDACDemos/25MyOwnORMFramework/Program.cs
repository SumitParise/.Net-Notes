using _25MyOwnORMFramework.DataAccessLayer;
using _25MyOwnORMFramework.Model;

namespace _25MyOwnORMFramework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true) 
            {
                Console.WriteLine("Enter choice of DbOperations:");
                Console.WriteLine("1.Select , 2. Insert , 3. Update, 4. Delete");
                int choice = Convert.ToInt32(Console.ReadLine());
                DbContext db =new DbContext();
                int noOfRowsAffected = 0;
                switch (choice) 
                {
                    case 1:
                        List<Emp> lst= db.SelectRecords();
                        foreach (Emp e in lst)
                        {
                            string op = string.Format("No ={0}, Name ={1}, Address={2}", e.No, e.Name, e.Address);
                           Console.WriteLine(op);
                        }
                        break;
                    case 2:
                        Emp emp = new Emp();

                        Console.WriteLine("Enter Name");
                        emp.Name = Console.ReadLine();
                        Console.WriteLine("Enter Address");
                        emp.Address = Console.ReadLine();
                        noOfRowsAffected = db.InsertRecords(emp);
                        Console.WriteLine("no of Afftected rows  = {0}", noOfRowsAffected);
                        break;
                    case 3:
                        Emp empToBeUpdated = new Emp();
                        Console.WriteLine("Enter no of Emp to be Updated");
                        empToBeUpdated.No = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Enter Name to be updated");
                        empToBeUpdated.Name = Console.ReadLine();
                        Console.WriteLine("Enter Address to be updated");
                        empToBeUpdated.Address = Console.ReadLine();

                        noOfRowsAffected = db.UpdateRecords(empToBeUpdated);
                        Console.WriteLine("no of Afftected rows  = {0}", noOfRowsAffected);
                        break;
                    case 4:
                        Emp empToBeDeleted = new Emp();
                        Console.WriteLine("Enter no of Emp to be Deleted");
                        empToBeDeleted.No = Convert.ToInt32(Console.ReadLine());
                        noOfRowsAffected = db.DeleteRecords(empToBeDeleted.No);
                        Console.WriteLine("no of Afftected rows  = {0}", noOfRowsAffected);
                        break;
                    default:
                        break;
                }

                Console.WriteLine("Do you want to continue> y/n");
                string ch = Console.ReadLine();
                if(ch == "n")
                {
                    break;
                }
            }
        }
    }
}
