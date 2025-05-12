namespace PCBuilder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PC myPc = new PCBuilder()
           .SetCPU("Intel i9")
           .SetGPU("NVIDIA RTX 4090")
           .SetRAM(64)
           .SetStorage(1000)
           .SetPowerSupply(800)
           .Build();
            Console.WriteLine(myPc);
        }
    }
}
