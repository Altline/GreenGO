
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class PaymentInfo {

	public PaymentInfo() {
	}

	public string senderIBAN {
		get; set;
	}

	public string recipientIBAN {
		get; set;
	}

	public double amount {
		get; set;
	}

}