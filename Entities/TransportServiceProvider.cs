
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class TransportServiceProvider : ServiceProvider {

	public TransportServiceProvider() {
	}

	public List<Vehicle> vehicles {
		get; set;
	}

	/// <summary>
	/// @param vehicle 
	/// @param timePeriod
	/// </summary>
	public void reserveTransport(Vehicle vehicle, TimePeriod timePeriod) {
		// TODO implement here
	}

}