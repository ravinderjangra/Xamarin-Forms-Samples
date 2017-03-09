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
    public partial class Page2 : ContentPage
    {
        public Page2(string parameter)
        {
            InitializeComponent();
            StringData.Text = "Text from Page1 : " +  parameter;
            NavigationButton.Clicked += NavigationBack;
            
        }

        private async void NavigationBack(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }
    }
}
