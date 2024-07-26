using ExamsPlatform.ClientWPF.Views.Menus;
using ExamsPlatform.ClientWPF.Views.Pages;
using ExamsPlatform.ClientWPF;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Media3D;
using System.Windows;
using ExamsPlatform.ClientWPF.Models;
using ExamsPlatform.ClientWPF.Helpers;

namespace ExamsPlatform.ClientWPF.ViewModels
{
	class UserVM : ModelVM
	{
		// Private field to store the current user
		private User user;
		#region constractors
		// Default constructor initializes a new User object
		public UserVM() : this(new User()) { }
		// Constructor that accepts a User object and initializes the User property
		public UserVM(User user)
		{
			User = user;
		}
		#endregion
		#region properties
		// Property to get or set the current User. It also triggers property changed notifications for some of user properties
		public User User
		{
			get => user; set
			{
				user = value;
				OnPropertyChanged("Id");
				OnPropertyChanged("UserId");
				OnPropertyChanged("FirstName");
				OnPropertyChanged("LastName");
				OnPropertyChanged("Email");
				OnPropertyChanged("PhoneNumber");
				OnPropertyChanged("Password");
				OnPropertyChanged("UserType");
			}
		}
		// Property to get the user's PK Id.
		public int Id
		{
			get => User.Id;
		}
		// Property for the user's UserId. It updates the user object and triggers a property changed notification
		public string UserId
		{
			get => User.UserId;
			set
			{
				if (User.UserId != value)
				{
					User.UserId = value;
					OnPropertyChanged();
				}
			}
		}
		// Property for the user's FirstName. It updates the user object and triggers a property changed notification
		public string FirstName
		{
			get => User.FirstName;
			set
			{
				if (User.FirstName != value)
				{
					User.FirstName = value;
					OnPropertyChanged();
				}
			}
		}
		// Property for the user's LastName. It updates the user object and triggers a property changed notification
		public string LastName
		{
			get => User.LastName;
			set
			{
				if (User.LastName != value)
				{
					User.LastName = value;
					OnPropertyChanged();
				}
			}
		}
		// Property for the user's Email. It updates the user object and triggers a property changed notification
		public string Email
		{
			get => User.Email;
			set
			{
				if (User.Email != value)
				{
					User.Email = value;
					OnPropertyChanged();
				}
			}
		}
		// Property for the user's PhoneNumber. It updates the user object and triggers a property changed notification
		public string PhoneNumber
		{
			get => User.PhoneNumber;
			set
			{
				if (User.PhoneNumber != value)
				{
					User.PhoneNumber = value;
					OnPropertyChanged();
				}
			}
		}
		// Property for the user's Password. It updates the user object and triggers a property changed notification
		public string Password
		{
			get => User.Password;
			set
			{
				if (User.Password != value)
				{
					User.Password = value;
					OnPropertyChanged();
				}
			}
		}
		// Property for the user's UserType. It updates the user object and triggers a property changed notification
		public UserType UserType
		{
			get => User.UserType;
			set
			{
				if (User.UserType != value)
				{
					User.UserType = value;
					OnPropertyChanged();
				}
			}
		}
		#endregion
	}
}

