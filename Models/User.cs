using ExamsPlatform.ClientWPF.Helpers;
using ExamsPlatform.ClientWPF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamsPlatform.ClientWPF.Models
{
	internal class User
	{
		// field for the PK, will be initalized by EntityFramwork
		private int id;
		// field for the Id of the user
		private string userId;
		// field for the first name of the user
		private string firstMame;
		// field for the last name of the user
		private string lastName;
		// field for the email adress of the user
		private string email;//uniqe
		// field for the phone number of the user
		private string phoneNumber;
		// field for the password of the account
		private string password;
		// field for the type of the user
		private UserType userType;
		// field for the names of the exams related to the user
		private List<string> examsNames;
		// property for the PK, will be initalized by EntityFramwork
		public int Id { get => id; set => id = value; }// TOOD check if this should the set be a readonly?
		// property for the Id of the user
		public string UserId { get => userId; set => userId = value; }
		// property for the first name of the user
		public string FirstName { get => firstMame; set => firstMame = value; }
		// property for the last name of the user
		public string LastName { get => lastName; set => lastName = value; }
		// property for the email adress of the user
		public string Email { get => email; set => email = value; }
		// property for the phone number of the user
		public string PhoneNumber { get => phoneNumber; set => phoneNumber = value; }
		// property for the password of the account
		public string Password { get => password; set => password = value; }
		// property for the type of the user
		public UserType UserType { get => userType; set => userType = value; }
		// property for the names of the exams of the user
		public List<string> ExamsNames { get => examsNames; set => examsNames = value; }
		
		// empty contractore
		public User() : this("", "", "", "", "", "", UserType.NOTYPE, new List<string>()) { }
		// constractore for when we initalize all the data exept for the Id
		public User(string personId, string firstName, string lastName, string email, string phoneNumber, string password,
			UserType userType, List<string> examsNames)
		{
			UserId = personId;
			FirstName = firstName;
			LastName = lastName;
			Email = email;
			PhoneNumber = phoneNumber;
			Password = password;
			UserType = userType;
			ExamsNames = examsNames;
		}
		/// <summary>
		/// retun the user's full name
		/// </summary>
		/// <returns></returns>
		public async Task<string> GetFullName()
		{ 
			return lastName + " " + firstMame; 
		}
	}
}

