using ExamsPlatform.ClientWPF.Views.Menus;
using ExamsPlatform.ClientWPF.Helpers;
using System.ComponentModel;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using ExamsPlatform.ClientWPF.Views.Pages;
using ExamsPlatform.ClientWPF.ViewModels;

namespace ExamsPlatform.ClientWPF
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		public MainWindow()
		{
			InitializeComponent();
			// create a ViewModle
			UserVM userVM = new UserVM();
			// set userVM as the DataContext for MainWindow
			DataContext = userVM;
			// load the menu
			DisplayMenu();
			// initialize this reference of MainWindow in a static object that will be accesed fron the entire app. 
			AppHelpers.InitializeMainWindow(this);
			// load SignInPage in the ContentControl bodyContent (at MainWindow)
			AppHelpers.MoveToPage<HomePage>();
		}
		/// <summary>
		/// temporary methode, only for faster testing
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void Window_Loaded(object sender, RoutedEventArgs e)
		{
		}
		/// <summary>
		/// load a menu base on the UserType of the user.
		/// </summary>
		private async void DisplayMenu()
		{
			// get the DataContext
			UserVM userVM = DataContext as UserVM;
			// get the type of the current user
			UserType userType = userVM.UserType;
			// check if UserType is NOTYPE
			if (userType == UserType.NOTYPE)
				// load the menu for when no user is signed in
				MenuContent.Content = new NoUserMenu();
			// check if UserType is Student
			else if (userType == UserType.Student)
				// load the menu for when a student is signed in
				MenuContent.Content = new MenuForStudent();
			// when UserType is Teacher
			else
				// load the menu for when a teacher is signed in
				MenuContent.Content = new MenuForTeacher();
			// load a menu base on the type of the user
		}
	}
}