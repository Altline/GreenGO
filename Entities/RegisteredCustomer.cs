
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class RegisteredCustomer {

	public RegisteredCustomer() {
	}

	private Account account {
		get; set;
	}

	public string email {
		get; set;
	}

	public string name {
		get; set;
	}





	/// <summary>
	/// @param email 
	/// @param password
	/// </summary>
	public void login(string email, string password) {
		// TODO implement here
	}

	/// <summary>
	/// @return
	/// </summary>
	public List<POI> getDestinations() {
		// TODO implement here
		return null;
	}

	public Itinerary inputItinerary()
	{
		List<POI> destinations = null;
		Accommodation accommodation = null;
		Vehicle transport = null;
		TimePeriod reservationPeriod = null;
		TravelOptions travelOptions = null;

		// ask user to input destinations
		// ask user to input accommodation
		// ask user to input transport
		// ask user to input reservatinPeriod
		// ask user to input travelOptions

		return new Itinerary(destinations, accommodation, transport, reservationPeriod, travelOptions);
	}

	/// <summary>
	/// @param itinerary
	/// </summary>
	public void generateItinerary() {
		var itinerary = inputItinerary();
		ItineraryService.Instance.saveItinerary(itinerary);
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
	public void editItinerary(Itinerary itinerary) {
		// TODO implement here
	}

	/// <summary>
	/// @param paymentInfo
	/// </summary>
	public void makePayment(PaymentInfo paymentInfo) {
		// TODO implement here
	}

	/// <summary>
	/// @param review
	/// </summary>
	public void reviewItinerary(Review review) {
		// TODO implement here
	}

	/// <summary>
	/// @param question
	/// </summary>
	public void contactHelpdesk(Question question) {
		// TODO implement here
	}

	/// <summary>
	/// @param message
	/// </summary>
	public void showPromotion(string message) {
		// TODO implement here
	}

}