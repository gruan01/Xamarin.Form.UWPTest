using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UWPTest.UWP.Renders;
using Xamarin.Forms;
using Xamarin.Forms.Platform.UWP;
using WX = Windows.UI.Xaml;

//[assembly: ExportRenderer(typeof(TabbedPage), typeof(TabbedPageRender))]
namespace UWPTest.UWP.Renders {
    public class TabbedPageRender : TabbedPageRenderer {
        public TabbedPageRender() : base() {
            //this.Tracker.Updated += Tracker_Updated;
            this.ElementChanged += TabbedPageRender_ElementChanged;
        }

        private void TabbedPageRender_ElementChanged(object sender, VisualElementChangedEventArgs e) {
            this.Control.Style = (WX.Style)WX.Application.Current.Resources["TabbedPageStyle1"];
        }

        private void Tracker_Updated(object sender, EventArgs e) {
            
        }
    }
}
