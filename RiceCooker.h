#ifndef RICECOOKER_H
#define RICECOOKER_H

#include <iostream>

class RiceCooker
{
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

#endif
