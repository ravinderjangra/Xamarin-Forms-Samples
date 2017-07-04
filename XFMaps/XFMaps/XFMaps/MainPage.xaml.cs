using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Maps;

namespace XFMaps
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            var map = new Map(
                MapSpan.FromCenterAndRadius(
                new Position(28, 77), Distance.FromMiles(0.3)))
                    {
                        IsShowingUser = true,
                        HeightRequest = 100,
                        WidthRequest = 960,
                        VerticalOptions = LayoutOptions.FillAndExpand
                    };

            var slider = new Slider(1, 18, 1);
            slider.ValueChanged += (sender, e) => {
                var zoomLevel = e.NewValue; // between 1 and 18
                var latlongdegrees = 360 / (Math.Pow(2, zoomLevel));
                map.MoveToRegion(new MapSpan(map.VisibleRegion.Center, latlongdegrees, latlongdegrees));
            };

            var stack = new StackLayout { Spacing = 0 };
            stack.Children.Add(map);
            stack.Children.Add(slider);
            Content = stack;
        }
    }
}
