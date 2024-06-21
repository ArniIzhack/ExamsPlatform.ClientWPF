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
		}

		private void Window_Loaded(object sender, RoutedEventArgs e)
		{
			NoUserMenu noUserMenu = new NoUserMenu();
			MenuContent.Content = noUserMenu;
		}
	}
}