using System;
using SmartHotel.Clients.Core.Models;
using SmartHotel.Clients.Core.Controls;
using SmartHotel.Clients.Tizen.Renderers;
using System.ComponentModel;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Tizen;
using Xamarin.Forms.Maps;
using Xamarin.Forms.Maps.Tizen;
using TPin = Tizen.Maps.Pin;
using Tizen.Location;
using Tizen.Maps;

[assembly: ExportRenderer(typeof(CustomMap), typeof(CustomMapRenderer))]
namespace SmartHotel.Clients.Tizen.Renderers
{
    public class CustomMapRenderer : MapRenderer
    {
        private bool _isDrawnDone = false;

        protected override void OnElementChanged(ElementChangedEventArgs<Map> e)
        {
            base.OnElementChanged(e);
        }

        protected override void OnElementPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            base.OnElementPropertyChanged(sender, e);

            if (e.PropertyName.Equals("CustomPins") && !_isDrawnDone)
            {
                CustomMap maps = Element as CustomMap;
                foreach (CustomPin customPin in maps.CustomPins)
                {
                    var coordinates = new Geocoordinates(customPin.Position.Latitude, customPin.Position.Longitude);
                    var nativePin = new TPin(coordinates);
                    //nativePin.ImagePath = customPin.Type == SuggestionType.Restaurant ? "pushpin_02.png" : "pushpin_01.png";
                    nativePin.Clicked += (s, ea) => { };

                    Control.Add(nativePin);
                }
                _isDrawnDone = true;
            }
        }

        void PinOnPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            Xamarin.Forms.Maps.Pin pin = (Xamarin.Forms.Maps.Pin)sender;
            var nativePin = pin.Id as TPin;
            if (nativePin == null)
            {
                return;
            }

            //There is no corressponding native control propery for Label and Address.
            if (e.PropertyName == Xamarin.Forms.Maps.Pin.PositionProperty.PropertyName)
            {
                nativePin.Coordinates = new Geocoordinates(pin.Position.Latitude, pin.Position.Longitude);
            }
        }

    }
}