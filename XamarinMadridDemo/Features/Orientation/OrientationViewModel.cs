using System.Windows.Input;
using XamarinMadridDemo.Services;

namespace XamarinMadridDemo.Features;

public class OrientationViewModel : BaseViewModel
{
    private readonly IDeviceOrientationService deviceOrientationService;
    private string orientation;

    public OrientationViewModel(
        IServiceProvider serviceProvider, 
        IDeviceOrientationService deviceOrientationService) : base(serviceProvider)
    {
        this.deviceOrientationService = deviceOrientationService;
        FindOutOrientationCommand = new Command(FindOutOrientation);
    }

    public string Orientation
    {
        get => orientation;
        set
        {
            orientation = value;
            OnPropertyChanged(nameof(Orientation));
        }
    }

    public ICommand FindOutOrientationCommand { get; set; }

    private void FindOutOrientation()
    {
        Orientation = deviceOrientationService.GetOrientation().ToString();
    }
}
