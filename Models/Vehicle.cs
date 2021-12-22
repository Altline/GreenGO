
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Vehicle {

	public Vehicle() {
	}

	public int seatCount {
		get; set;
	}

	public bool hasWifi {
		get; set;
	}

	public List<TimePeriod> reservations {
		get; set;
	}

}