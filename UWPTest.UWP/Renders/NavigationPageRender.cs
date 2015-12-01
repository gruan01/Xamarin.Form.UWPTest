using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UWPTest.UWP.Renders;
using Xamarin.Forms;
using Xamarin.Forms.Platform.UWP;

[assembly: ExportRenderer(typeof(NavigationPage), typeof(NavigationPageRender))]
namespace UWPTest.UWP.Renders {
    public class NavigationPageRender : NavigationPageRenderer {

        public NavigationPageRender() : base() {
            //this.Element.BarBackgroundColor = Color.Red;
            this.ElementChanged += NavigationPageRender_ElementChanged;
        }

        private void NavigationPageRender_ElementChanged(object sender, VisualElementChangedEventArgs e) {
            if (e.NewElement != null) {
                this.Element.BarBackgroundColor = Color.FromRgb(0x00, 0xbc, 0xd4);// new Color(0x00, 0xBC, 0xD4, 0xff);//#00BCD4
            }
        }
    }
}
