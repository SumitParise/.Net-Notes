//namespace _16EventsDelegates
//{
//    public delegate void MyDelgate(int mrk);
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("Enter your marks :");
//            int mark = Convert.ToInt32(Console.ReadLine());
//            Student student = new Student();

//            MyDelgate myDel1 = new MyDelgate(onSuccess);
//            MyDelgate myDel2 = new MyDelgate(onFailure);

//            student.onPass += myDel1;
//            student.onFail += myDel2;
            
//            student.Mark = mark;

//        }
//        public static void onSuccess(int mrk)
//        {
//            Console.WriteLine("Congratulations you have passed with {0} marks :)",mrk);
//        }
//        public static void onFailure(int mrk)
//        {
//            Console.WriteLine("Bravo!! you have failed with {0} marks :)", mrk);
//        }

//    }
//    public class Student
//    {
//        public event MyDelgate onPass;
//        public event MyDelgate onFail;

//        private int _Mark;

//        public int Mark
//        {
//            get { return _Mark; }
//            set 
//            {
//                _Mark = value;
//                if(_Mark >=35)
//                {
//                    onPass(_Mark);
//                }else
//                {
//                    onFail(_Mark);
//                }
//            }
//        }
//    }
//}
