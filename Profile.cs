using System;

public abstract class Profile
{
	protected string username;
	protected string password;

	protected Profile(string user, string pass)
	{
		username = user;
		password = pass;
	}

	
}
