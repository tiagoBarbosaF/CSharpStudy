using System;

namespace MultipleInheritance.Devices
{
    class ComboDevice : Device, IPrinter, IScanner
    {
        public void Print(string document)
        {
            Console.WriteLine($"ComboDevice: {document}");
        }

        public override void ProcessDoc(string document)
        {
            Console.WriteLine($"ComboDevice processing: {document}");
        }

        public string Scan()
        {
            return "ComboDevice scan result";
        }
    }
}
