using ExamsPlatform.ClientWPF.ViewModels;
using ExamsPlatform.ClientWPF.Views.Pages;
using ExamsPlatform.ClientWPF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using ExamsPlatform.ClientWPF.Models;
using ExamsPlatform.ClientWPF.Helpers;
using System.Windows.Media.Animation;

namespace ExamsPlatform.ClientWPF.Views.Pages
{
	/// <summary>
	/// Interaction logic for HomePage.xaml
	/// </summary>
	public partial class HomePage : UserControl
	{
		public HomePage()
		{
			InitializeComponent();
		}
		/// <summary>
		/// 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private async void UserControl_Loaded(object sender, RoutedEventArgs e)
		{
			// get the DataContext
			UserVM userVM = DataContext as UserVM;
			// load a welocme text messege based on the type of the user.
			InitWelcomeTextBlock(userVM.User);
		}
		/// <summary>
		/// load a welocme text messege based on the type of the user.
		/// </summary>
		/// <param name="currentUser"></param>
		private void InitWelcomeTextBlock(User currentUser)
		{
			// welcomText is a welcome messege that will be displayed at home page. the default is a messege for when there is no user signed in.
			string welcomText = "Hello, welcome to Exam Platrorm, to gain full acsses please ";
			// check if currentUser is null (meaning there is no user signed in)
			// when currentUser has a value.
			if (currentUser != null)
			{
				// check if there is a user signed in
				if (currentUser.UserType != Helpers.UserType.NOTYPE)
				{
					// set the value of welcomeText with a welcome messege for an unsigned user.
					welcomText = $"Hello {currentUser.FirstName} {currentUser.LastName} , welcome to exam platrorm.";
					// hide the sign in button.
					btnGoToSignInPage.Visibility = Visibility.Collapsed;
				}
			}
			// display the welcome messege.
			welcomeTextBlock.Text = welcomText;
		}
		/// <summary>
		/// invoked when the user click on the sign in button.load the sign in page.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void btnGoToSignInPage_Click(object sender, RoutedEventArgs e)
		{
			AppHelpers.MoveToPage<SignInPage>();
		}
	}
}

