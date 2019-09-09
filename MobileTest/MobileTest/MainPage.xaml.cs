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
    }
}
