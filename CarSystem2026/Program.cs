using System.Linq.Expressions;
using System.Runtime.InteropServices.Marshalling;

namespace carsystem2026;

public class Program
{
    public static void Main()
    {   
        List<Car> carList = new List<Car>();

        Console.WriteLine("=====================================");
        Console.WriteLine("========   CAR SYSTEM 2026   ========");
        Console.WriteLine("=====================================");
        
        bool isLoop = true;
        while (isLoop)
        {
            Console.WriteLine("\n================ MENU ================");
            Console.WriteLine("\n  1. Add Car in stock");
            Console.WriteLine( "  2. Remove Car from stock");
            Console.WriteLine( "  3. View Car List");
            Console.WriteLine( "  4. Exit Program");
            Console.WriteLine("\n======================================");
            
            Console.WriteLine("Input the number of the option: ");
            string optionSelected = Console.ReadLine();
            
            

            switch (optionSelected)
            {
                
                case "1":
                    Car car = new Car();
                    car.Id = carList.Count() + 1;
                    Console.WriteLine("Name of car: ");
                    car.Name = Console.ReadLine();
                    Console.WriteLine("Year of car: ");
                    car.Year = Convert.ToInt32(Console.Read());
                    Console.WriteLine("Engine Power: ");
                    car.Engine = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("\n=============================");
                    Console.WriteLine("Car was been add in the stock");
                    Console.WriteLine("=============================");

                break;
                case "2":
                break;
                case "3":
                break;
                case "4":
                break;
            }
            
            //isLoop = false;
        }
    }
}