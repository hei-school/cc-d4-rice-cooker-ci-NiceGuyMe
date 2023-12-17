// rice-cooker.test.ts
import { RiceCooker} from '../src/RiceCooker';

describe('RiceCooker', () => {
  let riceCooker: RiceCooker;

  beforeEach(() => {
    riceCooker = new RiceCooker();
  });

  test('addWater should update waterLevel', () => {
    riceCooker.addWater(3);
    expect(riceCooker['state'].waterLevel).toBe(3);
  });

  test('addRice should update riceAmount', () => {
    riceCooker.addRice(2);
    expect(riceCooker['state'].riceAmount).toBe(2);
  });

  test('startCooking should start cooking if water and rice are added', () => {
    riceCooker.addWater(1);
    riceCooker.addRice(1);
    riceCooker.startCooking();
    expect(riceCooker['state'].cooking).toBe(true);
  });

  test('startCooking should not start cooking if water or rice is missing', () => {
    riceCooker.startCooking();
    expect(riceCooker['state'].cooking).toBe(false);
  });

  test('checkStatus should print correct messages during cooking process', () => {
    riceCooker.addWater(1);
    riceCooker.addRice(1);
    riceCooker.startCooking();

    jest.spyOn(console, 'log').mockImplementation(() => {}); // Suppress console.log

    for (let i = 1; i <= 10; i++) {
      riceCooker.checkStatus();
      if (i < 10) {
        expect(console.log).toHaveBeenCalledWith(`Cooking... (${i} minutes elapsed)`);
      } else {
        expect(console.log).toHaveBeenCalledWith('Cooking complete! Enjoy your rice!');
        expect(riceCooker['state'].cooking).toBe(false);
      }
    }
  });
});
