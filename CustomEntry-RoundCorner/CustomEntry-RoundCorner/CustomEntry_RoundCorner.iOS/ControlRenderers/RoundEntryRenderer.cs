using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Foundation;
using UIKit;
using Xamarin.Forms;
using CustomEntry_RoundCorner.CustomControls;
using CustomEntry_RoundCorner.iOS.ControlRenderers;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(RoundEntry), typeof(RoundEntryRenderer))]
namespace CustomEntry_RoundCorner.iOS.ControlRenderers
{
	class RoundEntryRenderer : EntryRenderer
	{
		protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
		{
			base.OnElementChanged(e);

			if(Control!=null)
			{
				Control.Layer.CornerRadius = 15;
			}
		}
	}
}