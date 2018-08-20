using SmartHotel.Clients.Tizen.Renderers;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Tizen;

[assembly: ExportRenderer(typeof(Slider), typeof(CustomSliderRenderer))]
namespace SmartHotel.Clients.Tizen.Renderers
{
    public class CustomSliderRenderer : SliderRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Slider> e)
        {
            base.OnElementChanged(e);
        }
    }
}