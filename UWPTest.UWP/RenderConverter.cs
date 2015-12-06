using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Data;
using Xamarin.Forms;
using Xamarin.Forms.Platform.UWP;

namespace UWPTest.UWP {
    public class RenderConverter : Windows.UI.Xaml.Data.IValueConverter {
        public object Convert(object value, Type targetType, object parameter, string language) {
            var v = value as VisualElement;
            if (v == null)
                return value;
            else {
                var render = VisualElementExtensions.GetOrCreateRenderer((VisualElement)value);
                if (render != null) {
                    return render.ContainerElement;
                }
                return null;
            }

        }

        public object ConvertBack(object value, Type targetType, object parameter, string language) {
            throw new NotImplementedException();
        }
    }
}
