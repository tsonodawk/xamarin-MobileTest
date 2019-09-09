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
