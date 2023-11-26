using System.Reflection;

namespace Classes
{
    public class Program
    {
        static void Main(string[] args)
        {
            // These are the properties 
            var myCar = new Car();
            myCar.Make = "Toyota";
            myCar.Model = "Camry";
            myCar.Year = 2008;

            Console.WriteLine($"{myCar.Make}, {myCar.Model}, {myCar.Year}");
        }
        
    }
}
