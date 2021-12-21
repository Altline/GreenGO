
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Question {

	public Question() {
	}

	public string title {
		get; set;
	}

	public string details {
		get; set;
	}

	public Date date {
		get; set;
	}

	public List<string> replies {
		get; set;
	}

	/// <summary>
	/// @param reply
	/// </summary>
	public void addReply(string reply) {
		// TODO implement here
	}

}