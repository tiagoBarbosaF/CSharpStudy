using System;
using MultipleInheritance.Devices;

namespace MultipleInheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Printer p = new Printer() { serialNumber = 1080 };
            p.ProcessDoc("My document");
            p.Print("My letter");

            Console.WriteLine();
            Scanner s = new Scanner() { serialNumber = 2003 };
            s.ProcessDoc("My e-mail");
            Console.WriteLine(s.Scan());

            Console.WriteLine();
            ComboDevice c = new ComboDevice() { serialNumber = 3921 };
            c.ProcessDoc("My dissetation");
            c.Print("My dissertation");
            Console.WriteLine(c.Scan());
        }
    }
}
