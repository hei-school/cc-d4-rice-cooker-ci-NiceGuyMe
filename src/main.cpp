// Copyright 2023 NiceGuyMe

#include <iostream>

#include "RiceCooker.h"

using std::cout;
using std::endl;
using std::cin;

int main() {
  RiceCooker riceCooker;

  int choice;
  bool running = true;

  while (running) {
    // Display menu options
    cout << endl << "Rice Cooker Menu:" << endl;
    cout << "1. Add Water" << endl;
    cout << "2. Add Rice" << endl;
    cout << "3. Start Cooking" << endl;
    cout << "4. Check Status" << endl;
    cout << "5. Exit" << endl;

    // Get user input
    cout << "Enter your choice: ";
    cin >> choice;

    // Execute chosen option
    switch (choice) {
      case 1:
        int waterAmount;
        cout << "Enter water amount (cups): ";
        cin >> waterAmount;
        riceCooker.addWater(waterAmount);
        break;
      case 2:
        int riceAmount;
        cout << "Enter rice amount (cups): ";
        cin >> riceAmount;
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
        cout << "Invalid choice. Please try again." << endl;
        break;
    }
  }

  return 0;
}
