﻿using ExamsPlatform.ClientWPF.Helpers;
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
	/// Interaction logic for MenuForTeacher.xaml
	/// </summary>
	public partial class MenuForTeacher : UserControl
	{
		public MenuForTeacher()
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
		/// load CreateNewExamPage in the ContentControl bodyContent (at MainWindow)
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void GoToCreateNewExamPage(object sender, RoutedEventArgs e)
		{
			AppHelpers.MoveToPage<CreateNewExamPage>();
		}
		/// <summary>
		/// load CalendarPage in the ContentControl bodyContent (at MainWindow)
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void GoToCalendarPage(object sender, RoutedEventArgs e)
		{
			AppHelpers.MoveToPage<CalendarPage>();
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
