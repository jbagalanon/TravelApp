using System;
using System.Collections.Generic;
using System.Data;
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
    public partial class NewTravelPage : ContentPage
    {
        public NewTravelPage()
        {
            InitializeComponent();
        }

        private void ToolbarItem_Clicked(object sender, EventArgs e)
        {
            //post is an object type
            Post post = new Post()
            {
                Experience = experienceEntry.Text
            }
            ;
            using (SQLiteConnection conn = new SQLiteConnection(App.DatabaseLocation))
            {

                //this is generic type - conn.CreateTable<Post>();
                conn.CreateTable<Post>();
                int rows = conn.Insert(post);

                if (rows > 0)
                    DisplayAlert("Success", "Experience Successfully Inserted", "Ok");
                else
                    DisplayAlert("Insert Failed", " No data inserted", "Ok");
            }
        }

    }
}