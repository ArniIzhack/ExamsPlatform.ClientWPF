using ExamsPlatform.ClientWPF.Helpers;
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
	/// Interaction logic for MenuForStudent.xaml
	/// </summary>
	public partial class MenuForStudent : UserControl
	{
		public MenuForStudent()
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
		/// load ExamsPage in the ContentControl bodyContent (at MainWindow)
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void GoToExamsPage(object sender, RoutedEventArgs e)
		{
			AppHelpers.MoveToPage<ExamsPage>();
		}
		/// <summary>
		/// load StartAnExamPage in the ContentControl bodyContent (at MainWindow)
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void GoToStartExamPage(object sender, RoutedEventArgs e)
		{
			AppHelpers.MoveToPage<StartAnExamPage>();
		}
		/// <summary>
		/// load Calendar in the ContentControl bodyContent (at MainWindow)
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void GoToCalendarPage(object sender, RoutedEventArgs e)
		{
			AppHelpers.MoveToPage<Calendar>();
		}
		/// <summary>
		/// sign the user out and move to SignInPage
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void SIgnOut(object sender, RoutedEventArgs e)
		{
			//TODO
		}
	}
}
