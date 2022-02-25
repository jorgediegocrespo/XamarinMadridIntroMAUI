using XamarinMadridDemo.Services;
using XamarinMadridDemo.Controls;
#if ANDROID
using Android.Content.Res;
using Microsoft.Maui.Controls.Compatibility.Platform.Android;
#endif
using Microsoft.Maui.Platform;


namespace XamarinMadridDemo;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
			});

		builder.Services.AddSingleton<IDeviceOrientationService, DeviceOrientationService1>();

		builder.Services.AddTransient<MainView>();
		builder.Services.AddTransient<MainViewModel>();
		builder.Services.AddTransient<CounterView>();
		builder.Services.AddTransient<CounterViewModel>();
		builder.Services.AddTransient<OrientationView>();
		builder.Services.AddTransient<OrientationViewModel>();
		builder.Services.AddTransient<WindowsView>();
		builder.Services.AddTransient<WindowsViewModel>();
		builder.Services.AddTransient<DetailWindowView>();
		builder.Services.AddTransient<DetailWindowViewModel>();
		builder.Services.AddTransient<HandlersView>();

		CreateHandlers();

		return builder.Build();
	}

	private static void CreateHandlers()
	{
		Microsoft.Maui.Handlers.EntryHandler.EntryMapper.AppendToMapping(nameof(IView.Background), (handler, view) =>
		{
			if (view is CustomEntry)
			{
#if ANDROID
				handler.NativeView.SetBackgroundColor(Colors.Red.ToAndroid());
#elif IOS
                  handler.NativeView.BackgroundColor = Colors.Red.ToNative();
                  handler.NativeView.BorderStyle = UIKit.UITextBorderStyle.Line;
#elif WINDOWS
                  handler.NativeView.Background = Colors.Red.ToNative();
#endif
			}
		});
	}
}
