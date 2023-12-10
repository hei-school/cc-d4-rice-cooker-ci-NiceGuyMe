import { RiceCooker } from "./RiceCooker";
import * as readline from 'readline-sync';


function runRiceCookerSimulation() {

  const riceCooker = new RiceCooker();

  let running = true;
  let choice: string;

  while (running) {
    // Display menu options
    console.log("\nRice Cooker Menu:");
    console.log("1. Add Water");
    console.log("2. Add Rice");
    console.log("3. Start Cooking");
    console.log("4. Check Status");
    console.log("5. Exit");

    // Get user input
    choice = readline.question("Enter your choice: ");

    switch (choice) {
      case '1':
       { const waterAmount = parseInt(
        readline.question("Enter water amount (cups): "),
        );
        riceCooker.addWater(waterAmount);}
        break;
      case '2':
        {const riceAmount = parseInt(
          readline.question("Enter rice amount (cups): "),
        );
        riceCooker.addRice(riceAmount);}
        break;
      case '3':
        riceCooker.startCooking();
        break;
      case '4':
        riceCooker.checkStatus();
        break;
      case '5':
        running = false;
        break;
      default:
        console.log("Invalid choice. Please try again.");
        break;
    }
  }
}

runRiceCookerSimulation();
