public class RiceCooker
{
    private int waterLevel;
    private int riceAmount;
    private bool cooking;
    private int elapsedTime;

    public void AddWater(int amount)
    {
        waterLevel += amount;
        Console.WriteLine(
            $"Added {amount} cup(s) of water. Current water level: {waterLevel} cups.");
    }

    public void AddRice(int amount)
    {
        riceAmount += amount;
        Console.WriteLine(
            $"Added {amount} cup(s) of rice. Current rice amount: {riceAmount} cups.");
    }

    public void StartCooking()
    {
        if (waterLevel < 1 || riceAmount < 1)
        {
            Console.WriteLine("Please add water and rice before starting cooking.");
        }
        else
        {
            cooking = true;
            elapsedTime = 0;
            Console.WriteLine("Cooking started!");
        }
    }

    public void CheckStatus()
    {
        if (cooking)
        {
            elapsedTime += 1;
            if (elapsedTime < 10)
            {
                Console.WriteLine($"Cooking... ({elapsedTime} minutes elapsed)");
            }
            else if (elapsedTime == 10)
            {
                Console.WriteLine("Cooking complete! Enjoy your rice!");
                cooking = false;
            }
            else
            {
                Console.WriteLine("Rice overcooked. Please try again.");
                cooking = false;
            }
        }
        else
        {
            Console.WriteLine("Rice cooker is not currently cooking.");
        }
    }
}