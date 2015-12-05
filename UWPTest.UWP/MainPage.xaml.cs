using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI;
using Windows.UI.ViewManagement;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

//“空白页”项模板在 http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409 上有介绍

namespace UWPTest.UWP {
    /// <summary>
    /// 可用于自身或导航至 Frame 内部的空白页。
    /// </summary>
    public partial class MainPage {

        //private SplitView spv = null;

        public MainPage() {
            this.InitializeComponent();

            this.LoadApplication(new UWPTest.App(IoC.Get<WinRTContainer>()));

            //var tb = ApplicationView.GetForCurrentView().TitleBar;
            //tb.BackgroundColor = Colors.Red;// Color.FromArgb(0xff, 0x00, 0x97, 0xa7);//#0097A7

            if (Windows.Foundation.Metadata.ApiInformation.IsTypePresent("Windows.UI.ViewManagement.StatusBar")) {
                StatusBar statusBar = StatusBar.GetForCurrentView();
                statusBar.BackgroundColor = Color.FromArgb(0xff, 0x00, 0x97, 0xa7);//#0097A7
                statusBar.BackgroundOpacity = 1;
            }

            this.Loaded += MainPage_Loaded;
        }

        private void MainPage_Loaded(object sender, Windows.UI.Xaml.RoutedEventArgs e) {
            var btn = this.FindChildControl<ToggleButton>("splitViewToggle");
            btn.Click += Btn_Click;

            var backBtn = this.FindChildControl<ToggleButton>("backToggle");
            backBtn.Click += BackBtn_Click;

            //this.spv = this.FindChildControl<SplitView>("masterDetailSplitView");
        }

        private async void BackBtn_Click(object sender, Windows.UI.Xaml.RoutedEventArgs e) {
            //var rootFrame = Window.Current.Content as Frame;

            //if (rootFrame.CanGoBack) {
            //    rootFrame.GoBack();
            //}

            await UWPTest.App.Current.MainPage.Navigation.PopAsync();
        }

        private void Btn_Click(object sender, Windows.UI.Xaml.RoutedEventArgs e) {
            var spv = this.FindChildControl<SplitView>("masterDetailSplitView");
            spv.IsPaneOpen = !spv.IsPaneOpen;
            //spv.Pane.InvalidateMeasure();
            //spv.Pane.InvalidateArrange();
            //spv.UpdateLayout();
        }
    }
}
