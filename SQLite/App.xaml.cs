using System;
using SQLite.Data;
using SQLite.Services;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SQLite
{
    public partial class App : Application
    {
        private static FriendsDB _dataBase;
        public static FriendsDB DataBase
        {
            get
            {
                if (_dataBase == null)
                {
                    _dataBase = new FriendsDB(DependencyService.Get<IFileHelpers>().GetLocalFilePath("fileFriend.db3"));
                }
                return _dataBase;
            }
        }



        public App()
        {
            InitializeComponent();

            MainPage = new MainPage();
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
