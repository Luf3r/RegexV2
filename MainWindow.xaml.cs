using System.Windows;
using System.Text.RegularExpressions;

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

        private bool IsEmailVaild()
        {
            Regex reg = new Regex("^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+.[a-zA-Z0-9-.]+$");
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
            if (!IsNameValid())
            {
                Name.Content = "Name : Bad";
            }

            else
            {
                Name.Content = "Name : Good";
            }

            if (!IsDoBValid())
            {
                Dob.Content = "Date of Birth : Bad";
            }

            else
            {
                Dob.Content = "Date of Birth : Good";
            }

            if (!IsEmailVaild())
            {
                Email.Content = "Email : Bad";
            }

            else
            {
                Email.Content = "Email : Good";
            }

            if (!IsPhoneNrValid())
            {
                Phone.Content = "Phone Number : Bad";
            }

            else
            {
                Phone.Content = "Phone Number : Good";
            }
        }
    }
}
