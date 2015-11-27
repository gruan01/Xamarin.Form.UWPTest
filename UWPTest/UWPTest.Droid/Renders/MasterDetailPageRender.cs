using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android.AppCompat;
using UWPTest.Droid.Renders;
using System.Reflection;

[assembly: ExportRenderer(typeof(MasterDetailPage), typeof(MyMasterDetailPageRender))]
namespace UWPTest.Droid.Renders {
    public class MyMasterDetailPageRender : MasterDetailPageRenderer {

        protected override void OnElementChanged(VisualElement oldElement, VisualElement newElement) {
            base.OnElementChanged(oldElement, newElement);

            var fld = typeof(MasterDetailPageRenderer).GetField("detailLayout", BindingFlags.NonPublic | BindingFlags.Instance);
            var fldValue = fld.GetValue(this);
            var p = fld.FieldType.GetProperty("TopPadding", BindingFlags.Public | BindingFlags.Instance);
            p.SetValue(fldValue, 0);
        }
    }
}