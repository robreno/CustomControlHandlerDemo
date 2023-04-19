using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomControlHandlerDemo
{
    // See: https://youtu.be/_9dz7BUoxT8?t=860
    // Method 3
    // Shared Code
    public partial class CustomEntryHandler
    {
        public static void Handle()
        {
            CustomHandler();
        }

        static partial void CustomHandler();
    }
}
