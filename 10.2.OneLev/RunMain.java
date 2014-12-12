import java.text.ParseException;


public class RunMain {

	public static void main(String[] args) throws ParseException {
		FoodProduct cheese = new FoodProduct("Vitosha", 17.36, 0.800, AgeRestriction.None,"15-12-2014" );
		System.out.println(cheese.toString());
		

	}

}
