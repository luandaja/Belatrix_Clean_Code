using System;

namespace SOLID._04_Interface_Segregation
{
    public interface IFax
    {
        bool FaxContent(string content);
    }
    public interface IPrintDuplex
    {
        bool PrintDuplexContent(string content);
    }
    public interface IMultiFuntionalPrinter
    {
        bool PrintContent(string content);
        bool ScanContent(string content);
        bool PhotoCopyContent(string content);

    }

    public class HPLaserJet : IMultiFuntionalPrinter, IFax, IPrintDuplex
    {
        public bool FaxContent(string content)
        {
            Console.WriteLine("Fax Done"); return true;
        }
        public bool PhotoCopyContent(string content)
        {
            Console.WriteLine("PhotoCopy Done"); return true;
        }
        public bool PrintContent(string content)
        {
            Console.WriteLine("Print Done"); return true;
        }
        public bool PrintDuplexContent(string content)
        {
            Console.WriteLine("Print Duplex Done"); return true;
        }
        public bool ScanContent(string content)
        {
            Console.WriteLine("Scan Done"); return true;
        }
    }

    public class CannonMG2470 : IMultiFuntionalPrinter
    {
        public bool PhotoCopyContent(string content)
        {
            Console.WriteLine("PhotoCopy Done"); return true;
        }
        public bool PrintContent(string content)
        {
            Console.WriteLine("Print Done"); return true;
        }
        public bool ScanContent(string content)
        {
            Console.WriteLine("Scan Done"); return true;
        }
    }
}
