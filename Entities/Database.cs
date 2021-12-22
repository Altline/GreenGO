
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Database {

	public Database() {
	}




	public List<AccommodationServiceProvider> FetchAccommodationProviders()
	{
		// logic to return all accommodation service providers from the database
		throw new NotImplementedException();
	}

	public List<TransportServiceProvider> FetchTransportProviders()
	{
		// logic to return all transport service providers from the database
		throw new NotImplementedException();
	}


	/// <summary>
	/// @param itinerary
	/// </summary>
	public void storeItinerary(Itinerary itinerary) {

		// logic to store itinerary to the database
	}

	/// <summary>
	/// @param itinerary
	/// </summary>
	public void updateItinerary(Itinerary itinerary) {
		// TODO implement here
	}

	/// <summary>
	/// @param review
	/// </summary>
	public void storeReview(Review review) {
		// TODO implement here
	}

	/// <summary>
	/// @param question
	/// </summary>
	public void storeQuestion(Question question) {
		// TODO implement here
	}

	/// <summary>
	/// @return
	/// </summary>
	public DataPacket exportData() {
		// TODO implement here
		return null;
	}

}