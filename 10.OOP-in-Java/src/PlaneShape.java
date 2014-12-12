

public abstract class PlaneShape extends Shape {//implements PerimeterMeasurable, AreaMeasurable {
	
	private double x1;
	private double y1;
	
	
	public PlaneShape(double y1,double x1, Vertex[] vertices) {
		super(vertices); 
		this.setX1(x1);
		this.setY1(y1);
	}
	
	public double getX1() {
		return x1;
	}
	public void setX1(double x1) {
		this.x1 = x1;
	}
	public double getY1() {
		return y1;
	}
	public void setY1(double y1) {
		this.y1 = y1;
	}
	@Override
	public String toString() {
		// TODO Auto-generated method stub
		return super.toString();
	}
	
}