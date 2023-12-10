"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
exports.RiceCooker = void 0;
var RiceCooker = /** @class */ (function () {
    function RiceCooker() {
        this.state = {
            waterLevel: 0,
            riceAmount: 0,
            cooking: false,
            elapsedTime: 0,
        };
    }
    RiceCooker.prototype.addWater = function (amount) {
        this.state.waterLevel += amount;
        console.log("Added ".concat(amount, " cup(s) of water. Current water level: ").concat(this.state.waterLevel, " cups."));
    };
    RiceCooker.prototype.addRice = function (amount) {
        this.state.riceAmount += amount;
        console.log("Added ".concat(amount, " cup(s) of rice. Current rice amount: ").concat(this.state.riceAmount, " cups."));
    };
    RiceCooker.prototype.startCooking = function () {
        if (this.state.waterLevel < 1 || this.state.riceAmount < 1) {
            console.log("Please add water and rice before starting cooking.");
        }
        else {
            this.state.cooking = true;
            this.state.elapsedTime = 0;
            console.log("Cooking started!");
        }
    };
    RiceCooker.prototype.checkStatus = function () {
        if (this.state.cooking) {
            this.state.elapsedTime++;
            if (this.state.elapsedTime < 10) {
                console.log("Cooking... (".concat(this.state.elapsedTime, " minutes elapsed)"));
            }
            else if (this.state.elapsedTime === 10) {
                console.log("Cooking complete! Enjoy your rice!");
                this.state.cooking = false;
            }
            else {
                console.log("Rice overcooked. Please try again.");
                this.state.cooking = false;
            }
        }
        else {
            console.log("Rice cooker is not currently cooking.");
        }
    };
    return RiceCooker;
}());
exports.RiceCooker = RiceCooker;
