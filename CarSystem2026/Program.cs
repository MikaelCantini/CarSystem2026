using System.Linq.Expressions;
using System.Runtime.InteropServices.Marshalling;

namespace carsystem2026;

public class Program
{
    public static void Main()
    {

        Console.WriteLine("=====================");
        Console.WriteLine("== CAR SYSTEM 2026 ==");
        Console.WriteLine("=====================");

        bool isLoop = true;
        while (isLoop)
        {
            Console.WriteLine("\n======  MENU  =======");
            Console.WriteLine("\n1. Add Car in stock");
            Console.WriteLine( "2. Remove Car from stock");
            Console.WriteLine( "3. View Car List");
            Console.WriteLine( "4. Exit Program");
            
            isLoop = false;
        }
    }
}