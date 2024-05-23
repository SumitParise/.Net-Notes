
namespace _23CSharpFeatures
{
	//developed by - sagar 
    internal partial class CMath
    {
		private int _First;
		private int _Second;
        //Partial Methods are private
        //Partial Methods return type is always void
        //Partial methods can only be part of Partial classes.
        //partial void DoValidation(int num);
        partial void DoValidation(string PropertyName, object PropertyValue);


        public int Second
		{
			get { return _Second; }
			set 
			{
				//DoValidation(value);
				DoValidation("First",value);
				_Second = value;
			}
		}


		public int First
		{
			get { return _First; }
			set 
			{
                //DoValidation(value);
                DoValidation("Second", value);
                _First = value;
			}
		}

	

	}
}
