using Android.App;
using Android.Content.PM;
using Android.OS;

// Added cstor and usings for custom code
//using Android.Content.Res;
//using Microsoft.Maui.Controls.Compatibility.Platform.Android;

namespace CustomControlHandlerDemo;

[Activity(Theme = "@style/Maui.SplashTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation | ConfigChanges.UiMode | ConfigChanges.ScreenLayout | ConfigChanges.SmallestScreenSize | ConfigChanges.Density)]
public class MainActivity : MauiAppCompatActivity
{
    // Method 2
    //public MainActivity()
    //{
    //    Microsoft.Maui.Handlers.EntryHandler.Mapper.AppendToMapping("NoUnderline", (handler, view) =>
    //    {
    //        handler.PlatformView.BackgroundTintList = ColorStateList.ValueOf(Colors.Transparent.ToAndroid());
    //    });
    //}
}
