
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class HelpdeskService {

	public static readonly HelpdeskService Instance = new HelpdeskService();

	private HelpdeskService() {
	}

	private Database database {
		get; set;
	}




	/// <summary>
	/// @param question
	/// </summary>
	public void postQuestion(Question question) {
		// TODO implement here
	}

	/// <summary>
	/// @param question
	/// </summary>
	public void answerQuestion(Question question) {
		// TODO implement here
	}

}