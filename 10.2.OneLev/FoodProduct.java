import java.text.ParseException;
import java.text.SimpleDateFormat;
import java.util.Date;


//import org.joda.time.DateTime;
//import org.joda.time.Days;


public class FoodProduct extends Product implements Expirable{
	private String expiraDate;

	public FoodProduct(String name, double price, double quantity, AgeRestriction ageRestriction, String expDate) throws ParseException {
		super(name, price, quantity, ageRestriction);
		this.setExpiraDate(expDate);
	}
	
		public String getExpiraDate() {
		return expiraDate;
	}



	public String setExpiraDate(String expDate) throws ParseException {
		SimpleDateFormat dateFormat = new SimpleDateFormat("dd-mm-yyyy");
		if (dateFormat.parse(expiraDate) != null) {
			throw new IllegalArgumentException("Enter a valid date forma(dd-mm-yyyy)");
		}		
		return this.expiraDate;
	}



	public FoodProduct(String name, double price, double quantity, AgeRestriction ageRestriction) {
		super(name, price, quantity, ageRestriction);
		// TODO Auto-generated constructor stub
	}

	public Date getExpirationDate() {
		SimpleDateFormat dateFormat = new SimpleDateFormat("dd-mm-yyyy");
		Date checkedDate = new Date();
		try {
			checkedDate = dateFormat.parse(expiraDate);
		} catch (ParseException e) {
			throw new IllegalArgumentException("Enter a valid date forma(dd-mm-yyyy)");
		}
		return checkedDate;
	}



	@Override
	public String toString() {
		// TODO Auto-generated method stub
		return String.format("%s; %s; %s; %s", super.getName(),super.getPrice(),super.getQuantity(), this.expiraDate);
	}

	
}
