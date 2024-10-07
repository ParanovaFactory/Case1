using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Case1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Double variables
            string apple = "Apple";
            string orange = "Orange";
            string strawberry = "Strawberry";
            string potato = "Potato";
            string tomato = "Tomato";

            // Fruit prices
            double applePrice = 3.50;
            double orangePrice = 4.25;
            double strawberryPrice = 6.75;
            double potatoPrice = 2.30;
            double tomatoPrice = 5.10;

            // Purchased gram amounts
            double appleGrams = 1000;     
            double orangeGrams = 750;     
            double strawberryGrams = 500; 
            double potatoGrams = 1200;    
            double tomatoGrams = 600;     

            // Calculating total cost based on kilogram prices (grams/1000)
            double appleTotal = (appleGrams / 1000) * applePrice;
            double orangeTotal = (orangeGrams / 1000) * orangePrice;
            double strawberryTotal = (strawberryGrams / 1000) * strawberryPrice;
            double potatoTotal = (potatoGrams / 1000) * potatoPrice;
            double tomatoTotal = (tomatoGrams / 1000) * tomatoPrice;

            // Displaying the results
            Console.WriteLine($"{apple}: {applePrice} $/kg, Purchased: {appleGrams} grams, Total Price: {appleTotal:F2} $");
            Console.WriteLine($"{orange}: {orangePrice} $/kg, Purchased: {orangeGrams} grams, Total Price: {orangeTotal:F2} $");
            Console.WriteLine($"{strawberry}: {strawberryPrice} $/kg, Purchased: {strawberryGrams} grams, Total Price: {strawberryTotal:F2} $");
            Console.WriteLine($"{potato}: {potatoPrice} $/kg, Purchased: {potatoGrams} grams, Total Price: {potatoTotal:F2} $");
            Console.WriteLine($"{tomato}: {tomatoPrice} $/kg, Purchased: {tomatoGrams} grams, Total Price: {tomatoTotal:F2} $");
            #endregion

            #region Char variables
            char symbol;
            symbol = 'A';
            Console.WriteLine(symbol);
            #endregion

            #region Klavyeden string veri girişi
            string flightNumber;
            string departureCity;
            string destinationCity;
            string departureTime;
            string arrivalTime;

            Console.Write("Enter Flight Number: ");
            flightNumber = Console.ReadLine();

            Console.Write("Enter Departure City: ");
            departureCity = Console.ReadLine();

            Console.Write("Enter Destination City: ");
            destinationCity = Console.ReadLine();

            Console.Write("Enter Departure Time (e.g., 14:30): ");
            departureTime = Console.ReadLine();

            Console.Write("Enter Arrival Time (e.g., 18:45): ");
            arrivalTime = Console.ReadLine();

            Console.WriteLine("\nFlight Information");
            Console.WriteLine($"Flight Number: {flightNumber}");
            Console.WriteLine($"Departure City: {departureCity}");
            Console.WriteLine($"Destination City: {destinationCity}");
            Console.WriteLine($"Departure Time: {departureTime}");
            Console.WriteLine($"Arrival Time: {arrivalTime}");
            #endregion

            #region Klavyeden int veri girişi
            double product1Price = 10.99;  
            double product2Price = 15.50;  
            double product3Price = 8.75;   
            double product4Price = 12.30;  

            int product1Quantity;
            int product2Quantity;
            int product3Quantity;
            int product4Quantity;

            Console.Write("Enter quantity for Product 1: ");
            product1Quantity = int.Parse(Console.ReadLine());

            Console.Write("Enter quantity for Product 2: ");
            product2Quantity = int.Parse(Console.ReadLine());

            Console.Write("Enter quantity for Product 3: ");
            product3Quantity = int.Parse(Console.ReadLine());

            Console.Write("Enter quantity for Product 4: ");
            product4Quantity = int.Parse(Console.ReadLine());

            double product1Total = product1Price * product1Quantity;
            double product2Total = product2Price * product2Quantity;
            double product3Total = product3Price * product3Quantity;
            double product4Total = product4Price * product4Quantity;

            double overallTotal = product1Total + product2Total + product3Total + product4Total;

            Console.WriteLine($"\nTotal for Product 1: {product1Total:F2} $");
            Console.WriteLine($"\nTotal for Product 2: {product2Total:F2} $");
            Console.WriteLine($"\nTotal for Product 3: {product3Total:F2} $");
            Console.WriteLine($"\nTotal for Product 4: {product4Total:F2} $");

            Console.WriteLine($"\nOverall Total: {overallTotal:F2} $");
            #endregion

            #region Klavyeden Double veri girişi
            double exam1, exam2, exam3;

            Console.Write("Enter the first exam score: ");
            exam1 = double.Parse(Console.ReadLine());

            Console.Write("Enter the second exam score: ");
            exam2 = double.Parse(Console.ReadLine());

            Console.Write("Enter the third exam score: ");
            exam3 = double.Parse(Console.ReadLine());

            double result = (exam1 + exam2 + exam3) / 3;

            Console.WriteLine($"\nThe average score is: {result:F2}");
            #endregion

            #region Klavyeden char veri girişi
            char gender;

            Console.Write("Enter your gender (M for Male, F for Female): ");

            gender = char.Parse(Console.ReadLine()); 
            
            Console.WriteLine($"Selected Gender: {gender}");
            #endregion


            Console.WriteLine();
        }
    }
}
