namespace hwLesson4
{
    abstract class Car 
    {
        public string Color { get; }
        public int Speed { get; }
        public int Weight { get; }

        public Car(string color, int speed, int weight)
        {
            Color = color;
            Speed = speed;
            Weight = weight;
        }

        public abstract void Drive();

        public abstract void CarryPassengers();

        public abstract void Park();
    }
}
