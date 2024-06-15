using ExamsPlatform.ClientWPF.Views.Pages;
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

namespace ExamsPlatform.ClientWPF.Views.Menus
{
	/// <summary>
	/// Interaction logic for NoUserMenu.xaml
	/// </summary>
	public partial class NoUserMenu : UserControl
	{
		public NoUserMenu()
		{
			InitializeComponent();
		}
		/// <summary>
		/// load HomePage in the ContentControl bodyContent (at MainWindow)
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void GoToHomePage(object sender, RoutedEventArgs e)
		{
			// create an instance of HomePage
			HomePage homePage = new HomePage();
			// get the instance of MainWindow that contain this UserControl.
			MainWindow window = Window.GetWindow(this) as MainWindow;
			// load HomePage in the ContentControl bodyContent (at MainWindow)
			window.bodyContent.Content = homePage;
		}
		/// <summary>
		/// load SignInPage in the ContentControl bodyContent (at MainWindow)
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void GoToSignInPage(object sender, RoutedEventArgs e)
		{
			// create an instance of SignInPage
			SignInPage signInPage = new SignInPage();
			// get the instance of MainWindow that contain this UserControl.
			MainWindow window = Window.GetWindow(this) as MainWindow;
			// load SignInPage in the ContentControl bodyContent (at MainWindow)
			window.bodyContent.Content = signInPage;
		}
		/// <summary>
		/// load SignUpPage in the ContentControl bodyContent (at MainWindow)
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void GoToSignUpPage(object sender, RoutedEventArgs e)
		{
			// create an instance of SignUpPage
			SignUpPage signUpPage = new SignUpPage();
			// get the instance of MainWindow that contain this UserControl.
			MainWindow window = Window.GetWindow(this) as MainWindow;
			// load SignUpPage in the ContentControl bodyContent (at MainWindow)
			window.bodyContent.Content = signUpPage;
		}
	}
}
