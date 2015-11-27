using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Media;

namespace UWPTest.UWP {
    internal static class Helper {
        public static Brush ToBrush(this Xamarin.Forms.Color color) {
            return new SolidColorBrush(color.ToMediaColor());
        }

        public static Color ToMediaColor(this Xamarin.Forms.Color color) {
            return Color.FromArgb((byte)(color.A * 255), (byte)(color.R * 255), (byte)(color.G * 255), (byte)(color.B * 255));
        }

        public static Thickness ToWinPhone(this Xamarin.Forms.Thickness t) {
            return new Thickness(t.Left, t.Top, t.Right, t.Bottom);
        }
    }
}
