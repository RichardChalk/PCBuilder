namespace PCBuilder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PC myPc = new PCBuilder()
           .SetCPU("Intel i9")
           .SetGPU("NVIDIA RTX 3080")
           .SetRAM(32)
           .SetStorage(1000)
           .Build();
            Console.WriteLine(myPc);
        }
    }
}
