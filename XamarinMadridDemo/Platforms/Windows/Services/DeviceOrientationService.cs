namespace XamarinMadridDemo.Services;

public class DeviceOrientationService2 : IDeviceOrientationService
{
    public DeviceOrientation GetOrientation()
    {
        return DeviceOrientation.Landscape;
    }
}
