using MyDBAttributes;
using System.ComponentModel.DataAnnotations;
namespace Employee
{
	[MyTable(TableName = "Employee")]
    public class Emp
    {
	
		private int _EId;
		private string _EName;
		private string _EAddress;

        [Columns(ColumnName = "Addres",ColumnType ="varchar(50)")]
        public string EAddress
		{
			get { return _EAddress; }
			set { _EAddress = value; }
		}

        [Columns(ColumnName = "Name",ColumnType = "varchar(50)")]
        public string EName
		{
			get { return _EName; }
			set { _EName = value; }
		}

        [Columns(ColumnName = "Id", ColumnType = "int")]
	
        public int EId
		{
			get { return _EId; }
			set { _EId = value; }
		}

	}
}
