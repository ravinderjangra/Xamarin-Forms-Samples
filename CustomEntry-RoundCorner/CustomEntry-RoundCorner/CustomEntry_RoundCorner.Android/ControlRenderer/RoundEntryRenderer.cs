using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Xamarin.Forms;
using CustomEntry_RoundCorner.CustomControls;
using Xamarin.Forms.Platform.Android;
using CustomEntry_RoundCorner.Droid.ControlRenderer;
using Android.Graphics.Drawables;
using Android.Text;

[assembly: ExportRenderer(typeof(RoundEntry), typeof(RoundEntryRenderer))]
namespace CustomEntry_RoundCorner.Droid.ControlRenderer
{
	public class RoundEntryRenderer : EntryRenderer
	{
		protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
		{
			base.OnElementChanged(e);

			if (Control != null)
			{
				GradientDrawable gd = new GradientDrawable();
				// increase or decrease to changes the corner 
				gd.SetCornerRadius(30);
				//Control.Background = gd;
				Control.Background = Resources.GetDrawable(Resource.Drawable.RoundedEntry);
				//Control.SetBackgroundDrawable(gd);
			}
		}
	}
}