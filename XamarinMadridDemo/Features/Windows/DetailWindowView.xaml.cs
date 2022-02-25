namespace XamarinMadridDemo.Features;

public partial class DetailWindowView : ContentPage
{
	public DetailWindowView(DetailWindowViewModel viewModel)
	{
		BindingContext = viewModel;
		InitializeComponent();
	}
}