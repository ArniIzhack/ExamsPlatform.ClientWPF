using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace ExamsPlatform.ClientWPF.Helpers
{
	internal class AppHelpers
	{
		// Private static field to hold the main window reference
		private static MainWindow mainWindow;

		// Public static property to access the main window
		public static MainWindow MainWindow
		{
			get { return mainWindow; }
			private set { mainWindow = value; }
		}
		/// <summary>
		/// initialize the window that contain the entire app in MainWindow 
		/// 
		/// </summary>
		/// <param name="mainWindow"></param>
		public static void InitializeMainWindow(MainWindow mainWindow)
		{
			MainWindow = mainWindow;
		}
		/// <summary>
		/// load a page in the ContentControl bodyContent (at MainWindow)
		/// </summary>
		/// <typeparam name="Page">the type of the page that need to be loaded</typeparam>
		internal static void MoveToPage<Page>() where Page : new()
		{
			MainWindow.bodyContent.Content = new Page();
		}
	}
}
