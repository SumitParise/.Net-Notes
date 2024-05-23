namespace _10OOPAbstarct
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //PDF pdf = new PDF();
            //pdf.Parse();
            //pdf.Validate();
            //pdf.Save();
            string closeOP = null;
            do
            {
               
                Console.WriteLine("Choose Report Option :");
                Console.WriteLine("1.PDF, 2. DOCX, 3. TXT, 4.XML");
                int choice = Convert.ToInt32(Console.ReadLine());
                ReportFactory factory = new ReportFactory();
                Report report = factory.GetReport(choice);
                report.GenerateReport();               

            } while (closeOP !="n");
            Console.ReadLine();
        }
        
    }
    public abstract class Report
    {
        protected abstract void Parse();
        protected abstract void Validate();
        protected abstract void Save();
        public virtual void GenerateReport()
        {
            Parse();
            Validate();
            Save();
        }
    }
    public abstract class SpecialReport:Report
    {
        protected abstract void ReValidate();
        public override void GenerateReport()
        {
            Parse();
            Validate();
            ReValidate();
            Save();
        }
    }
    public class ReportFactory
    {
        public Report GetReport(int choice)
        {
            if (choice == 1) 
            {
                return new PDF();
            }else if (choice == 2) 
            {
                return new DOCX();
            }
            else if (choice == 3)
            {
                return new TXT();
            }
            else if (choice == 4)
            {
                return new XML();
            }
            else
            {
                return null;
            }
        }
    }
    public class PDF :Report
    {
        protected override void Parse()
        {
            Console.WriteLine("PDF parsed");
        }
        protected override void Validate()
        {
            Console.WriteLine("PDF validated");
        }
        protected override void Save()
        {
            Console.WriteLine("PDF saved");
        }
        
    }
    public class DOCX : Report 
    {
        protected override void Parse()
        {
            Console.WriteLine("DOCX parsed");
        }
        protected override void Validate()
        {
            Console.WriteLine("DOCX validated");
        }
        protected override void Save()
        {
            Console.WriteLine("DOCX saved");
        }        
    }
    public class TXT : SpecialReport
    {
        protected override void Parse()
        {
            Console.WriteLine("TXT parsed");
        }
        protected override void Validate()
        {
            Console.WriteLine("TXT validated");
        }
        protected override void ReValidate()
        {
            Console.WriteLine("TXT Re validated");
        }
        protected override void Save()
        {
            Console.WriteLine("TXT saved");
        }
        
    }
    public class XML : SpecialReport
    {
        protected override void Parse()
        {
            Console.WriteLine("XML parsed");
        }
        protected override void Validate()
        {
            Console.WriteLine("XML validated");
        }
        protected override void ReValidate()
        {
            Console.WriteLine("XML Re validated");
        }
        protected override void Save()
        {
            Console.WriteLine("TXT saved");
        }

    }

}
