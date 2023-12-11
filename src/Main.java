package src;

import java.util.Scanner;

/**
 * The type Main.
 */
public class Main {

  /**
   * The entry point of application.
   *
   * @param args the input arguments
   */
  public static void main(String[] args) {
    Scanner scanner = new Scanner(System.in);
    RiceCooker riceCooker = new RiceCooker();

    int choice;
    boolean running = true;

    while (running) {
      // Display menu options
      System.out.println("\nRice Cooker Menu:");
      System.out.println("1. Add Water");
      System.out.println("2. Add Rice");
      System.out.println("3. Start Cooking");
      System.out.println("4. Check Status");
      System.out.println("5. Exit");

      // Get user input
      System.out.print("Enter your choice: ");
      choice = Integer.parseInt(scanner.nextLine());

      // Execute chosen option
      switch (choice) {
        case 1:
          System.out.print("Enter water amount (cups): ");
          int waterAmount = Integer.parseInt(scanner.nextLine());
          riceCooker.addWater(waterAmount);
          break;
        case 2:
          System.out.print("Enter rice amount (cups): ");
          int riceAmount = Integer.parseInt(scanner.nextLine());
          riceCooker.addRice(riceAmount);
          break;
        case 3:
          riceCooker.startCooking();
          break;
        case 4:
          riceCooker.checkStatus();
          break;
        case 5:
          running = false;
          break;
        default:
          System.out.println("Invalid choice. Please try again.");
          break;
      }
    }

    scanner.close();
  }
}
