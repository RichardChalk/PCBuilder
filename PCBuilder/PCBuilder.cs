namespace PCBuilder
{
    public class PCBuilder : IPCBuilder
    {
        private PC _pc = new PC();
        public IPCBuilder SetCPU(string cpu) 
        { 
            _pc.CPU = cpu; 
            return this; 
        }
        public IPCBuilder SetGPU(string gpu) 
        { 
            _pc.GPU = gpu; 
            return this; 
        }
        public IPCBuilder SetRAM(int gb) 
        { 
            _pc.RAM = gb; 
            return this; 
        }
        public IPCBuilder SetStorage(int gb) 
        { 
            _pc.Storage = gb; 
            return this; 
        }
        public PC Build() 
        { 
            return _pc; 
        }
    }
}
