using MyBikesFactory.Business.Delegates;
using MyBikesFactory.Business.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBikesFactory.Business
{
    public class User : IValidatable
    {
        private string _username;
        private string _password;
        private string _invalidMessage;

        public event Notify GotInvalidNotification;

        public string Username { get => _username; set => _username = value; }
        public string Password { get => _password; set => _password = value; }
        public string InvalidMessage
        {
            get => _invalidMessage;
            set => _invalidMessage = value;
        }

        public User(string initialUsername, string initialPassword)
        {
            _username = initialUsername;
            _password = initialPassword;
        }

        public bool IsValid()
        {
            if (_username == "")
            {
                CallGotInvalidNotification("Please inform a username");
                return false;
            }
            else if (_password == "")
            {
                CallGotInvalidNotification("Please inform a password");
                return false;
            }
            return true;
        }
        private void CallGotInvalidNotification(string message)
        {
            _invalidMessage = message;
            GotInvalidNotification(message);
        }

    }
}
