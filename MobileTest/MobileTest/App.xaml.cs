using System;
using System.IO;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using MobileTest.Data;

namespace MobileTest
{
    public partial class App : Application
    {
        static MobileTestDatabase database;

        public static MobileTestDatabase Database
        {
            get
            {
                if (database == null)
                {
                    database = new MobileTestDatabase(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "MobileTest.db3"));
                    //database = new MobileTestDatabase(Path.Combine("/Users/flat9th/GitRepos/github-tsonodawk/xamarin/MobileTest/MobileTest/MobileTest", "MobileTest.db3"));
                }
                return database;
            }
        }

        public App()
        {
            InitializeComponent();

            //MainPage = new MainPage();
            MainPage = new NavigationPage(new MobileTest.MainPage());
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
