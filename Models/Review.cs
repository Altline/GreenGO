
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Review {

	public Review() {
	}

	public int rating {
		get; set;
	}

	public string description {
		get; set;
	}

	public Itinerary itinerary {
		get; set;
	}

	public Date date {
		get; set;
	}

}