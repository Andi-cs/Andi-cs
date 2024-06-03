// Platforms/Windows/Handlers/CustomMapHandler.cs
#nullable disable
using Microsoft.Maui.Handlers;
using Microsoft.UI.Xaml.Controls;
using Windows.Devices.Geolocation;
using Windows.Storage.Streams;

namespace CustomMapsWindowsTest

{
    public partial class CustomMapHandler : ViewHandler<CustomMap, MapControl>
    {
        protected override MapControl CreatePlatformView()
        {
            return new MapControl();
        }
        protected override void ConnectHandler(MapControl platformView)
        {
            base.ConnectHandler(platformView);
            // Custom initialization if needed
        }
        public void AddCustomIcon(MapControl mapControl, string iconUri, BasicGeoposition location)
        {
            MapIcon x = new MapIcon();
           
             var mapIcon = new MapIcon
            {
                Image = RandomAccessStreamReference.CreateFromUri(new Uri(iconUri)),
                Location = new Geopoint(location),
                NormalizedAnchorPoint = new Windows.Foundation.Point(0.5, 1.0),
                ZIndex = 0
            };
            mapControl.MapElements.Add(mapIcon);
        }
    }
}

