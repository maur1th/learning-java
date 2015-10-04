//CarManagement.java
public class CarManagement {
    public static void main( String[] args ) {
        Car honda = new Car(10);
        System.out.println(honda.getGasInTank() + " gallons in tank");
        honda.addGas(20);
        System.out.println(honda.getGasInTank() + " gallons in tank");
        honda.drive(100);
        System.out.println(honda.getMilesDriven() + " miles driven");
        System.out.println(honda.getGasInTank() + " gallons in tank");
    }
}
