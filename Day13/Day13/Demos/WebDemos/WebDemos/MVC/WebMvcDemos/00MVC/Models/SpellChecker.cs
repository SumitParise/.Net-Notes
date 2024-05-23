namespace _00MVC.Models
{
    public interface ISpellCheker
    {
        void DoSpellCheck();
    }
    public class EnglishSpellChecker : ISpellCheker
    {
        public EnglishSpellChecker()
        {
            
        }
        public void DoSpellCheck()
        {
            //throw new NotImplementedException();

        }
       
    }
    public class HindiSpellChecker : ISpellCheker
    {
        public HindiSpellChecker()
        {
            
        }
        public void DoSpellCheck()
        {
            //throw new NotImplementedException();
        }
    }
}
