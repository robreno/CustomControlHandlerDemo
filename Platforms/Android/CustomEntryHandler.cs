using Android.Content.Res;
using Microsoft.Maui.Controls.Compatibility.Platform.Android;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomControlHandlerDemo
{
    // See: https://youtu.be/_9dz7BUoxT8?t=900
    // Method 3
    // Andriod Platform Code
    public partial class CustomEntryHandler
    {
        static partial void CustomHandler()
        {
            Microsoft.Maui.Handlers.EntryHandler.Mapper.AppendToMapping("NoUnderline", (handler, view) =>
            {
                handler.PlatformView.BackgroundTintList = ColorStateList.ValueOf(Colors.Transparent.ToAndroid());
            });
        }
    }
}
