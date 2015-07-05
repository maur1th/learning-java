//HelloWorld.java
public class HelloWorld {
    public static void main( String[] args ) {
        
        class Point {
            int x;
            int y;
        }
        
        System.out.println("hello, world");
        Point p = new Point();
        p.x = 2;
        p.y = 3;
        System.out.println(p.x);
    }
    
}
