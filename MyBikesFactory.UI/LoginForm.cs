using MyBikesFactory.Business;
using MyBikesFactory.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyBikesFactory.UI
{
    public partial class LoginForm : Form
    {
        private List<User> listOfUsers = UserSequentialData.Load();

        public LoginForm()
        {
            InitializeComponent();
        }

        

        private void User_GotInvalidNotification(string message)
        {
            MessageBox.Show(message);
        }

        private void cbPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (cbPassword.Checked)
            {
                txtPassword.PasswordChar = '\0';
            }
            else
                txtPassword.PasswordChar = '*';
        }

        private void btnLogin_Click_1(object sender, EventArgs e)
        {
            var myUser = new User(txtUserName.Text, txtPassword.Text);
            myUser.GotInvalidNotification += User_GotInvalidNotification;

            //if (!myUser.IsValid())
            if (!Validator.CheckValidity(myUser))
                return;

            bool existingUser = false;
            foreach (var user in listOfUsers)
            {
                if (user.Username == txtUserName.Text && user.Password == txtPassword.Text)
                {
                    existingUser = true;
                    break;
                }
            }

            if (existingUser)
            {
                txtUserName.Text = "";
                txtPassword.Text = "";
                var mainForm = new MainForm(this);
                mainForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid username or password");
            }
        }
    }
}
