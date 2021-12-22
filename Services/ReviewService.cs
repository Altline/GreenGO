
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class ReviewService {

	public static readonly ReviewService Instance = new ReviewService();

	private ReviewService() {
	}

	private Database database {
		get; set;
	}



	/// <summary>
	/// @param review
	/// </summary>
	public void postReview(Review review) {
		// TODO implement here
	}

	/// <summary>
	/// @param review
	/// </summary>
	private void checkForSpam(Review review) {
		// TODO implement here
	}

}