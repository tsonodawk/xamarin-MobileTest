using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MobileTest
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        void OnSaveButtonClicked(object sender, EventArgs e)
        {
            //TODO: 保存ボタンの処理
        }

        void OnDeleteButtonClicked(object sender, EventArgs e)
        {
            //TODO: 削除ボタンの処理
        }

        void OnClickToLogin(object sender, EventArgs e)
        {
            // 新しいページを開くが戻るボタンはアプリが終了する感じっぽい
            //Application.Current.MainPage = new Login();

            // NavigationPageでの画面遷移(App.xaml.csの変更も必要)
            Navigation.PushAsync(new Login(), true);
        }
    }
}
