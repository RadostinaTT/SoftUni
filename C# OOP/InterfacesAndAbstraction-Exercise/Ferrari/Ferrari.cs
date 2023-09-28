namespace Ferrari
{
    class Ferrari : ICar
    {
        public Ferrari(string driverName)
        {
            Model = "488-Spider";
            DriverName = driverName;
        }

        public string Model { get; set; }
        public string DriverName { get; set; }

        public string PushGasPedal()
        {
            return "Gas!";
        }

        public string UseBrakes()
        {
            return "Brakes!";
        }

    }
}
