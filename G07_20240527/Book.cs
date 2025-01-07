namespace G07_20240527
{
    // Implement compare logic by price then by year
    public class Book : IComparable<Book>
    {
        public Book(string title, string author, int year, decimal price)
        {
            Title = title;
            Author = author;
            Year = year;
            Price = price;
        }

        public string Title { get; set; }
        public string Author { get; set; }
        public int Year { get; set; }
        public decimal Price { get; set; }

        public override string ToString()
        {
            return $"{Year}, {Author}, {Title}, {Price}";
        }
        public int CompareTo(Book? other)
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
