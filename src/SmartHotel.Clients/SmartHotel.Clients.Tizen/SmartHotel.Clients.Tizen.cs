using System;
using Plugin.Settings.Abstractions;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Tizen;
using Acr.UserDialogs;
using FFImageLoading.Forms.Platform;
using CarouselView.FormsPlugin.Tizen;
using ElmSharp;
using TAppication = Tizen.Applications;

namespace SmartHotel.Clients.Tizen
{
    class Program : global::Xamarin.Forms.Platform.Tizen.FormsApplication
    {
        protected override void OnCreate()
        {
            base.OnCreate();
            Utility.AppendGlobalFontPath(TAppication.Application.Current.DirectoryInfo.Resource);
            LoadApplication(new App());
        }

        static void Main(string[] args)
        {
            var app = new Program();
            try
            {
                // Call 'LoadApplication(Application application)' here to load your application.
                //global::Acr.UserDialogs.UserDialogs.Init(this);
                Xamarin.FormsMaps.Init("HERE", "pE-W9LeqN7zB9RtnwgBN/tZuCgj-LtWQ4RWN56XrVpA");
                CarouselViewRenderer.Init();
                CachedImageRenderer.Init(app);
                global::Xamarin.Forms.Platform.Tizen.Forms.Init(app, true);
            }
            catch (Exception e) {
                Log.Error("Enter Exception "+e);
            }
            app.Run(args);
        }
    }
}
