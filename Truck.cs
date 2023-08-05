namespace hwLesson4
{
    class Truck : Car, IRecycable
    {
        public Truck(string color, int speed, int weight)
            : base(color, speed, weight)
        {
        }

        public override void Drive() =>
            Console.WriteLine($"The {Color} truck can move at a speed of {Speed} km/h");

        public void CarryCargo() =>
            Console.WriteLine($"The {Color} truck can carry a large amount of cargo");

        public override void CarryPassengers() =>
            Console.WriteLine("The truck is not used to carry passengers");

        public override void Park() =>
            Console.WriteLine("The truck should be parked in a special parking lot");

        public void RecycleToMetal() =>
            Console.WriteLine($"The amount of metal received from the truck is {Weight} kg.");


    }
}
