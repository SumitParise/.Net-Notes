using Microsoft.Data.SqlClient;
using System.Data;

namespace _26AdoNETDisconnected
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string _connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=Cdac;Integrated Security=True;Pooling=False;Encrypt=True;Trust Server Certificate=False";

            #region Select using DataAdptor 
            //SqlConnection connection = new SqlConnection(_connectionString);
            ////Disconnected Architecture
            ////Open the connection , will fire the select query,
            ////will read and bring all db records from db  and
            ////it will close the connection
            ////and it will initialize DataTable Collection for us
            //SqlDataAdapter da = new SqlDataAdapter("select * from Emp", connection);
            //SqlCommandBuilder builder = new SqlCommandBuilder(da);
            //da.MissingSchemaAction = MissingSchemaAction.AddWithKey; // this fetches Primary Key info from SqlDB
            //DataTable table = new DataTable("Emp");
            //da.Fill(table);
            ////DataSet --> collection of DataTable --> collection of DataRows -- > collection DataColumns
            //foreach (DataRow row in table.Rows)
            //{
            //    string op = string.Format("No ={0}, Name ={1}, Address ={2}",
            //                                                        row[0], row["Name"],
            //                                                        row["Address"]);
            //    Console.WriteLine(op);
            //}
            #endregion

            //int x = 10;
            //Type xType= x.GetType();
            //string str = "abc";
            
            Type typeOfInt = typeof(int);

            #region DataSet, DataTable with Ado.Net Connected approach 
           // DataSet ds = new DataSet();
            //DataTable dt = new DataTable();
            //DataColumn col1 = new DataColumn("No", typeOfInt);
            //DataColumn col1 = new DataColumn("No", typeof(int));
            //DataColumn col2 = new DataColumn("Name", typeof(string));
            //DataColumn col3 = new DataColumn("Address", typeof(string));
            //dt.Columns.Add(col1);
            //dt.Columns.Add(col2);
            //dt.Columns.Add(col3);
            //dt.PrimaryKey = new DataColumn[] { col1 };
            //SqlConnection con = new SqlConnection(_connectionString);
            //con.Open();
            //SqlCommand cmd = new SqlCommand("select * from Emp", con);
            //SqlDataReader reader = cmd.ExecuteReader();
            //while (reader.Read())
            //{
            //    DataRow row = dt.NewRow();
            //    row[0] = reader["No"];
            //    row[1] = reader["Name"];
            //    row[2] = reader["Address"];
            //    dt.Rows.Add(row);
            //}
            //con.Close();
            //ds.Tables.Add(dt);
            //ds.WriteXml(@"D:\IETCDAC\EmpData.xml");
            #endregion

            #region Insert 
            //DataRow row = ds.Tables["Emp"].NewRow();
            //// row["No"] = 21;
            //row["Name"] = "Barbie";
            //row["Address"] = "Barbie World";
            //ds.Tables["Emp"].Rows.Add(row);
            //da.Update(ds, "Emp");
            #endregion

            #region Update 
            //Console.WriteLine("Enter no");
            //int no = Convert.ToInt32(Console.ReadLine());
            //DataRow rowToBeEdited = ds.Tables["Emp"].Rows.Find(no);
            //if (rowToBeEdited != null)
            //{
            //    Console.WriteLine("Enter New Name");
            //    rowToBeEdited["Name"] = Console.ReadLine();

            //    Console.WriteLine("Enter New Address");
            //    rowToBeEdited["Address"] = Console.ReadLine();
            //}
            //da.Update(ds, "Emp");
            #endregion

            #region Delete
            Console.WriteLine("Enter no");
            int no = Convert.ToInt32(Console.ReadLine());
            DataRow rowToBeDeleted = ds.Tables["Emp"].Rows.Find(no);

            rowToBeDeleted.Delete();

            da.Update(ds, "Emp");
            #endregion
        }
    }
}
