namespace MyCustomAttribute
{
	[AttributeUsage(AttributeTargets.Class)] //AtrributeUsage obj =new AttributeUsage("Class")
    public class Company :Attribute
    {
		private string _CompanyName;

		public string CompanyName
		{
			get { return _CompanyName; }
			set { _CompanyName = value; }
		}
	}
}
