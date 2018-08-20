using System;
using System.ComponentModel;
using SmartHotel.Clients.Core.Controls;
using SmartHotel.Clients.Tizen.Renderers;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Tizen;
using Cadenza.Collections;

[assembly: ExportRenderer(typeof(CalendarButton), typeof(CalendarButtonRenderer))]
namespace SmartHotel.Clients.Tizen.Renderers
{
    public class CalendarButtonRenderer : ButtonRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Button> e)
        {
            base.OnElementChanged(e);
        }

        protected override void OnElementPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            base.OnElementPropertyChanged(sender, e);
        }
    }
}