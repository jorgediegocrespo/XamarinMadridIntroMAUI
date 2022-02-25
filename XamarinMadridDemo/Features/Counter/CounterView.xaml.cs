namespace XamarinMadridDemo.Features;

public partial class CounterView : ContentPage
{
    private int counter;

    public CounterView(CounterViewModel viewModel)
	{
		BindingContext = viewModel;
		InitializeComponent();
        counter = 0;
        buttonTest.Clicked += ButtonTest_Clicked;
	}

    private void ButtonTest_Clicked(object sender, EventArgs e)
    {
        counter += 2;
        lbCounter.Text = counter.ToString();   
    }
}