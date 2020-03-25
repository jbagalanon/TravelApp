﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Plugin.Geolocator;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Maps;
using Xamarin.Forms.Xaml;

namespace TravelRecordApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MapPage : ContentPage
    {
        public MapPage()
        {
            InitializeComponent();
        }

  
        // this is the old code - protected override void OnAppearing()
        protected async override void OnAppearing()
        {
            base.OnAppearing();
            
            //this is the original file
             var locator = CrossGeolocator.Current;
             locator.PositionChanged += Locator_PositionChanged;
             await locator.StartListeningAsync(new TimeSpan(0), 100);

             var position = await locator.GetPositionAsync();

             var center = new Xamarin.Forms.Maps.Position(position.Latitude, position.Longitude);
             var span = new Xamarin.Forms.Maps.MapSpan(center,2,2);
            locationsMap.MoveToRegion(span);

        }

        private void Locator_PositionChanged(object sender, Plugin.Geolocator.Abstractions.PositionEventArgs e)
        {
            var center = new Xamarin.Forms.Maps.Position(e.Position.Latitude, e.Position.Longitude);
            var span = new Xamarin.Forms.Maps.MapSpan(center, 2, 2);
            locationsMap.MoveToRegion(span);

        }
      
    }
}

