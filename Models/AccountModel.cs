﻿namespace PasswordManager.Models
{
	public class AccountModel
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public string Email { get; set; }
		public string Password { get; set; }
		public string? Optional { get; set; }
	}
}
