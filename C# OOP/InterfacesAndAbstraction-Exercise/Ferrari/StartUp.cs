namespace Ferrari
{
    using System;

    public class StartUp
    {
        static void Main(string[] args)
        {
            string driversName = Console.ReadLine();
            Ferrari ferrari = new Ferrari(driversName);
           
            Console.WriteLine($"{ferrari.Model}/{ferrari.UseBrakes()}/{ferrari.PushGasPedal()}/{ferrari.DriverName}");


        }
    }
}
