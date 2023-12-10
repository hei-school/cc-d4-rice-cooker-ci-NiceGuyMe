import { RiceCooker, RiceCookerState } from "./RiceCooker";
let prompt = require("prompt-sync")();

function runRiceCookerSimulation() {
  const riceCooker = new RiceCooker();

  let running = true;
  let choice: number;

  while (running) {
    // Display menu options
    console.log("\nRice Cooker Menu:");
    console.log("1. Add Water");
    console.log("2. Add Rice");
    console.log("3. Start Cooking");
    console.log("4. Check Status");
    console.log("5. Exit");

    // Get user input
    choice = parseInt(prompt("Enter your choice: ") || "0");

    switch (choice) {
      case 1:
        const waterAmount = parseInt(
          prompt("Enter water amount (cups): ") || "0",
        );
        riceCooker.addWater(waterAmount);
        break;
      case 2:
        const riceAmount = parseInt(
          prompt("Enter rice amount (cups): ") || "0",
        );
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
        console.log("Invalid choice. Please try again.");
        break;
    }
  }
}

runRiceCookerSimulation();
