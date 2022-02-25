using UIKit;

namespace XamarinMadridDemo.Services;

public class DeviceOrientationService3 : IDeviceOrientationService
{
    public DeviceOrientation GetOrientation()
    {
        UIInterfaceOrientation orientation = UIApplication.SharedApplication.StatusBarOrientation;
        bool isPortrait = orientation == UIInterfaceOrientation.Portrait || orientation == UIInterfaceOrientation.PortraitUpsideDown;
        return isPortrait ? DeviceOrientation.Portrait : DeviceOrientation.Landscape;
    }
}
