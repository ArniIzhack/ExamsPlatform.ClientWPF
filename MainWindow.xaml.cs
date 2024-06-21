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
			// initialize this reference of MainWindow in a static object that will be accesed fron the entire app. 
			AppHelpers.InitializeMainWindow(this);
			// load SignInPage in the ContentControl bodyContent (at MainWindow)
			AppHelpers.MoveToPage<SignInPage>();
		}
		/// <summary>
		/// temporary methode, only for ez testing
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void Window_Loaded(object sender, RoutedEventArgs e)
		{
			MenuForTeacher menu = new MenuForTeacher();
			MenuContent.Content = menu;
		}	
	}
}