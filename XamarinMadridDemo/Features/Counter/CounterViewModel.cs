namespace XamarinMadridDemo.Features;

public class CounterViewModel : BaseViewModel
{
    private int counter;

    public CounterViewModel(IServiceProvider serviceProvider) : base(serviceProvider)
    {
        counter = 0;
        CountCommand = new Command(Count);
    }

    public int Counter
    {
        get => counter;
        private set
        {
            counter = value;
            OnPropertyChanged(nameof(Counter));
        }
    }

    public ICommand CountCommand { get; set; }

    private void Count()
    {
        Counter= Counter + 10;
    }
}
