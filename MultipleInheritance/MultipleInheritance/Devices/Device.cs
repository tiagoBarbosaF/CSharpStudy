namespace MultipleInheritance.Devices
{
    abstract class Device
    {
        public int serialNumber { get; set; }

        public abstract void ProcessDoc(string document);
    }
}
