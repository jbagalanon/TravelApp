using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TravelRecordApp
{
    public partial class App : Application
    {
        //initialize database - suposedly private
        public static string DatabaseLocation = string.Empty;

        //original app given by xamarin
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new MainPage());


        }

        //initialize database through constractor.
        public App(string databaseLocation)
        {
            InitializeComponent();

            MainPage = new NavigationPage(new MainPage());

            DatabaseLocation = databaseLocation;
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
