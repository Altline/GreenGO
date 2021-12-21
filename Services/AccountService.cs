
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class AccountService {

	public AccountService() {
	}

	private Database database {
		get; set;
	}

	private List<Account> activeAccounts {
		get; set;
	}




	/// <summary>
	/// @param email 
	/// @param password
	/// </summary>
	public void registerCustomer(string email, string password) {
		// TODO implement here
	}

	/// <summary>
	/// @param email 
	/// @param password
	/// </summary>
	public void registerSupportRepresentative(string email, string password) {
		// TODO implement here
	}

	/// <summary>
	/// @param email 
	/// @param password
	/// </summary>
	public void registerServiceProvider(string email, string password) {
		// TODO implement here
	}

	/// <summary>
	/// @param email 
	/// @param password 
	/// @return
	/// </summary>
	public Account authenticateUser(string email, string password) {
		// TODO implement here
		return null;
	}

	/// <summary>
	/// @param customer
	/// </summary>
	public void upgradeCustomerToPremium(RegisteredCustomer customer) {
		// TODO implement here
	}

}