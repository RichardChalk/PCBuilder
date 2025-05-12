namespace PCBuilder
{
    public interface IPCBuilder
    {
        IPCBuilder SetCPU(string cpu);
        IPCBuilder SetGPU(string gpu);
        IPCBuilder SetRAM(int gb);
        IPCBuilder SetStorage(int gb);
        IPCBuilder SetPowerSupply(int watt);
        PC Build();
    }
}
