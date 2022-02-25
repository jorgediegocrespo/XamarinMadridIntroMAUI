namespace XamarinMadridDemo.Features;

public partial class OrientationView : ContentPage
{
	public OrientationView(OrientationViewModel viewModel)
	{
		BindingContext = viewModel;
		InitializeComponent();
	}
}