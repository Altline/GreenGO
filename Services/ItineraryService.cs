
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class ItineraryService {

	public ItineraryService() {
	}

	private Database database {
		get; set;
	}





	/// <summary>
	/// @return
	/// </summary>
	public List<POI> getDestinations() {
		// TODO implement here
		return null;
	}

	/// <summary>
	/// @return
	/// </summary>
	public List<Itinerary> getResevations() {
		// TODO implement here
		return null;
	}

	/// <summary>
	/// @return
	/// </summary>
	public List<POI> getRoutes() {
		// TODO implement here
		return null;
	}

	/// <summary>
	/// @param itinerary
	/// </summary>
	public void saveItinerary(Itinerary itinerary) {
		// TODO implement here
	}

	/// <summary>
	/// @param itinerary
	/// </summary>
	public void updateItinerary(Itinerary itinerary) {
		// TODO implement here
	}

	/// <summary>
	/// @param itinerary
	/// </summary>
	public void cancelItinerary(Itinerary itinerary) {
		// TODO implement here
	}

	/// <summary>
	/// @param itinerary
	/// </summary>
	private void suggestItinerary(Itinerary itinerary) {
		// TODO implement here
	}

	/// <summary>
	/// @param message
	/// </summary>
	public void informCustomers(string message) {
		// TODO implement here
	}

	/// <summary>
	/// @param itinerary
	/// </summary>
	private void notifyServiceProviders(Itinerary itinerary) {
		// TODO implement here
	}

}