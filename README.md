# ExamsPlatform.ClientWPF
Hello, i'm Arni Izhack, and this is the client side of my ExamsPlatform project.
you can contact me by phone 054-4892517, or by mail 19920@gmail.com.

## Project Purpose
The ExamsPlatform.ClientWPF application is designed to provide a user-friendly interface for managing exams. Users can sign in, navigate through different
pages, create exams, take exams, etc.

## MainWindow.xaml + MainWindow.xaml.cs
MainWindow.xaml is the only window in my project, it is made of a table with 3 rows:
1. menu row will contain the menu for the current user type.
2. content row will contain the pages.
3. footer will hold some general information, currently only my information.

MainWindow()
1. initialize a reference of MainWindow in a static object that will be accesed fron the entire app. 
2. load SignInPage.
//  TODO - 1. set DataContext. 2. load menu according to changes of the user type.

# MENUS

## NoUserMenu.xaml +NoUserMenu.xaml.cs
NoUserMenu.xaml is the menu that will be displayed for users that didn't sign in.
NoUserMenu.xaml contain 3 items:
1. home - load home page in the content row at MainMenu.
2. sign in - load sign in page in the content row at MainMenu.
3. sign up - load sign up page in the content row at MainMenu.

## MenuForTeacher.xaml + MenuForTeacher.xaml.cs
MenuForTeacher will be displayed for teachers, it got 6 items :
1. options - still not implemented. TODO - allow the user to change the view of the app, text size, dark/bright mode, atc.
2-5. buttons that will load pages : home, exams, create new exam and calendar.
6. sign out - still not implemented. TODO - sign the user out and load SignInPage.

# PAGES

## HomePage.xaml

## SignInPage.xaml

## SignUpPage.xaml

## ExamsPage.xaml

## CreateNewExamPage.xaml

## CalendarPage.xaml

# HELPERS

## AppHelpers.cs
the AppHelpers class will contain methods and properties, that will be used from any point of this project.
for now AppHelper contain only 3 things, a property and 2 methods.
1. MainWindow - a privet static property that will hold an instance of the window that contain the entire view of app.
2. InitializeMainWindow(MainWindow) - the MainWindow property will be Initialize by this method.
3. MoveToPage<Page>() - load a page in the ContentControl bodyContent (at MainWindow)
