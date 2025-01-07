namespace G07_20240527
{
    public class Car : IComparable<Car>
    {
        public Car(string make, string model, int year)
        {
            Make = make;
            Model = model;
            Year = year;
        }

        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }

        public override string ToString()
        {
            return $"{Year} {Make} {Model}";
        }

        public int CompareTo(Car? other)
        {
            if (other == null)
            {
                return 1;
            }

            if (this.Year > other.Year)
            {
                return 1;
            }

            if (this.Year < other.Year)
            {
                return -1;
            }

            return 0;
        }
    }
}
