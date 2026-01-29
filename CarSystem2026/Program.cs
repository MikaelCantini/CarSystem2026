using System.Linq.Expressions;
using System.Runtime.InteropServices.Marshalling;

namespace carsystem2026;

public class Program
{
    public static void Main()
    {   
        List<Car> carList = new List<Car>();

        Console.WriteLine("\n=====================================");
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
                    car.Year = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Engine Power: ");
                    car.Engine = Console.ReadLine();
                    Console.WriteLine("\n=============================");
                    Console.WriteLine("Car was been add in the stock");
                    Console.WriteLine("=============================");
                    carList.Add(car);
                    
                break;
                case "2":
                    if(carList.Count() == 0)
                    {
                        Console.WriteLine("\n!!! No cars to remove, list is empty !!!");
                    }
                    else
                    {
                        Console.WriteLine("Input the car Id to Delete");
                        int carIdDelete = Convert.ToInt32(Console.ReadLine());                       
                        carList.RemoveAll(car => car.Id == carIdDelete);
                        Console.WriteLine($"!!! Car Id: {carIdDelete} . Has been Removed from the list !!!");
                        
                    }   

                break;

                case "3":
                    Console.WriteLine("============= CAR LIST ===============");
                    if(carList.Count() == 0)
                    {
                        Console.WriteLine("\n!!! List is empty, please add a Car in menu options !!!");
                    }
                    else
                    {
                         foreach(Car cars in carList)
                        {
                            Console.WriteLine($"\nId: {cars.Id}");
                            Console.WriteLine($"Name of the Car: {cars.Name}");
                            Console.WriteLine($"Year of the Car: {cars.Year}");
                            Console.WriteLine($"Engine of the Car: {cars.Engine}");
                            Console.WriteLine("\n======================================");
                        }
                    }
                   
                break;
                
                case "4":
                    isLoop = false;
                break;
            }
            
            //isLoop = false;
        }

    }
}