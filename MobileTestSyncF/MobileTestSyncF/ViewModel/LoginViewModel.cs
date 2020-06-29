using System;
using MobileTestSyncF.Models;

namespace MobileTestSyncF.ViewModel
{
 
    public class LoginViewModel
    {
        private LoginInfo loginInfo;

        public LoginInfo LoginInfo
        {
            get { return this.loginInfo; }
            set { this.loginInfo = value; }
        }

        public LoginViewModel()
        {
            this.loginInfo = new LoginInfo();
        }
    }
}
