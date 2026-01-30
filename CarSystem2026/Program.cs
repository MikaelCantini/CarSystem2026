using System.ComponentModel;
using System.Data.Common;
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
            Console.WriteLine("\n================ MENU =================");
            Console.WriteLine("\n  1. Add Car in stock");
            Console.WriteLine( "  2. Remove Car from stock");
            Console.WriteLine( "  3. View Car List");
            Console.WriteLine( "  4. Exit Program");
            Console.WriteLine("\n=======================================");
            
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
                    
                    carList.Add(car);
                    
                    Console.WriteLine("\n=============================");
                    Console.WriteLine("Car was been add in the stock");
                    Console.WriteLine("=============================");
                    
                    
                break;
                case "2":
                    if(carList.Count() == 0)
                    {
                        Console.WriteLine("=======================================");
                        Console.WriteLine("\n!!! No cars to remove, list is empty !!!");
                        Console.WriteLine("");
                        Console.Write("Press 'Enter' to continue: ");
                        Console.ReadLine();
                        Console.WriteLine("\n=======================================");
                        
                    }
                    else
                    {
                        Console.WriteLine("Input the car Id to Delete");
                        int carIdDelete = Convert.ToInt32(Console.ReadLine());                       
                        carList.RemoveAll(car => car.Id == carIdDelete);
                       
                        Console.WriteLine($"!!! Car Id: {carIdDelete} . Has been Removed from the list !!!");
                        for(int i = 0; i < carList.Count(); i++)
                        {
                            carList[i].Id = i + 1;
                        }
                        
                    }   

                break;

                case "3":
                    
                    Console.WriteLine("============= CAR LIST ================");
                    
                    if(carList.Count() == 0)
                    {
                        
                        Console.WriteLine("\n!!! List is empty, please add a Car in menu options !!!");
                        Console.Write("\nPress 'Enter' to continue: ");
                        Console.ReadLine();
                        Console.WriteLine("\n========================================");
                    
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
                        Console.Write("\nPress 'Enter' to continue: ");
                        Console.ReadLine();
                    }
                   
                break;
                
                case "4":
                    
                    Console.WriteLine("Closing program ...");
                    Console.WriteLine("\n======================================");
                    Console.WriteLine("========   CAR SYSTEM 2026   =========");
                    Console.WriteLine("======================================");
                    Console.WriteLine("\n======================================");
                    Console.WriteLine("========   THANKS FOR USING   ========");
                    Console.WriteLine("======================================");
                
                    isLoop = false;
                
                break;
                default:
                    Console.WriteLine("\n========================================================");
                    Console.WriteLine("!!! ERROR, INVALID OPTION SELECTED, PLEASE TRY AGAIN !!!");
                    Console.WriteLine("========================================================");
                break;
            }
            
            //isLoop = false;
        }

    }
}