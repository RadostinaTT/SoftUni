namespace P01_RawData
{
    public class Car
    {
        public Car(string model, Engine engine, Cargo cargo, Tyre[] tires)
        //public Car(string model, int engineSpeed, int enginePower, int cargoWeight, string cargoType, Tyre[] tires)
        {
            this.Model = model;
            this.Engine = engine;
            this.Cargo = cargo;
            this.tires = tires;
        }
        public string Model { get; set; }
        public Cargo Cargo;
        public Engine Engine;
        //public int EngineSpeed { get; set; }
        //public int EnginePower { get; set; }
        //public int CargoWeight { get; set; }
        //public string CargoType { get; set; }
        public Tyre[] tires;    
    }
}
