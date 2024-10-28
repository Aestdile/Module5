
using Exam2.Classes;

namespace Exam2
{
    class Program
    {
        static void Main()
        {
            Car Avto=new Car("Gentra", 2020, 200000  , 220);
            Console.WriteLine(Avto.GetCarInfo());

            decimal newPrice=Avto.CalculateDepreciation(3);
            Console.WriteLine($"Yangilangan narx: {newPrice}\n");

            Car Avto2=new Car("Kia K8", 2022, 800000, 320);
            Console.WriteLine(Avto2.GetCarInfo());

            decimal newPrice2=Avto2.CalculateDepreciation(2);
            Console.WriteLine($"Yangilangan narx: {newPrice2}");

        }
    }
}



















