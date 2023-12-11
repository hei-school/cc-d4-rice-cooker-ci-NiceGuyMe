// Copyright 2023 NiceGuyMe
#include <iostream>

#include "RiceCooker.h"

using std::cout;
using std::endl;
using std::cin;

RiceCooker::RiceCooker()
    : waterLevel(0), riceAmount(0), isCooking(false), elapsedTime(0) {}

void RiceCooker::addWater(int amount) {
  waterLevel += amount;
  cout << "Added " << amount
       << " cup(s) of water. Current water level: " << waterLevel << " cups."
       << endl;
}

void RiceCooker::addRice(int amount) {
  riceAmount += amount;
  cout << "Added " << amount
       << " cup(s) of rice. Current rice amount: " << riceAmount << " cups."
       << endl;
}

void RiceCooker::startCooking() {
  if (!waterLevel || !riceAmount) {
    cout << "Please add water and rice before starting cooking." << endl;
  } else {
    isCooking = true;
    elapsedTime = 0;
    cout << "Cooking started!" << endl;
  }
}

void RiceCooker::checkStatus() {
  if (isCooking) {
    elapsedTime++;
    if (elapsedTime < 10) {
      cout << "Cooking... (" << elapsedTime << " minutes elapsed)" << endl;
    } else if (elapsedTime == 10) {
      cout << "Cooking complete! Enjoy your rice!" << endl;
      isCooking = false;
    } else {
      cout << "Rice overcooked. Please try again." << endl;
      isCooking = false;
    }
  } else {
    cout << "Rice cooker is not currently cooking." << endl;
  }
}
