# ExamsPlatform.ClientWPF
Hello, i'm Arni Izhack, and this is the client side of my ExamsPlatform project.
you can contact me by phone 054-4892517, or by mail 19920@gmail.com.

## Project Purpose
The ExamsPlatform.ClientWPF application is designed to provide a user-friendly interface for managing exams. Users can sign in, navigate through different
pages, create exams, take exams, etc.

### MainWindow.xaml + MainWindow.xaml.cs
MainWindow.xaml is the only window in my project, it is made of a table with 3 rows:
1. menu row will contain the menu for the current user type.
2. content row will contain the pages.
3. footer will hold some general information, currently only my information.

MainWindow()
1. initialize a reference of MainWindow in a static object that will be accesed fron the entire app. 
2. load SignInPage.
//  TODO - 1. set DataContext. 2. load menu according to changes of the user type.


## MENUS

### NoUserMenu.xaml +NoUserMenu.xaml.cs
NoUserMenu.xaml is the menu that will be displayed for users that didn't sign in.
NoUserMenu.xaml contain 3 items:
1. home - load home page in the content row at MainMenu.
2. sign in - load sign in page in the content row at MainMenu.
3. sign up - load sign up page in the content row at MainMenu.

### MenuForTeacher.xaml + MenuForTeacher.xaml.cs
MenuForTeacher will be displayed for teachers, it got 6 items :
1. options - still not implemented. TODO - allow the user to change the view of the app, text size, dark/bright mode, atc.
2. sign out - still not implemented. TODO - sign the user out and load SignInPage.
3. 4 buttons that will load pages : home, exams, create new exam and calendar.

### MenuForStudent.xaml + MenuForStudent.xaml.cs
MenuForStudent will be displayed for students, it got 6 items :
1. options - still not implemented. TODO - allow the user to change the view of the app, text size, dark/bright mode, atc.
2. sign out - still not implemented. TODO - sign the user out and load SignInPage.
3. 4 buttons that will load pages : home, exams, start an exam and calendar.


## PAGES

### HomePage.xaml

### SignInPage.xaml

### SignUpPage.xaml

### ExamsPage.xaml

### CreateNewExamPage.xaml

### CalendarPage.xaml

### StartAnExam.xaml


## ViewModels

### ModelVM.cs
ModelVM is the base class for any view model, it contain methods and property relevents for any ViewModle.
PropertyChanged  - handle updating the GUI when a bound property changes.
OnPropertyChanged - invoke 'PropertyChanged' event when a property is changed.

### UserVM.cs
UserVM is the View model connecting the GUI and an instance of 'User' class.
fields and properties :
'User' hold an instance of the 'User' class.
'Id', 'UserId', 'FirstName', 'LastName', 'Email', 'PhoneNumber', 'Password', 'UserType'. These properties provide access to the corresponding fields in the
User object. The get accessor retrieves the value from the User object, while the set accessor updates the User object and refreshes the GUI.
constructors:
1. A parameterless constructor initializes a new 'User' object.
2. A constructor that takes a 'User' object as a parameter and sets the 'User' property.


## Models

### User.cs
User represent the user information model.
fields :
'Id' (Primary Key): The unique identifier for the user.
'UserId': User's identification number.
'FirstMame', 'LastName',  'Email', 'PhoneNumber', 'Password', 'UserType' : basic user information.
'ExamsNames'- a list of exams names related to the user.
constructors :
1. A default constructor sets default values: empty strings for textual fields, 'NoType' for 'UserType', and a new list for 'ExamsNames'.
2. A constructor initalize all fields exept for the primery key 'Id'.
methods :
GetFullName - asynchronous method that returns the full name of the user.


## HELPERS

### AppHelpers.cs
the AppHelpers class will contain methods and properties, that will be used from any point of this project.
for now AppHelper contain only 3 things, a property and 2 methods.
1. MainWindow - a privet static property that will hold an instance of the window that contain the entire view of app.
2. InitializeMainWindow(MainWindow) - the MainWindow property will be Initialize by this method.
3. MoveToPage<Page>() - load a page in the ContentControl bodyContent (at MainWindow)


### Enums.cs
enums will contain all the enums requied for this project.
UserType - an enumeration with 3 values :
1. Teacher.
2. Student.
3. NOTYPE

