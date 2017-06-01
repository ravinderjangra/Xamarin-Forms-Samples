using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace XFBehaviours
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            AttachedBehaviorButton.Clicked += NavigatetoAttachedBehaviorPage;
            XFAttachedBehaviorButton.Clicked += NavigatetoXFAttachedBehaviorPage;
            XFEffectBehaviorButton.Clicked += (s, e) =>
            {
                Navigation.PushAsync(new EffectBehavior());
            };
        }

        private void NavigatetoXFAttachedBehaviorPage(object sender, EventArgs e)
        {
            Navigation.PushAsync(new XFBehavior());
        }

        private void NavigatetoAttachedBehaviorPage(object sender, EventArgs e)
        {
            Navigation.PushAsync(new AttachedBehaviour());
        }
    }
}
