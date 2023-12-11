package src;

/**
 * The type Rice cooker.
 */
public class RiceCooker {

  private int waterLevel;
  private int riceAmount;
  private boolean cooking;
  private int elapsedTime;

  /**
   * Add water.
   *
   * @param amount the amount
   */
  public void addWater(int amount) {
    waterLevel += amount;
    System.out.println(
        "Added " + amount + " cup(s) of water. Current water level: " + waterLevel + " cups.");
  }

  /**
   * Add rice.
   *
   * @param amount the amount
   */
  public void addRice(int amount) {
    riceAmount += amount;
    System.out.println(
        "Added " + amount + " cup(s) of rice. Current rice amount: " + riceAmount + " cups.");
  }

  /**
   * Start cooking.
   */
  public void startCooking() {
    if (waterLevel < 1 || riceAmount < 1) {
      System.out.println("Please add water and rice before starting cooking.");
    } else {
      cooking = true;
      elapsedTime = 0;
      System.out.println("Cooking started!");
    }
  }

  /**
   * Check status.
   */
  public void checkStatus() {
    if (cooking) {
      elapsedTime++;
      if (elapsedTime < 10) {
        System.out.println("Cooking... (" + elapsedTime + " minutes elapsed)");
      } else if (elapsedTime == 10) {
        System.out.println("Cooking complete! Enjoy your rice!");
        cooking = false;
      } else {
        System.out.println("Rice overcooked. Please try again.");
        cooking = false;
      }
    } else {
      System.out.println("Rice cooker is not currently cooking.");
    }
  }
}
