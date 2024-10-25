using Exam1.Classes;

namespace Exam1
{
    class Program
    {
        static void Main()
        {
            Book Lorri = new Book(name: "Ilon Mask");
            Lorri.SetPublicationYear(2015);
            Lorri.SetGenre("Biography");
            Lorri.PrintBook();
            Lorri.PrintAuthor();
            Lorri.PriceBook();
            Lorri.PrintPublicationYear();
            Lorri.PrintGenre();

            Book NewBook=new Book(name: "Code Breaker");
            NewBook.Author="Walter Isaacson";
            NewBook.Price=120000;
            NewBook.SetPublicationYear(2021);
            NewBook.SetGenre("Biography");
            NewBook.PrintBook();
            NewBook.PrintAuthor();
            NewBook.PriceBook();
            NewBook.PrintPublicationYear();
            NewBook.PrintGenre();
        }
    }
}































