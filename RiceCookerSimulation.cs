using System;
public class RiceCookerSimulation
{
    public static void Main(string[] args)
    {
        RiceCooker riceCooker = new RiceCooker();

        while (true)
        {
            // Display menu options
            Console.WriteLine("\nRice Cooker Menu:");
            Console.WriteLine("1. Add Water");
            Console.WriteLine("2. Add Rice");
            Console.WriteLine("3. Start Cooking");
            Console.WriteLine("4. Check Status");
            Console.WriteLine("5. Exit");

            // Get user input
            int choice = int.Parse(Console.ReadLine());

            // Execute chosen option
            switch (choice)
            {
                case 1:
                    Console.Write("Enter water amount (cups): ");
                    int waterAmount = int.Parse(Console.ReadLine());
                    riceCooker.AddWater(waterAmount);
                    break;
                case 2:
                    Console.Write("Enter rice amount (cups): ");
                    int riceAmount = int.Parse(Console.ReadLine());
                    riceCooker.AddRice(riceAmount);
                    break;
                case 3:
                    riceCooker.StartCooking();
                    break;
                case 4:
                    riceCooker.CheckStatus();
                    break;
                case 5:
                    Console.WriteLine("Exiting rice cooker program.");
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }

            // Delay for visual effect
            System.Threading.Thread.Sleep(1000);
        }
    }
}