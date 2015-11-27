using System;

using Android.App;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using Xamarin.Forms.Platform.Android;
using Caliburn.Micro;
using System.Reflection;
using Xamarin.Forms;
using UWPTest.Droid.Renders;
using System.Linq;
using System.Collections.Generic;

namespace UWPTest.Droid {
    [Activity(Label = "UWPTest", Theme = "@style/MyTheme", Icon = "@drawable/icon", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : FormsAppCompatActivity {
        protected override void OnCreate(Bundle bundle) {
            base.OnCreate(bundle);

            global::Xamarin.Forms.Forms.Init(this, bundle);

            FormsAppCompatActivity.ToolbarResource = Resource.Layout.toolbar;
            FormsAppCompatActivity.TabLayoutResource = Resource.Layout.tabs;

            //this.A();

            LoadApplication(new App(IoC.Get<SimpleContainer>()));

            //var asm = Assembly.GetAssembly(typeof(Xamarin.Forms.AbsoluteLayout));
            //var t = asm.GetType("Xamarin.Forms.Registrar");
            //var p = t.GetProperty("Registered", BindingFlags.Static | BindingFlags.NonPublic);
            //p.GetValue(null);

            var m = typeof(FormsAppCompatActivity).GetMethod("RegisterHandlerForDefaultRenderer", BindingFlags.Instance | BindingFlags.NonPublic);
            m.Invoke(this, new object[] {
                typeof(MasterDetailPage),
                typeof(MyMasterDetailPageRender),
                typeof(MyMasterDetailPageRender)
            });
        }

        //private void A() {
        //    Assembly[] array = AppDomain.CurrentDomain.GetAssemblies();
        //    //if (Registrar.ExtraAssemblies != null)
        //    //    array = Enumerable.ToArray<Assembly>(Enumerable.Union<Assembly>((IEnumerable<Assembly>)array, Registrar.ExtraAssemblies));

        //    Assembly assembly = IntrospectionExtensions.GetTypeInfo(typeof(Forms)).Assembly;
        //    int index = Array.IndexOf<Assembly>(array, assembly);
        //    if (index > 0) {
        //        array[index] = array[0];
        //        array[0] = assembly;
        //    }
        //    var attributeType = typeof(ExportRendererAttribute);
        //    Dictionary<string, string> handlers = new Dictionary<string, string>();
        //    foreach (Assembly element in array) {
        //        {
        //            Attribute[] attributeArray = Enumerable.ToArray<Attribute>(CustomAttributeExtensions.GetCustomAttributes(element, attributeType));
        //            if (attributeArray.Length != 0) {
        //                foreach (HandlerAttribute handler in attributeArray) {
        //                    if (handler.ShouldRegister()) {
        //                        //Registrar.Registered.Register(handlerAttribute.HandlerType, handlerAttribute.TargetType);
        //                        var targetType = (Type)this.GetPropertyValue(handler, "TargetType");
        //                        var handlerType = (Type)this.GetPropertyValue(handler, "HandlerType");
        //                        handlers.Add(targetType.FullName, handlerType.FullName);
        //                    }
        //                }
        //            }
        //        }
        //    }
        //}

        //private object GetPropertyValue(object o, string prop) {
        //    var p = o.GetType().GetProperty(prop, BindingFlags.NonPublic | BindingFlags.Instance);
        //    return p.GetValue(o);
        //}
    }
}

