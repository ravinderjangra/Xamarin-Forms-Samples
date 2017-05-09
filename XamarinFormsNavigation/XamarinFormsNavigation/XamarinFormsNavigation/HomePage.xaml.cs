using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinFormsNavigation.View;

namespace XamarinFormsNavigation
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HomePage : ContentPage
    {
        public HomePage()
        {
            InitializeComponent();

            NavigationButton.Clicked += NavigatetoPage1;
            MVVMNavigationButton.Clicked += MVVMNavigationButton_Clicked;

        }

        private void MVVMNavigationButton_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Page4());
        }

        private void NavigatetoPage1(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Page1());
        }


    }
}
