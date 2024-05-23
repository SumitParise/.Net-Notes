using _27EFinConsole.DAL;
using _27EFinConsole.Model;

namespace _27EFinConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CdacDbContext db = new CdacDbContext();
            int rowsAffected = 0;
            while (true) 
            {
                Console.WriteLine("1.Select 2.Insert, 3. Update, 4.Delete");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice) 
                {
                    case 1:
                     List<Customer> lst =  db.customers.ToList();
                        foreach (Customer customer in lst)
                        {
                            string result = string.Format("No ={0}, Name ={1}, Address = {2}", customer.No,
                                                                customer.Name, customer.Address);
                            Console.WriteLine(result);
                        }
                        break;
                    case 2:
                        Customer cust = new Customer();
                        Console.WriteLine("Enter Name");
                        cust.Name = Console.ReadLine();
                        Console.WriteLine("Enter Address");
                        cust.Address = Console.ReadLine();

                        db.customers.Add(cust);
                        rowsAffected = db.SaveChanges();
                        Console.WriteLine("{0} no of rows afftected",rowsAffected);
                        break;
                    case 3:
                        Console.WriteLine("Enter No to be updated");
                        int no =Convert.ToInt32(Console.ReadLine());

                        Customer custToBeUpdated = db.customers.Find(no);

                        Console.WriteLine("Enter name to be updated");
                        custToBeUpdated.Name = Console.ReadLine();
                        Console.WriteLine("Enter address to be updated");
                        custToBeUpdated.Address = Console.ReadLine();

                        rowsAffected= db.SaveChanges();
                        Console.WriteLine("{0} no of rows afftected", rowsAffected);
                        break;
                    case 4:
                        Console.WriteLine("Enter No to be deleted");
                        int noToBeDeleted = Convert.ToInt32(Console.ReadLine());

                        Customer custToBeDeleted = db.customers.Find(noToBeDeleted);

                        db.customers.Remove(custToBeDeleted);

                        rowsAffected = db.SaveChanges();
                        Console.WriteLine("{0} no of rows afftected", rowsAffected);

                        break;
                    default:
                        break;
                }
            }
        }
    }
}
