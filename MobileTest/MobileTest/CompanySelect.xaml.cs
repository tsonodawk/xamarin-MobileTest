using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace MobileTest
{
    public partial class CompanySelect : ContentPage
    {
        public CompanySelect()
        {
            InitializeComponent();
        }

        void OnClickToBack(object sender, EventArgs e)
        {
            // 前？画面に戻る
            Navigation.PopAsync(true);
        }

    }
}
