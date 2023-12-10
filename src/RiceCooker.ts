export interface RiceCookerState {
  waterLevel: number;
  riceAmount: number;
  cooking: boolean;
  elapsedTime: number;
}

export class RiceCooker {
  private state: RiceCookerState = {
    waterLevel: 0,
    riceAmount: 0,
    cooking: false,
    elapsedTime: 0,
  };

  addWater(amount: number): void {
    this.state.waterLevel += amount;
    console.log(
      `Added ${amount} cup(s) of water. Current water level: ${this.state.waterLevel} cups.`,
    );
  }

  addRice(amount: number): void {
    this.state.riceAmount += amount;
    console.log(
      `Added ${amount} cup(s) of rice. Current rice amount: ${this.state.riceAmount} cups.`,
    );
  }

  startCooking(): void {
    if (this.state.waterLevel < 1 || this.state.riceAmount < 1) {
      console.log("Please add water and rice before starting cooking.");
    } else {
      this.state.cooking = true;
      this.state.elapsedTime = 0;
      console.log("Cooking started!");
    }
  }

  checkStatus(): void {
    if (this.state.cooking) {
      this.state.elapsedTime++;

      if (this.state.elapsedTime < 10) {
        console.log(`Cooking... (${this.state.elapsedTime} minutes elapsed)`);
      } else if (this.state.elapsedTime === 10) {
        console.log("Cooking complete! Enjoy your rice!");
        this.state.cooking = false;
      } else {
        console.log("Rice overcooked. Please try again.");
        this.state.cooking = false;
      }
    } else {
      console.log("Rice cooker is not currently cooking.");
    }
  }
}
