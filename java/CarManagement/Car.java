//Car.java
public class Car {
    private double milesDriven;
    private double gasInTank;
    private double milesPerGallon;

    public Car (double mpg) {
        this.milesDriven = 0;
        this.gasInTank = 0;
        this.milesPerGallon = mpg;
    }

    public void addGas (double amount) {
        this.gasInTank += amount;
    }
    public void drive (double distance) {
        this.milesDriven += distance;
        double milesPerGallon = 50;
        double gasConsumed = distance / milesPerGallon;
        this.gasInTank -= gasConsumed;
    }
    public double getMilesDriven() {
        return this.milesDriven;
    }
    public double getGasInTank() {
        return this.gasInTank;
    }
}
