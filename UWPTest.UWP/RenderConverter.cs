using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Data;
using Xamarin.Forms.Platform.UWP;

namespace UWPTest.UWP {
    public class RenderConverter : IValueConverter {
        public object Convert(object value, Type targetType, object parameter, string language) {
            if (value == null)
                return null;

            var render = Platform.GetRenderer((Xamarin.Forms.VisualElement)value);
            //((Xamarin.Forms.VisualElement)value).Layout(new Xamarin.Forms.Rectangle(0, 0, 300, 300));
            return render.ContainerElement;
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language) {
            throw new NotImplementedException();
        }
    }
}
