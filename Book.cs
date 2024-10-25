


namespace Exam1.Classes
{
    class Book
    {
        private string Name{get; set;}
        public string Author{get; set;}
        public decimal Price{get; set;}
        public int PublicationYear{get; private set;}
        public string Genre {get; private set;}

        public Book(string name)
        {
            Name=name;
            Author="Ashlee Vance";
            Price=700000;
        }

        public void SetPublicationYear(int year)
        {
            PublicationYear=year;
        }

        public void SetGenre(string genre)
        {
            Genre=genre;
        }

        public void PrintBook()
        {
            Console.WriteLine($"Name: {Name}");
        }

        public void PrintAuthor()
        {
            Console.WriteLine($"Author: {Author}");
        }

        public void PriceBook()
        {
            Console.WriteLine($"Price: {Price}");
        }

        public void PrintPublicationYear()
        {
            Console.WriteLine($"PublicationYear: {PublicationYear}");
        }
       
        public void PrintGenre()
        {
            Console.WriteLine($"Genre: {Genre}\n");
        }




    }
}














