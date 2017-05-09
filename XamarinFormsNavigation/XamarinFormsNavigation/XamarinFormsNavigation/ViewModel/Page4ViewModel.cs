using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace XamarinFormsNavigation.ViewModel
{
    class Page4ViewModel
    {
        INavigation _navigation;
        public ICommand NavigatetoHome { get; set; }

        public Page4ViewModel(INavigation navigation)
        {
            _navigation = navigation;

            NavigatetoHome = new Command(() =>
            {
                _navigation.PopAsync();
            });

            //For Navigation use
            //_navigation.PushAsync(new Page5());
        }


    }
}
