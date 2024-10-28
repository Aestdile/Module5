


namespace Exam2.Classes
{
    class Car
    {
        private string model{get; set;}
        private int year{get; set;}
        private decimal price{get; set;}
        private decimal speed{get; set;}

        public Car(string model, int year, decimal price, decimal speed)
        {
            this.model=model;
            this.year=year;
            this.price=price;
            this.speed=speed;
        }

        public string Model
        {
            get{return model;}
            set{model=value;}
        }
        
        public int Year
        {
            get {return year;}
            set {year=value;}
        }

        public decimal Price
        {
            get {return price;}
            set {price=value;}
        }

        public decimal Speed
        {
            get {return speed;}
            set {speed=value;}
        }
        
        public string GetCarInfo()
        {
            return $"Model: {model}, Year: {year}, Price: {price}, Speed: {speed}";
        }
        public decimal CalculateDepreciation(int years)
        {
            for (int i = 0; i < years; i++)
            {
                price = price - 0.1m * price;
            }
            return price;
        }


    }
}


















































