using Microsoft.Data.SqlClient;
using _01MVC.Models;
namespace _01MVC.DAL
{
    public class EmpDbContextcs
    {
        string _connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=Cdac;Integrated Security=True;Pooling=False;Encrypt=True;Trust Server Certificate=False";
        public List<Emp> SelectEmpRecord()
        {
            SqlConnection con = new SqlConnection(_connectionString);
            SqlCommand cmd = new SqlCommand("select * from Emp", con);
            con.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            List<Emp> emps = new List<Emp>();
            while (reader.Read())
            {
                Emp emp = new Emp();
                emp.No = (int)reader["No"];
                emp.Name = reader["Name"].ToString();
                emp.Address = reader["Address"].ToString();
                emps.Add(emp);
            }
            con.Close();
            return emps;
        }

        public int InsertEmpRecord(Emp emp)
        {
            SqlConnection con = new SqlConnection(_connectionString);
            con.Open();
            string queryText = string.Format("insert into Emp values ('{0}','{1}')", emp.Name, emp.Address);
            SqlCommand cmd = new SqlCommand(queryText, con);
            int noOfRowsAfftected = cmd.ExecuteNonQuery();
            con.Close();
            return noOfRowsAfftected;
        }
        public int UpdateEmpRecord(Emp emp)
        {
            SqlConnection con = new SqlConnection(_connectionString);
            con.Open();
            string queryText = string.Format("update Emp set Name ='{0}', Address = '{1}' where No = {2}", emp.Name,
                                                emp.Address, emp.No);
            SqlCommand cmd = new SqlCommand(queryText, con);
            int noOfRowsAfftected = cmd.ExecuteNonQuery();
            con.Close();
            return noOfRowsAfftected;
        }
        public int DeleteEmpRecord(int no)
        {
            SqlConnection con = new SqlConnection(_connectionString);
            con.Open();
            string queryText = string.Format("delete from Emp where No = {0}", no);
            SqlCommand cmd = new SqlCommand(queryText, con);
            int noOfRowsAfftected = cmd.ExecuteNonQuery();
            con.Close();
            return noOfRowsAfftected;
        }
    }
}
