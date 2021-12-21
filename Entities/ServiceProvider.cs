
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class ServiceProvider {

	public ServiceProvider() {
	}

	private Account account {
		get; set;
	}

	public string address {
		get; set;
	}

	public string companyName {
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
	/// @param message
	/// </summary>
	public void informCustomers(string message) {
		// TODO implement here
	}

	/// <summary>
	/// @param itinerary
	/// </summary>
	public void notifyItineraryChange(Itinerary itinerary) {
		// TODO implement here
	}

}