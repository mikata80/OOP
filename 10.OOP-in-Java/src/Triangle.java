
public class Triangle extends PlaneShape{
	private double x2;
	private double y2;
	private double x3;
	private double y3;
	private static Vertex[] vertices;
	
	
	public Triangle(double x1, double y1, double x2, double y2, double x3,
			double y3) {
		super(x1, y1,vertices);
		this.setX2(x2);
		this.setY2(y2);
		this.setX3(x3);
		this.setY3(y3);
		//this.setVertices(vertices);
	}
	
	
	public double getX2() {
		return x2;
	}
	public void setX2(double x2) {
		this.x2 = x2;
	}
	public double getY2() {
		return y2;
	}
	public void setY2(double y2) {
		this.y2 = y2;
	}
	public double getX3() {
		return x3;
	}
	public void setX3(double x3) {
		this.x3 = x3;
	}

	
	public double getY3() {
		return y3;
	}
	public void setY3(double y3) {
		this.y3 = y3;
	}
	
	public static Vertex[] addVertices() {
		Triangle.vertices[0] = new Vertex(getX1(), getY1());
		Triangle.vertices[1] = new Vertex(getX2(), getY2());
		Triangle.vertices[2] = new Vertex(getX3(), getY3());
		return Triangle.vertices;
	}
	@Override
	public String toString() {
		// TODO Auto-generated method stub
		return super.toString();
	}
	
	
	
	
		
}
