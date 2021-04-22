using System.Text.RegularExpressions;
using System.Windows;

namespace REG
{
    public partial class MainWindow
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private bool IsNameValid()
        {
            Regex reg = new Regex("(^[A-Z][a-zA-Z]*)$");
            string text = txtName.Text;
            return reg.IsMatch(text);
        }

        private bool IsDoBValid()
        {
            Regex reg = new Regex(@"^([0-2][0-9]|(3)[0-1])[.](((0)[0-9])|((1)[0-2]))[.]\d{4}$");
            string text = txtDoB.Text;
            return reg.IsMatch(text);
        }

        private bool IsEmailValid()
        {
            Regex reg = new Regex(@"^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+(\.[a-zA-Z0-9-]+)+$");
            string text = txtEmail.Text;
            return reg.IsMatch(text);
        }

        private bool IsPhoneNrValid()
        {
            Regex reg = new Regex("^[0-9]{9}$");
            string text = txtPhone.Text;
            return reg.IsMatch(text);
        }

        private void btn_Check_Click(object sender, RoutedEventArgs e)
        {
            Name.Content = !IsNameValid() ? "Name : Bad" : "Name : Good";

            Dob.Content = !IsDoBValid() ? "Date of Birth : Bad" : "Date of Birth : Good";

            Email.Content = !IsEmailValid() ? "Email : Bad" : "Email : Good";

            Phone.Content = !IsPhoneNrValid() ? "Phone Number : Bad" : "Phone Number : Good";
        }
    }
}