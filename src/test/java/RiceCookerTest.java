import org.example.RiceCooker;
import org.junit.Test;

import static org.junit.Assert.*;

public class RiceCookerTest {

    @Test
    public void testAddWater() {
        RiceCooker riceCooker = new RiceCooker();
        riceCooker.addWater(2);
        assertEquals(2, riceCooker.getWaterLevel());
    }

    @Test
    public void testAddRice() {
        RiceCooker riceCooker = new RiceCooker();
        riceCooker.addRice(3);
        assertEquals(3, riceCooker.getRiceAmount());
    }

    @Test
    public void testStartCooking() {
        RiceCooker riceCooker = new RiceCooker();
        riceCooker.addWater(2);
        riceCooker.addRice(3);
        riceCooker.startCooking();
        assertTrue(riceCooker.isCooking());
    }

    @Test
    public void testStartCookingWithoutIngredients() {
        RiceCooker riceCooker = new RiceCooker();
        riceCooker.startCooking();
        assertFalse(riceCooker.isCooking());
    }

    @Test
    public void testCheckStatusWhileCooking() {
        RiceCooker riceCooker = new RiceCooker();
        riceCooker.addWater(2);
        riceCooker.addRice(3);
        riceCooker.startCooking();
        riceCooker.checkStatus();
        assertTrue(riceCooker.getElapsedTime() > 0);
    }

    @Test
    public void testCheckStatusAfterCooking() {
        RiceCooker riceCooker = new RiceCooker();
        riceCooker.addWater(2);
        riceCooker.addRice(3);
        riceCooker.startCooking();
        for (int i = 0; i < 10; i++) {
            riceCooker.checkStatus();
        }
        assertFalse(riceCooker.isCooking());
    }
}

