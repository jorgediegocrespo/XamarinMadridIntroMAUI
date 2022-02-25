using System.Windows.Input;

namespace XamarinMadridDemo.Features;

public class DetailWindowViewModel : BaseViewModel
{
    public DetailWindowViewModel(IServiceProvider serviceProvider) : base(serviceProvider)
    {
        CloseWindowCommand = new Command(CloseWindow);
    }

    public ICommand CloseWindowCommand { get; set; }

    private void CloseWindow()
    {
        Application.Current.CloseWindow(Application.Current.Windows.First(x => x.Page.BindingContext == this));
    }
}
