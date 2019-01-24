using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace weeek3_csharp
{
    public class Customer
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public void Promote()
        {
            var rating = CalculateRating();
            if (rating == 0)
                Console.WriteLine("promote to level 1");

            else { Console.WriteLine("prompote to level 2"); }
        }
        public int CalculateRating()
        {
            return 0;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var customer = new Customer();
            //Vehicle purple = new Car();
            //Vehicle bowling = new Car();
            //Console.WriteLine("how many cars: {0}", Vehicle.howManyCars);


            //Book myBook = new Book();
            //myBook.SetTitle("a septrate peace");
            //Console.WriteLine(myBook.GetTitle());
        }
    }

    class Vehicle
    {
        public static int howManyCars = 0;
        public string Color = "Blue";
    }
    class Car : Vehicle
    {
        public String Color = "Red";
        public Car()
        {
            Vehicle.howManyCars++;
            Console.WriteLine("my color is" + Color);
        }
    }
    class BookCollection
    {

    }
    class Book : BookCollection
    {
        private String Title;
        public void SetTitle(String aTitle)
        {
            this.Title = aTitle;
        }
        public String GetTitle() { return this.Title; }
    }
}
