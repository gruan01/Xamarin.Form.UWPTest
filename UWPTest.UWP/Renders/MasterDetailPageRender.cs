using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UWPTest.UWP.Renders;
using Xamarin.Forms;
using Xamarin.Forms.Platform.UWP;

//[assembly:ExportRenderer(typeof(MasterDetailPage), typeof(MasterDetailPageRender))]
namespace UWPTest.UWP.Renders {
    public class MasterDetailPageRender : MasterDetailPageRenderer {

        protected override void OnElementChanged(ElementChangedEventArgs<MasterDetailPage> e) {
            base.OnElementChanged(e);

            this.Control.MasterTitleVisibility = Windows.UI.Xaml.Visibility.Visible;
        }

    }
}
