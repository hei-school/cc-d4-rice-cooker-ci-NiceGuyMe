namespace Main
{
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
                string? input = Console.ReadLine();

                // Try parse the input
                int choice;
                bool isParsed = int.TryParse(input, out choice);

                // Execute chosen option based on successful parsing
                if (isParsed)
                {
                    switch (choice)
                    {
                        case 1:
                            Console.Write("Enter water amount (cups): ");
                            string? waterInput = Console.ReadLine();
                            if (int.TryParse(waterInput, out int waterAmount))
                            {
                                riceCooker.AddWater(waterAmount);
                            }
                            else
                            {
                                Console.WriteLine("Invalid water amount. Please try again.");
                            }
                            break;
                        case 2:
                            Console.Write("Enter rice amount (cups): ");
                            string? riceInput = Console.ReadLine();
                            if (int.TryParse(riceInput, out int riceAmount))
                            {
                                riceCooker.AddRice(riceAmount);
                            }
                            else
                            {
                                Console.WriteLine("Invalid rice amount. Please try again.");
                            }
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
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a number between 1 and 5.");
                }

                // Delay for visual effect
                System.Threading.Thread.Sleep(1000);
            }

        }
    }
}