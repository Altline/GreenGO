
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Accommodation {

	public Accommodation() {
	}

	public int bedsCount {
		get; set;
	}

	public bool studio {
		get; set;
	}

	public List<TimePeriod> reservations {
		get; set;
	}

}