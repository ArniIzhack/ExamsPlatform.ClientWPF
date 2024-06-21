using ExamsPlatform.ClientWPF.Views.Pages;
using ExamsPlatform.ClientWPF.Helpers;
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
			AppHelpers.MoveToPage<HomePage>();
		}
		/// <summary>
		/// load SignInPage in the ContentControl bodyContent (at MainWindow)
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void GoToSignInPage(object sender, RoutedEventArgs e)
		{
			AppHelpers.MoveToPage<SignInPage>();
		}
		/// <summary>
		/// load SignUpPage in the ContentControl bodyContent (at MainWindow)
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void GoToSignUpPage(object sender, RoutedEventArgs e)
		{
			AppHelpers.MoveToPage<SignUpPage>();
		}
	}
}