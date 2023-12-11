// Copyright 2023 NiceGuyMe
#ifndef SRC_RICECOOKER_H_
#define SRC_RICECOOKER_H_

#include <iostream>

class RiceCooker {
 public:
  // Constructor
  RiceCooker();

  // Methods
  void addWater(int amount);
  void addRice(int amount);
  void startCooking();
  void checkStatus();

 private:
  int waterLevel;
  int riceAmount;
  bool isCooking;
  int elapsedTime;
};

#endif  // SRC_RICECOOKER_H_
