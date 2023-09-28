namespace Ferrari
{
    public interface ICar
    {
        public string Model { get; set; }
        public string DriverName { get; set; }

        public string UseBrakes();
        public string PushGasPedal();
    }
}