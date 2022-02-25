using System.Windows.Input;

namespace XamarinMadridDemo.Features;

public class WindowsViewModel : BaseViewModel
{
    public WindowsViewModel(IServiceProvider serviceProvider) : base(serviceProvider)
    {
        OpenWindowCommand = new Command(OpenWindowAsync);
    }

    public ICommand OpenWindowCommand { get; set; }

    private async void OpenWindowAsync()
    {
        var view = serviceProvider.GetService<DetailWindowView>();
        Application.Current.OpenWindow(new Window(view));
        await Task.CompletedTask;
    }
}
