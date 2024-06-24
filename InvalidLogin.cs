using System;

public class InvalidLogin : Exception
{
	public InvalidLogin(string message) : base(message) { }
	
}
