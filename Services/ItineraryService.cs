
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class ItineraryService
{

	public static readonly ItineraryService Instance = new ItineraryService();

	private ItineraryService()
	{
	}

	private Database database {
		get; set;
	}





	/// <summary>
	/// @return
	/// </summary>
	public List<POI> getDestinations()
	{
		// TODO implement here
		return null;
	}

	/// <summary>
	/// @return
	/// </summary>
	public List<Itinerary> getResevations()
	{
		// TODO implement here
		return null;
	}

	/// <summary>
	/// @return
	/// </summary>
	public List<POI> getRoutes()
	{
		// TODO implement here
		return null;
	}

	/// <summary>
	/// @param itinerary
	/// </summary>
	public void saveItinerary(Itinerary itinerary)
	{
		if (itinerary.isReservationAvailable())
		{
			itinerary.reserve();
			database.storeItinerary(itinerary);
			notifyServiceProviders(itinerary);
		}
		else
		{
			// alert user
		}
	}

	/// <summary>
	/// @param itinerary
	/// </summary>
	public void updateItinerary(Itinerary itinerary)
	{
		// TODO implement here
	}

	/// <summary>
	/// @param itinerary
	/// </summary>
	public void cancelItinerary(Itinerary itinerary)
	{
		// TODO implement here
	}

	/// <summary>
	/// @param itinerary
	/// </summary>
	private void suggestItinerary(Itinerary itinerary)
	{
		// TODO implement here
	}

	/// <summary>
	/// @param message
	/// </summary>
	public void informCustomers(string message)
	{
		// TODO implement here
	}

	/// <summary>
	/// Finds and notifies all service providers that are connected with the specified itinerary.
	/// @param itinerary
	/// </summary>
	private void notifyServiceProviders(Itinerary itinerary)
	{
		var accommodationProviders = database.FetchAccommodationProviders();
		foreach (var provider in accommodationProviders)
		{
			foreach (var accommodation in provider.accommodations)
			{
				if (itinerary.accommodation.Equals(accommodation))
				{
					provider.notifyItineraryChange(itinerary);
					break;
				}
			}
		}

		var transportProviders = database.FetchTransportProviders();
		foreach (var provider in transportProviders)
		{
			foreach (var vehicle in provider.vehicles)
			{
				if (itinerary.transport.Equals(vehicle))
				{
					provider.notifyItineraryChange(itinerary);
					break;
				}
			}
		}
	}

}