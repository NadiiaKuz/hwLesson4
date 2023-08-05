namespace hwLesson4
{
    class SportCar : Car, IRecycable
    {
        public SportCar(string color, int speed, int weight) : 
            base(color, speed, weight)
        {
        }

        public override void Drive() =>
            Console.WriteLine($"The {Color} sports car can move at a speed of {Speed} km/h");

        public void RecycleToMetal() => 
            Console.WriteLine($"The amount of metal received from the car is {Weight} kg.");

        public override void CarryPassengers() =>
            Console.WriteLine("The sports car can carry one passenger");

        public override void Park() =>
            Console.WriteLine("The spotr car can be parked in any car park");


        public void Drift() => Console.WriteLine($"Drift on {Color} sport car is fun");
    }
}
