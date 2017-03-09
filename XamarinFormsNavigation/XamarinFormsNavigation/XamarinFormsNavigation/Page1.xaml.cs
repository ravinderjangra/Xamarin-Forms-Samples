using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinFormsNavigation
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page1 : ContentPage
    {
        public Page1()
        {
            InitializeComponent();
            NavigationButton.Clicked += NavigationButton_Clicked;
        }

        private async void NavigationButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Page2(StringData.Text));
        }
    }
}
