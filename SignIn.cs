using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WelcomeApp
{
    public class SignIn
    {
        public string Authenticate(string userName, string password)
        {
            string msg;
            if(string.IsNullOrEmpty(userName) || string.IsNullOrEmpty(password))
            {
                msg = "UserName and Password required";
            }
            else
            {
                if((userName == "admin") && (password == "admin@123"))
                {
                    msg = "Authentication Pass";
                }
                else
                {
                    msg = "Authentication Failed";
                }
            }
            return msg;
        }
    }
}
