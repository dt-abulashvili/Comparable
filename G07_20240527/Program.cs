namespace G07_20240527
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book[] books =
            {
                new Book("Harry Potter and the Sorcerer's Stone", "J.K. Rowling", 1997, 19.99m),
                new Book("The Hobbit", "J.R.R. Tolkien", 1937, 14.99m),
                new Book("Pride and Prejudice", "Jane Austen", 1813, 6.99m),
                new Book("The Metamorphosis", "Franz Kafka", 1915, 8.99m),
                new Book("And Then There Were None", "Agatha Christie", 1939, 12.99m),
                new Book("1992 Football", "Temur Abulashvili", 1995, 9.99m)
            };
            ArrayHelper.Sort<Book>(books);
            for (int i = 0; i < books.Length; i++)
            {
                Console.WriteLine(books[i]);
            }
            Console.WriteLine();

            Car[] cars =
            {
                new Car("Toyota", "Corolla", 2018),
                new Car("Toyota", "Camry", 2019),
                new Car("Honda", "Civic", 2017),
                new Car("Honda", "Accord", 2016),
                new Car("Ford", "Fusion", 2015),
                new Car("Ford", "Focus", 2014)
            };
            ArrayHelper.Sort<Car>(cars);
            for (int i = 0; i < cars.Length; i++)
            {
                Console.WriteLine(cars[i]);
            }
            Console.WriteLine();

            int[] array = { 3, 1, 4, 1, 5, 9, 2, 6, 5, 3 };
            ArrayHelper.Sort(array);
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
        }
    }
}
