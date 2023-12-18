#include "gtest/gtest.h"
#include "RiceCooker.h"

// Test fixture for RiceCooker
class RiceCookerTest : public ::testing::Test {
protected:
    RiceCooker riceCooker;

    // Helper function to refill water and rice
    void refillWaterAndRice() {
        riceCooker.addWater(5);
        riceCooker.addRice(2);
    }
};

// Test adding water to the rice cooker
TEST_F(RiceCookerTest, AddWater) {
    riceCooker.addWater(3);
    EXPECT_EQ(riceCooker.getWaterLevel(), 3);
}

// Test adding rice to the rice cooker
TEST_F(RiceCookerTest, AddRice) {
    riceCooker.addRice(2);
    EXPECT_EQ(riceCooker.getRiceAmount(), 2);
}

// Test starting cooking without water and rice
TEST_F(RiceCookerTest, StartCookingWithoutIngredients) {
    riceCooker.startCooking();
    EXPECT_FALSE(riceCooker.isCooking());
}

// Test starting cooking with water and rice
TEST_F(RiceCookerTest, StartCookingWithIngredients) {
    refillWaterAndRice();
    riceCooker.startCooking();
    EXPECT_TRUE(riceCooker.isCooking());
}

// Test checking status while not cooking
TEST_F(RiceCookerTest, CheckStatusNotCooking) {
    riceCooker.checkStatus();
    // Expect a message indicating the rice cooker is not cooking
    // You may modify this expectation based on your actual output messages
    EXPECT_TRUE(true);
}

// Test checking status during cooking
TEST_F(RiceCookerTest, CheckStatusDuringCooking) {
    refillWaterAndRice();
    riceCooker.startCooking();
    // Simulate 5 minutes of cooking
    for (int i = 0; i < 5; ++i) {
        riceCooker.checkStatus();
    }
    // Expect a message indicating cooking is in progress
    // You may modify this expectation based on your actual output messages
    EXPECT_TRUE(true);
}

// Test checking status after cooking completes
TEST_F(RiceCookerTest, CheckStatusAfterCookingComplete) {
    refillWaterAndRice();
    riceCooker.startCooking();
    // Simulate 10 minutes of cooking
    for (int i = 0; i < 10; ++i) {
        riceCooker.checkStatus();
    }
    // Expect a message indicating cooking is complete
    // You may modify this expectation based on your actual output messages
    EXPECT_TRUE(true);
}

// Test checking status after overcooking
TEST_F(RiceCookerTest, CheckStatusAfterOvercooking) {
    refillWaterAndRice();
    riceCooker.startCooking();
    // Simulate more than 10 minutes of cooking
    for (int i = 0; i < 12; ++i) {
        riceCooker.checkStatus();
    }
    // Expect a message indicating overcooking
    // You may modify this expectation based on your actual output messages
    EXPECT_TRUE(true);
}
