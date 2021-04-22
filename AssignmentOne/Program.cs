using System;

//Erin Rollestone - 10821741 - IFQ556 - Assignment One

namespace AssignmentOne
{
    //start class
    class Automobile
    {
        //fields for class
        string make;
        int idNumber, year;
        float price;

        //pass through constructor
        public Automobile(int idNumber, string make, int year, float price)
        {
            this.idNumber = idNumber;
            this.make = make;
            this.year = year;
            this.price = price;
        }

        //create GetDetails method - print only Make and Price - return year and id number
        public (int year, int idNumber) GetDetails()
        {
            Console.WriteLine("Make: {0,-12} Price: {1,10}", this.make, this.price.ToString("C2"));
            return (year, idNumber);
        }

        //Main method with 4 test cases - use getDetails for all test cases
        static void Main(string[] args)
        {
            Automobile car1 = new Automobile(0001, "Jaguar", 2015, 35000);
            Automobile car2 = new Automobile(0002, "Holden", 2012, 15000);
            Automobile car3 = new Automobile(0003, "Ford", 2017, 20000);
            Automobile car4 = new Automobile(0004, "Vokswagen", 2013, 7500);

            car1.GetDetails();
            car2.GetDetails();
            car3.GetDetails();
            car4.GetDetails();
        }
    }
}
