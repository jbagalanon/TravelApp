using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;
using TravelRecordApp.Model;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TravelRecordApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HistoryPage : ContentPage
    {
        public HistoryPage()
        {
            InitializeComponent();
        }
        //method override. this is the place where display information of  history page appear
        protected override void OnAppearing()
        {
            base.OnAppearing();

            using (SQLiteConnection conn = new SQLiteConnection(App.DatabaseLocation))
            {
                // these are generics method   conn.CreateTable<Post>(),conn.Table<Post>()

                conn.CreateTable<Post>();
                var posts = conn.Table<Post>().ToList();

                postListView.ItemsSource = posts;
            }
        }
    }
}