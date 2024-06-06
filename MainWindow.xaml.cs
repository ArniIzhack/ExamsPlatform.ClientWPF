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
			// create a User ViewModle
			///UserVM userVM = new UserVM();
			// Subscribe to the PropertyChanged event of the ViewModel
			///userVM.PropertyChanged += ViewModel_PropertyChanged;
			// set userVM as the DataContext for MainWindow
			///DataContext = userVM;
			// load the menu
			DisplayMenu();
			// load SignUpPage
			///GeneralClass.MoveToPage<SignInPage>(this);
			// TODO check if i need that row
		}

		/// <summary>
		/// TODO dont forget to delete this method. it is all redundant.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private async void Window_Loaded(object sender, RoutedEventArgs e)
		{
			//ExamPlatformRequestor requestor = ExamPlatformRequestor.CreateInstance();
			//UserVM userVM = DataContext as UserVM;
			//userVM.UserDTO = await requestor.RequestSignInAsync(new SignInData("203545009", "Arni92"));
			//userVM.UserDTO = await requestor.RequestSignInAsync(new SignInData("000000000", "GadShor92"));
			//GeneralClass.MoveToPage<SignUpPage>(this);
		}
		/// <summary>
		/// activate DisplayMenu when the property UserType of the ViewModel changes
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void ViewModel_PropertyChanged(object? sender, PropertyChangedEventArgs e)
		{
			if (e.PropertyName == "UserType")
			{
				DisplayMenu();
			}
		}
		/// <summary>
		/// load a menu base on the UserType of the user.
		/// </summary>
		private async void DisplayMenu()
		{
			// get the DataContext
			///UserVM userVM = DataContext as UserVM;
			// load a menu base on the type of the user
			///MenuContent.Content = await userVM.GetMenuByUserType();
		}
	}
}