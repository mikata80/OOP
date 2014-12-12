
public class GeometryExample {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		Shape[] shapes = new Shape[2];
		shapes[0] = new Triangle(12.4, 13.2, 1, 1, 2 ,3);
		shapes[1] = new Triangle(12.4, 13.2, 1, 1, 2 ,3);
		
	for (Shape shape : shapes) {
		
		System.out.println(shape.toString());
	}
	
	}

}
