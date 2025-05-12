namespace PCBuilder
{
    public class PC
    {
        public string CPU { get; set; }
        public string GPU { get; set; }
        public int RAM { get; set; }
        public int Storage { get; set; }
        public override string ToString() =>
            $"PC: CPU={CPU}, GPU={GPU}, RAM={RAM}GB, Storage={Storage}GB";
    }
}
