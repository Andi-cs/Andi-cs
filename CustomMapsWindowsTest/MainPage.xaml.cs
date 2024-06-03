namespace CustomMapsWindowsTest
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
           
#if WINDOWS
            var handler = customMap.Handler as CustomMapHandler;
            var location = new Windows.Devices.Geolocation.Geopoint(new Windows.Devices.Geolocation.BasicGeoposition { Latitude = 47.6097, Longitude = -122.3331 });
            handler?.AddCustomIcon(handler.PlatformView as Microsoft.UI.Xaml.Controls.MapControl, "https://example.com/icon.png", location);
#endif
        }
    }

        
    }


