using System;
using System.Collections.Generic;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MobileTestSyncF.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private void LoginButton_Clicked(object sender, System.EventArgs e)
        {
            // NavigationPageでの画面遷移(App.xaml.csの変更も必要)
            //Navigation.PushAsync(new MonthCalc(), true);
            Application.Current.MainPage = new MonthCalc();
        }

    }
}
