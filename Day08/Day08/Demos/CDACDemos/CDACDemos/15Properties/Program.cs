namespace _15Properties
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee();
            //employee.ID = 14;
            Console.WriteLine("Id = {0}", employee.ID);
            employee.EName = "Hugh Jackman";
            employee.EAddress = "New York";
            Console.WriteLine("Id = {0}, Name ={1}, Address ={2}",
                employee.ID,employee.EName,employee.EAddress);

            // employee.Set_EID(14);
            //Console.WriteLine(employee.Get_EID());
        }
    }
    public class Employee
    {
        private int _EID =100;
        private string _EName;
        private string _EAddress;

        //public int ID
        //{
        //    set
        //    {
        //        _EID = value;
        //    }
        //    get 
        //    {
        //        return _EID;
        //    }
        //}
        public int ID
        {
            get
            {
                return _EID;
            }
        }
        public int ID
        {
            get
            {
                if(_EID == 100)
                {
                    _EID = 1000;
                }
                return _EID;
            }
        }
        public string EName
        {
            get { return _EName; }
            set 
            {
                string str = "Mr/Mrs." + value;
                _EName = str; 
            }
        }

        public string EAddress
        {
            get { return _EAddress; }
            set { _EAddress = value; }
        }

        #region Old way to write Getters and Setters
        //public void Set_EID(int id)
        //{
        //    _EID = id;
        //}
        //public int Get_EID()
        //{
        //    return _EID;
        //}
        //public void Set_EName(string name)
        //{
        //    _EName = name;
        //}
        //public string Get_EName()
        //{
        //    return _EName;
        //}
        //public void Set_EAddress(string address)
        //{
        //    _EAddress = address;
        //}
        //public string Get_EAddress()
        //{
        //    return _EAddress;
        //} 
        #endregion
    }
}
