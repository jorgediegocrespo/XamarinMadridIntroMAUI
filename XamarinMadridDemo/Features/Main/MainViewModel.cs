using System.Windows.Input;

namespace XamarinMadridDemo.Features;

public class MainViewModel : BaseViewModel
{
    public MainViewModel(IServiceProvider serviceProvider) : base(serviceProvider)
    {
        OpenCounterCommand = new Command(OpenCounterAsync);
        OpenOrientationCommand = new Command(OpenOrientationAsync);
        OpenWindowCommand = new Command(OpenWindowAsync);
        OpenHandlersCommand = new Command(OpenHandlersAsync);
    }

    public ICommand OpenCounterCommand { get; set; }
    public ICommand OpenOrientationCommand { get; set; }
    public ICommand OpenWindowCommand { get; set; }
    public ICommand OpenHandlersCommand { get; set; }

    private async void OpenCounterAsync()
    {
        var view = serviceProvider.GetService<CounterView>();
        await Application.Current.MainPage.Navigation.PushAsync(view);
    }

    private async void OpenOrientationAsync()
    {
        var view = serviceProvider.GetService<OrientationView>();
        await Application.Current.MainPage.Navigation.PushAsync(view);
    }

    private async void OpenWindowAsync()
    {
        var view = serviceProvider.GetService<WindowsView>();
        await Application.Current.MainPage.Navigation.PushAsync(view);
    }

    private async void OpenHandlersAsync()
    {
        var view = serviceProvider.GetService<HandlersView>();
        await Application.Current.MainPage.Navigation.PushAsync(view);
    }
}
