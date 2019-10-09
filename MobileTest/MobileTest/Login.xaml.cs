using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace MobileTest
{
    public partial class Login : ContentPage
    {
        public Login()
        {
            InitializeComponent();
        }

        void OnClickToCompanySelect(object sender, EventArgs e)
        {
            //TODO:画面の入力値を取得する
            var companyId = this.companyId.Text;
            var userId = this.userId.Text;
            var passwd = this.passwd.Text;

            var userData = App.Database.GetUserLoginAsync(companyId, userId, passwd);
            // NavigationPageでの画面遷移(App.xaml.csの変更も必要)
            Navigation.PushAsync(new CompanySelect(), true);
        }

        void OnClickToMainPage(object sender, EventArgs e)
        {
            // 前？画面に戻る
            Navigation.PopAsync(true);
        }
    }
}
