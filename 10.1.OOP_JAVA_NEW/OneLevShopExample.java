
public class OneLevShopExample {

	public static void main() {
		//FoodProduct cigars = new FoodProduct("420 Blaze it fgt", 6.90, 1400, AgeRestriction.Adult);

		FoodProduct cheese = new FoodProduct("Vitosha", 17.36, 0.800, AgeRestriction.None,"2015-12-13" );
		System.out.println(cheese.toString());
		//FoodProduct cigars = new FoodProduct("420 Blaze it fgt", 6.90, 1400.0, AgeRestriction.Adult,"asdasdas");
		Customer pecata = new Customer("Pecata", 17, 30.00);

		

	}

}
