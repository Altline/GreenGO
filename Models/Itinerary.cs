
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Itinerary {

	public Itinerary() {
	}

	public List<POI> destinations {
		get; set;
	}

	public Accommodation accommodation {
		get; set;
	}

	public Vehicle transport {
		get; set;
	}

	public TimePeriod reservationPeriod {
		get; set;
	}

	public TravelOptions travelOptions {
		get; set;
	}

	public int price {
		get; set;
	}


	/// <summary>
	/// @param poi
	/// </summary>
	public void addPOI(POI poi) {
		// TODO implement here
	}

}