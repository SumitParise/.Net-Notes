using Microsoft.Data.SqlClient;

namespace _24ADO_NET_Connected
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string _connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=Cdac;Integrated Security=True;Pooling=False;Encrypt=True;Trust Server Certificate=False";

            //Connected Architecture  
            #region Input/Output from Console
            #region Select 
            //SqlConnection connection = new SqlConnection(_connectionString);
            //connection.Open();
            //SqlCommand cmd = new SqlCommand("select * from Emp", connection);

            //SqlDataReader reader = cmd.ExecuteReader();

            //while (reader.Read())
            //{
            //    string result = string.Format("No = {0}, Name ={1}, Address={2}",
            //                                    reader[0], reader["Name"], reader[2]);
            //    Console.WriteLine(result);
            //}
            //connection.Close();
            #endregion

            #region Insert 
            //SqlConnection connection = new SqlConnection(_connectionString);
            //connection.Open();

            //Console.WriteLine("Enter Name");
            //string ?nm = Console.ReadLine();
            //Console.WriteLine("Enter Address");
            //string ?ad = Console.ReadLine();

            //string query = string.Format("insert into Emp values('{0}', '{1}')", nm, ad);
            //SqlCommand cmd = new SqlCommand(query, connection);

            //int noOfRowsAffected = cmd.ExecuteNonQuery();
            //Console.WriteLine("no of Afftected rows  = {0}", noOfRowsAffected);

            //connection.Close(); 
            #endregion

            #region Update
            //SqlConnection connection = new SqlConnection(_connectionString);
            //connection.Open();
            //Console.WriteLine("Enter no of Emp to be Updated");
            //int no = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Enter Name to be updated");
            //string? nameToBeUpdated = Console.ReadLine();
            //Console.WriteLine("Enter Address to be updated");
            //string? adddressToBeUpdated = Console.ReadLine();

            //string query = string.Format("update Emp set Name ='{0}', Address='{1}' where No ={2}", nameToBeUpdated,
            //                                             adddressToBeUpdated, no);
            //SqlCommand cmd = new SqlCommand(query, connection);

            //int noOfRowsAffected = cmd.ExecuteNonQuery();
            //Console.WriteLine("no of Afftected rows  = {0}", noOfRowsAffected);

            //connection.Close(); 
            #endregion

            #region Delete 
            //SqlConnection connection = new SqlConnection(_connectionString);
            //connection.Open();

            //Console.WriteLine("Enter no of Emp to be Deleted");
            //int noToBeDeleted = Convert.ToInt32(Console.ReadLine());

            //string query = string.Format("delete from Emp where No ={0}",noToBeDeleted);
            //SqlCommand cmd = new SqlCommand(query, connection);

            //int noOfRowsAffected = cmd.ExecuteNonQuery();
            //Console.WriteLine("no of Afftected rows  = {0}", noOfRowsAffected);

            //connection.Close(); 
            #endregion

            #endregion

            List<Emp> emps = new List<Emp>();

            #region Select with List<Emp> 

            //SqlConnection connection = new SqlConnection(_connectionString);
            //connection.Open();
            //SqlCommand cmd = new SqlCommand("select * from Emp", connection);

            //SqlDataReader reader = cmd.ExecuteReader();

            //while (reader.Read())
            //{
            //    Emp emp = new Emp();
            //    emp.No =Convert.ToInt32(reader["No"]);
            //    emp.Name = reader["Name"].ToString();
            //    emp.Address = reader["Address"].ToString();
            //    emps.Add(emp);
            //}
            //connection.Close();

            //foreach (Emp emp in emps) 
            //{
            //    string op = string.Format("No ={0}, Name ={1}, Address={2}",emp.No,emp.Name,emp.Address);
            //    Console.WriteLine(op);
            //}

            #endregion

            #region Insert with Emp Obj 

            //SqlConnection connection = new SqlConnection(_connectionString);
            //connection.Open();
            //Emp emp = new Emp();

            //Console.WriteLine("Enter Name");
            //emp.Name = Console.ReadLine();
            //Console.WriteLine("Enter Address");
            //emp.Address= Console.ReadLine();

            //string query = string.Format("insert into Emp values('{0}', '{1}')", emp.Name,emp.Address);
            //SqlCommand cmd = new SqlCommand(query, connection);

            //int noOfRowsAffected = cmd.ExecuteNonQuery();
            //Console.WriteLine("no of Afftected rows  = {0}", noOfRowsAffected);

            //connection.Close();
            #endregion

            #region Update using Emp 

            //SqlConnection connection = new SqlConnection(_connectionString);
            //connection.Open();
            //Emp empToBeUpdated = new Emp();
            //Console.WriteLine("Enter no of Emp to be Updated");
            //empToBeUpdated.No = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Enter Name to be updated");
            //empToBeUpdated.Name = Console.ReadLine();
            //Console.WriteLine("Enter Address to be updated");
            //empToBeUpdated.Address = Console.ReadLine();

            //string query = string.Format("update Emp set Name ='{0}', Address='{1}' where No ={2}", empToBeUpdated.Name,
            //                                                                                        empToBeUpdated.Address,
            //                                                                                        empToBeUpdated.No);
            //SqlCommand cmd = new SqlCommand(query, connection);

            //int noOfRowsAffected = cmd.ExecuteNonQuery();
            //Console.WriteLine("no of Afftected rows  = {0}", noOfRowsAffected);

            //connection.Close();
            #endregion

            #region Delete using Emp 

            //SqlConnection connection = new SqlConnection(_connectionString);
            //connection.Open();

            //Emp empToBeDeleted = new Emp();
            //Console.WriteLine("Enter no of Emp to be Deleted");
            //empToBeDeleted.No = Convert.ToInt32(Console.ReadLine());

            //string query = string.Format("delete from Emp where No ={0}", empToBeDeleted.No);
            //SqlCommand cmd = new SqlCommand(query, connection);

            //int noOfRowsAffected = cmd.ExecuteNonQuery();
            //Console.WriteLine("no of Afftected rows  = {0}", noOfRowsAffected);

            //connection.Close();
            #endregion


        }
        public class Emp
        {
            public int No { get; set; }
            public string ?Name { get; set; }
            public string ?Address { get; set; }
        }
    }
}
