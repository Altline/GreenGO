
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class PaymentService {

	public static readonly PaymentService Instance = new PaymentService();

	private PaymentService() {
	}

	private Database database {
		get; set;
	}



	/// <summary>
	/// @param paymentInfo
	/// </summary>
	public void processPayment(PaymentInfo paymentInfo) {
		// TODO implement here
	}

}