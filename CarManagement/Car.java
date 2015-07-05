//Car.java
public class Car {
    private double milesDriven;
    private double gasInTank;

    public void addGas (double amount) {
        gasInTank = gasInTank + amount;
    }
    public void drive (double distance) {
        milesDriven = milesDriven + distance;
        double milesPerGallon = 50;
        double gasConsumed = distance / milesPerGallon;
        gasInTank = gasInTank - gasConsumed;
    }
    public double getMilesDriven() {
        return milesDriven;
    }
    public double getGasInTank() {
        return gasInTank;
    }
}
