
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Itinerary {

	public Itinerary(List<POI> destinations, Accommodation accommodation, Vehicle transport, TimePeriod reservationPeriod, TravelOptions travelOptions)
	{
		this.destinations = destinations;
		this.accommodation = accommodation;
		this.transport = transport;
		this.reservationPeriod = reservationPeriod;
		this.travelOptions = travelOptions;
		// this.price = calculate price based on other attributes
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

	internal bool isReservationAvailable()
	{
		bool accommodationTaken = reservationPeriod.overlapsAny(accommodation.reservations);
		bool transportTaken = reservationPeriod.overlapsAny(transport.reservations);
		return !accommodationTaken && !transportTaken;
	}

	internal void reserve()
	{
		accommodation.reserve(reservationPeriod);
		transport.reserve(reservationPeriod);
	}

}