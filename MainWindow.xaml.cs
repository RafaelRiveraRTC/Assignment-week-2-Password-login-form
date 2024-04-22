// Rafael Rivera Harrison
// 4.19.2024
// Programming 122
//Assignment 2 Password login form


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

namespace Assignment_week_2_Password_login_form
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        //Have the values userName and passowrd inside the partial class so they can be refrenced anywhere in the cs file
        string userName;

        string password;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void signUpHere_Click(object sender, RoutedEventArgs e)
        {
            //String username and password are the name values that represent
            //what ever the user inputs into the respective boxes
            //total info will display both username and password info


            userName = userNameInfo.Text;

            password = PasswordInfo.Password;

            string totalInfo = $"Thank You for signing in.  Username: {userName} Password: {password}";


            if (string.IsNullOrEmpty(userName) || string.IsNullOrEmpty(password))
            {

                //if the password box or the username is empty,it will display the following message
                MessageBox.Show("I'm sorry this isn't enough info availible,please try again");
                runDisplay.Text = "I'm sorry this isn't enough info availible,please try again";
                userNameInfo.Clear();
                PasswordInfo.Clear();
            }
            else if (userName.Length < 8 || password.Length < 8)
            {
                //if the password bpx or username is below the specified length the following message will display
                MessageBox.Show("This Password or Username is not long enough please try again");
                runDisplay.Text = "This Password or Username is not long enough please try again";
                userNameInfo.Clear();
                PasswordInfo.Clear();
            }
            else
            {
                //if it succeds the first 2 checks the input from the user will display inside the rich text box
                MessageBox.Show($"Thank You for signing up.  Username: {userName} Password: {password} ");
                runDisplay.Text = totalInfo;

                userNameInfo.Clear();
                PasswordInfo.Clear();
            }
        }

        private void Login_Here_Click(object sender, RoutedEventArgs e)
        {
            //these will also access the text boxes,but they will be used to compare to the orignal names in the partial clas
            string userNameVerify = userNameInfo.Text;
            string passwordVerify = PasswordInfo.Password;



            if (string.IsNullOrEmpty(userName) || string.IsNullOrEmpty(password))
            {
                //if the password box or the username is empty,it will display the following message
                MessageBox.Show("I'm sorry this isn't enough info availible,please try again");
                runDisplay.Text = "I'm sorry this isn't enough info availible,please try again";
                userNameInfo.Clear();
                PasswordInfo.Clear();
            }
            else if (userNameVerify != userName || passwordVerify != password)
            {
                //if the password bpx or username does not match the usernameverify or the password verify this code block will run
                MessageBox.Show("This Password or Username does not match the previous values,please try again");
                runDisplay.Text = "This Password or Username does not match try again please";
                userNameInfo.Clear();
                PasswordInfo.Clear();
            }
            else
            {
                //this else statement will run only if the first two if statements above do not run
                MessageBox.Show($"Thank You for signing in.  Username: {userName} Password: {password}  ");
                runDisplay.Text = $"Welcome {userName} Your password is {password}";
                userNameInfo.Clear();
                PasswordInfo.Clear();
            }
        }

        //The purpose of the devlopers notes is to display any changes that are made throught the code so i can verify
        //and check to make sure everything is working
        //as required

    }
}