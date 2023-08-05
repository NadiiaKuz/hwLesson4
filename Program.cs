namespace hwLesson4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var sportCar = new SportCar("red", 350, 600);
            sportCar.Drive();
            sportCar.Drift();
            sportCar.CarryPassengers();
            sportCar.Park();
            sportCar.RecycleToMetal();

            string line = new string('-', Console.WindowWidth);
            Console.WriteLine(line);

            var truck = new Truck("white", 200, 1050);
            truck.Drive();
            truck.CarryCargo();            
            truck.CarryPassengers();
            truck.Park();
            truck.RecycleToMetal();
        }
    }
}