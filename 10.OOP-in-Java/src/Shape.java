import java.util.Arrays;

import com.sun.xml.internal.ws.api.ha.StickyFeature;

public abstract class Shape {
	protected Vertex[] vertices;

	protected Shape(Vertex[] vertices) {
		this.vertices = vertices;
	}

	public Vertex[] getVertices() {
		return this.vertices;
	}

	@Override
	public String toString() {
		String res = "";
		for (Vertex vertex : vertices) {
			res += vertex.toString() + "\n";
		}
		return res;
		
	}

	protected String getClassName() {
		String fullClassName = this.getClass().toString();
		int indexOfLastDot = fullClassName.lastIndexOf('.');
		String className = fullClassName.substring(indexOfLastDot + 1,
				fullClassName.length());

		return className;
	}
}
