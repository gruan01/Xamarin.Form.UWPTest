﻿using System;

using Android.App;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using Xamarin.Forms.Platform.Android;
using Caliburn.Micro;

namespace UWPTest.Droid {
    [Activity(Label = "UWPTest", Theme = "@style/MyTheme", Icon = "@drawable/icon", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : FormsAppCompatActivity {
        protected override void OnCreate(Bundle bundle) {
            base.OnCreate(bundle);

            global::Xamarin.Forms.Forms.Init(this, bundle);

            FormsAppCompatActivity.ToolbarResource = Resource.Layout.toolbar;
            FormsAppCompatActivity.TabLayoutResource = Resource.Layout.tabs;

            LoadApplication(new App(IoC.Get<SimpleContainer>()));
        }
    }
}

