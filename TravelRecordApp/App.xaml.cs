using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TravelRecordApp
{
    public partial class App : Application
    {
        //initialize database
        private static string DatabaseLocation = string.Empty; 
        
        //initialize database through constractor.
        public App(string databaselocaton)
        {
            InitializeComponent();

            MainPage = new NavigationPage(new MainPage());

            DatabaseLocation = databaselocaton;
        }



        //original app given by xamarin
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new MainPage());


        }



        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
