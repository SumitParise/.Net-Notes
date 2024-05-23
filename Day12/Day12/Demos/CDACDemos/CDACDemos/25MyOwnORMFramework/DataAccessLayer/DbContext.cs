using _25MyOwnORMFramework.Model;
using Microsoft.Data.SqlClient;
using Microsoft.IdentityModel.Protocols;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _25MyOwnORMFramework.DataAccessLayer
{
    internal class DbContext
    {
        string _connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=Cdac;Integrated Security=True;Pooling=False;Encrypt=True;Trust Server Certificate=False";
        //public DbContext()
        //{
        //    //connction read from app.json
        //}
        public List<Emp> SelectRecords()
        {
            SqlConnection connection = new SqlConnection(_connectionString);
            connection.Open();
                SqlCommand cmd = new SqlCommand("select * from Emp", connection);

                SqlDataReader reader = cmd.ExecuteReader();
                List<Emp> emps = new List<Emp>();

                while (reader.Read())
                {
                    Emp emp = new Emp();
                    emp.No = Convert.ToInt32(reader["No"]);
                    emp.Name = reader["Name"].ToString();
                    emp.Address = reader["Address"].ToString();
                    emps.Add(emp);
                }
            connection.Close();

            return emps;
        }

        public int InsertRecords(Emp emp)
        {
            SqlConnection connection = new SqlConnection(_connectionString);
            connection.Open();

            string query = string.Format("insert into Emp values('{0}', '{1}')", emp.Name, emp.Address);
            SqlCommand cmd = new SqlCommand(query, connection);

            int noOfRowsAffected = cmd.ExecuteNonQuery();

            connection.Close();
            return noOfRowsAffected;
        }
        public int UpdateRecords(Emp emp)
        {
            SqlConnection connection = new SqlConnection(_connectionString);
            connection.Open();


            string query = string.Format("update Emp set Name ='{0}', Address='{1}' where No ={2}", emp.Name,
                                                                                                    emp.Address,
                                                                                                    emp.No);
            SqlCommand cmd = new SqlCommand(query, connection);

            int noOfRowsAffected = cmd.ExecuteNonQuery();

            connection.Close();
            return noOfRowsAffected;
        }
        public int DeleteRecords(int no)
        {
            SqlConnection connection = new SqlConnection(_connectionString);
            connection.Open();

            string query = string.Format("delete from Emp where No ={0}", no);
            SqlCommand cmd = new SqlCommand(query, connection);

            int noOfRowsAffected = cmd.ExecuteNonQuery();

            connection.Close();
            return noOfRowsAffected;
        }
    }
}
