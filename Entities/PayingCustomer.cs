
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class PayingCustomer : RegisteredCustomer {

	public PayingCustomer() {
	}

	public List<double> discounts {
		get; set;
	}


	public void openTrailtracker() {
		// TODO implement here
	}

	/// <summary>
	/// @param itinerary 
	/// @param discountIndex
	/// </summary>
	public void useDiscount(Itinerary itinerary, int discountIndex) {
		// TODO implement here
	}

}