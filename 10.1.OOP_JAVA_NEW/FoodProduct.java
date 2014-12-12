import java.text.ParseException;
import java.text.SimpleDateFormat;
import java.util.Date;
import java.util.logging.ErrorManager;

//import org.joda.time.DateTime;
//import org.joda.time.Days;


public class FoodProduct extends Product implements Expirable{
	private String expiraDate;

	public FoodProduct(String name, double price, double quantity, AgeRestriction ageRestriction, String expDate) {
		super(name, price, quantity, ageRestriction);
		this.setExpiraDate(expDate);
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

	public String getExpiraDate() {
		return expiraDate;
	}

	public void setExpiraDate(String expiraDate) {
		this.expiraDate = expiraDate;
	}

	@Override
	public String toString() {
		// TODO Auto-generated method stub
		return String.format("%d", super.getName());
	}

	
}
