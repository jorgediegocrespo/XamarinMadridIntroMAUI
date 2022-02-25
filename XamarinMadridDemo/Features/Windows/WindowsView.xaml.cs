namespace XamarinMadridDemo.Features;

public partial class WindowsView : ContentPage
{
	public WindowsView(WindowsViewModel viewModel)
	{
		BindingContext = viewModel;
		InitializeComponent();
	}
}