using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

[TestClass]
public class RiceCookerTests
{
    public object? Assert { get; private set; }

    [TestMethod]
    public void AddWater_ShouldIncreaseWaterLevel()
    {
        // Arrange
        RiceCooker riceCooker = new RiceCooker();

        // Act
        riceCooker.AddWater(2);

        // Assert
        Assert.AreEqual(2, riceCooker.WaterLevel);
    }

    [TestMethod]
    public void AddRice_ShouldIncreaseRiceAmount()
    {
        // Arrange
        RiceCooker riceCooker = new RiceCooker();

        // Act
        riceCooker.AddRice(3);

        // Assert
        Assert.AreEqual(3, riceCooker.RiceAmount);
    }

    [TestMethod]
    public void StartCooking_WithNotEnoughWaterOrRice_ShouldPrintErrorMessage()
    {
        // Arrange
        RiceCooker riceCooker = new RiceCooker();

        // Act
        riceCooker.StartCooking();

        // Assert
        StringAssert.Contains("Please add water and rice before starting cooking.", ConsoleOut());
    }

    [TestMethod]
    public void StartCooking_WithEnoughWaterAndRice_ShouldStartCooking()
    {
        // Arrange
        RiceCooker riceCooker = new RiceCooker();
        riceCooker.AddWater(2);
        riceCooker.AddRice(1);

        // Act
        riceCooker.StartCooking();

        // Assert
        StringAssert.Contains("Cooking started!", ConsoleOut());
        Assert.IsTrue(riceCooker.Cooking);
    }

    [TestMethod]
    public void CheckStatus_WhenCooking_ShouldPrintCookingStatus()
    {
        // Arrange
        RiceCooker riceCooker = new RiceCooker();
        riceCooker.AddWater(2);
        riceCooker.AddRice(1);
        riceCooker.StartCooking();

        // Act
        riceCooker.CheckStatus();

        // Assert
        StringAssert.Contains("Cooking... (1 minutes elapsed)", ConsoleOut());
    }

    [TestMethod]
    public void CheckStatus_WhenCookingComplete_ShouldPrintCompletionMessage()
    {
        // Arrange
        RiceCooker riceCooker = new RiceCooker();
        riceCooker.AddWater(2);
        riceCooker.AddRice(1);
        riceCooker.StartCooking();

        // Act
        for (int i = 0; i < 10; i++)
        {
            riceCooker.CheckStatus();
        }

        // Assert
        StringAssert.Contains("Cooking complete! Enjoy your rice!", ConsoleOut());
        Assert.IsFalse(riceCooker.Cooking);
    }

    [TestMethod]
    public void CheckStatus_WhenOvercooked_ShouldPrintOvercookedMessage()
    {
        // Arrange
        RiceCooker riceCooker = new RiceCooker();
        riceCooker.AddWater(2);
        riceCooker.AddRice(1);
        riceCooker.StartCooking();

        // Act
        for (int i = 0; i < 11; i++)
        {
            riceCooker.CheckStatus();
        }

        // Assert
        StringAssert.Contains("Rice overcooked. Please try again.", ConsoleOut());
        Assert.IsFalse(riceCooker.Cooking);
    }

    [TestMethod]
    public void CheckStatus_WhenNotCooking_ShouldPrintNotCookingMessage()
    {
        // Arrange
        RiceCooker riceCooker = new RiceCooker();

        // Act
        riceCooker.CheckStatus();

        // Assert
        StringAssert.Contains("Rice cooker is not currently cooking.", ConsoleOut());
    }

    private string ConsoleOut()
    {
        using (StringWriter sw = new StringWriter())
        {
            Console.SetOut(sw);
            // Capture the Console output
            return sw.ToString().Trim();
        }
    }
}

internal class TestClassAttribute : Attribute
{
}

internal class TestMethodAttribute : Attribute
{
}