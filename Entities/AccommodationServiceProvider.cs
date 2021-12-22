
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class AccommodationServiceProvider : ServiceProvider {

	public AccommodationServiceProvider() {
	}

	public List<Accommodation> accommodations {
		get; set;
	}

	/// <summary>
	/// @param accommodation 
	/// @param timePeriod
	/// </summary>
	public void reserveAccommodation(Accommodation accommodation, TimePeriod timePeriod) {
		// TODO implement here
	}

}