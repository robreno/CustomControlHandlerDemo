#if ANDROID
using Android.Content.Res;
using Microsoft.Maui.Controls.Compatibility.Platform.Android;
using Microsoft.Maui.Handlers;
#endif

namespace CustomControlHandlerDemo;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

        // See Gerald Vesluis: https://youtu.be/k6Zk3Ho8YNw and https://youtu.be/_9dz7BUoxT8
        // Method 1
//        Microsoft.Maui.Handlers.EntryHandler.Mapper.AppendToMapping("NoUnderline", (handler, view) =>
//        {
//#if ANDROID
//            handler.PlatformView.BackgroundTintList = ColorStateList.ValueOf(Colors.Transparent.ToAndroid());
//#endif
//        });

        MainPage = new AppShell();
	}
}
