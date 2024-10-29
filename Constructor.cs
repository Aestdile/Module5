
/*


//  Task-1  


using Exam3.Classes;

namespace Exam3
{
    class Program
    {
        static void Main()
        {
            List <Pupils> Learners=new List<Pupils>
            {
                new Pupils ("Lena", "Rey", 10, Baho.Middle),
                new Pupils ("Hardin", "Scott", 14, Baho.Perfect),
                new Pupils ("Marc", "Succerberg", 12, Baho.Bad),
                new Pupils ("Emma", "Stone", 11, Baho.Good),
                new Pupils ("Billie", "Eilish", 13, Baho.Middle),
                new Pupils ("Anne", "Heatwey", 12, Baho.Perfect),
                new Pupils ("Monte", "Kristo", 11, Baho.Good),
                new Pupils ("Anna", "Asti", 13, Baho.Good),
            };

            Console.Write("Bahoni kiriting ('Perfect', 'Good', 'Middle', 'Bad'): ");
            string enterGrade=Console.ReadLine();

            if (Enum.TryParse(enterGrade, out Baho baho))
            {
                Console.WriteLine($"Bahosi '{enterGrade}' bo'lgan o'quvchilar:");
                foreach (var learner in Learners)
                {
                    if (learner.Grade == baho)
                    {
                        Console.WriteLine($"ID: {learner.Id}, Name: {learner.Name}, Surname: {learner.Surname}, Class: {learner.Claiss}");
                    }
                }
            }
            else
            {
                Console.WriteLine("Noto'g'ri baho kiritildi.");
            }



        }
    }
}


*/


/*-------------------------------------------------------------------------------------------------------------------------*/

/*

// Task-2

using Exam3.Classes;

namespace Exam3
{
    class Program
    {
        static void Main()
        {
            List<Car> Avto=new List<Car>
            {
                new Car("Mercedes", "M3-550", 900000),
                new Car("Bugatti", "Chiron", 4500000),
                new Car("Ferrari", "W770", 1600000),
                new Car("Lamborgine", "350X7", 2800000),
                new Car("Tesla", "HHB", 800000),
                new Car("BMW", "X7", 700000),
                new Car("Brabus", "M4XG", 3000000),
                new Car("Toyota", "Corolla", 750000),
                new Car("BYD", "Song", 820000),
            };


            Console.WriteLine("Iltimos, narx oraliqlarini kiriting:");
            Console.Write("Minimal narx: ");
            decimal minPrice = decimal.Parse(Console.ReadLine());
            Console.Write("Maksimal narx: ");
            decimal maxPrice = decimal.Parse(Console.ReadLine());

            Console.WriteLine($"\n{minPrice} dan {maxPrice} gacha avtomobillar:");
            foreach (var avto in Avto)
            {
                if (avto.Price>=minPrice && avto.Price<=maxPrice)
                {
                    Console.WriteLine($"Marka: {avto.Marka}, Model: {avto.Model}, Price: {avto.Price}");
                }
            }            




        }
    }
}

*/

/*-------------------------------------------------------------------------------------------------------------------------*/

/*

// Task-3


using Exam3.Classes;

namespace Exam3
{
    class Program
    {
        static void Main()
        {
            List<Boxers> Boxer=new List<Boxers>
            {
                new Boxers(1, "Thomas", "Muller", 24, 60),
                new Boxers(2, "Harry", "Kane", 25, 90),
                new Boxers(3, "Jamal", "Musiala", 23, 48),
                new Boxers(4, "Serge", "Gnabry", 26, 72),
                new Boxers(5, "Kingle", "Coman", 22, 93),
                new Boxers(6, "Leroy", "Sane", 27, 45),
                new Boxers(7, "Josua", "Kimmich", 21, 62),
                new Boxers(8, "Kim", "MinJae", 28, 96),
                new Boxers(9, "Leon", "Goretzka", 20, 66),
                new Boxers(10, "Eric", "Dier", 30, 42),
                new Boxers(11, "Manuel", "Neuer", 31, 70),
                new Boxers(12, "Hanse", "Flick", 33, 95),
                new Boxers(13, "Robert", "Lewondovski", 32, 47),
                new Boxers(14, "Nicolas", "Sule", 34, 54),
                new Boxers(15, "Arian", "Robben", 29, 91),
            };

            List<Boxers> LightWeight=new List<Boxers>();
            List<Boxers> MiddleWeight=new List<Boxers>();
            List<Boxers> HeavyWeight=new List<Boxers>();

            foreach (var boxer in Boxer)
            {
                if (boxer.Weight<50)
                {
                    HeavyWeight.Add(boxer);
                }
                else if (boxer.Weight>=50 && boxer.Weight<=76)
                {
                    MiddleWeight.Add(boxer);
                }
                else 
                {
                    LightWeight.Add(boxer);
                }
            }

            Console.WriteLine("Yengil vazn toifasidagilar:\n");
            foreach (var boxer in HeavyWeight)
            {
                    Console.WriteLine($"Id: {boxer.Id}, LastName: {boxer.Surname}, FirstName: {boxer.Name}, Age: {boxer.Age}, Weight: {boxer.Weight}.");
            }

            Console.WriteLine("\nO'rta vazn toifasidagilar:\n");
            foreach (var boxer in MiddleWeight)
            {
                    Console.WriteLine($"Id: {boxer.Id}, LastName: {boxer.Surname}, FirstName: {boxer.Name}, Age: {boxer.Age}, Weight: {boxer.Weight}.");
            }

            Console.WriteLine("\nYuqori vazn toifasidagilar:\n");
            foreach (var boxer in LightWeight)
            {
                    Console.WriteLine($"Id: {boxer.Id}, LastName: {boxer.Surname}, FirstName: {boxer.Name}, Age: {boxer.Age}, Weight: {boxer.Weight}.");
            }
  
        }
    }
}

*/


















