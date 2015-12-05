using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Resources;
using Xamarin.Forms.Platform.UWP;

namespace UWPTest.UWP {
    public class XamarinResourceLoader : CustomXamlResourceLoader {

        protected override object GetResource(string resourceId, string objectType, string propertyName, string propertyType) {
            return base.GetResource(resourceId, objectType, propertyName, propertyType);
        }

    }
}
