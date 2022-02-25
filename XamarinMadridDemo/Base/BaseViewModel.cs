using System.ComponentModel;

namespace XamarinMadridDemo.Base;

public class BaseViewModel : INotifyPropertyChanged
{
    protected readonly IServiceProvider serviceProvider;

    public BaseViewModel(IServiceProvider serviceProvider)
    {
        this.serviceProvider = serviceProvider;
    }

    public event PropertyChangedEventHandler PropertyChanged;

    protected virtual void OnPropertyChanged(string propertyName)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}
