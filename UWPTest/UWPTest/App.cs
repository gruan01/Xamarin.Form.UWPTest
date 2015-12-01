using Caliburn.Micro;
using Caliburn.Micro.Xamarin.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UWPTest.ViewModels;
using UWPTest.Views;
using Xamarin.Forms;

namespace UWPTest {
    public partial class App : FormsApplication {

        private SimpleContainer Container = null;

        public App(SimpleContainer container) {
            //this.InitializeComponent();

            this.Container = container;

            this.Container
                .Singleton<TabViewModel>()
                .Singleton<HomeViewModel>()
                .Singleton<SettingViewModel>()
                .Singleton<MDIViewModel>()
                .PerRequest<ProductViewModel>()
                ;

            this.DisplayRootView<MDIView>();

            TaskScheduler.UnobservedTaskException += TaskScheduler_UnobservedTaskException;
        }

        private void TaskScheduler_UnobservedTaskException(object sender, UnobservedTaskExceptionEventArgs e) {
            //防止因线程取消等错误把程挂掉
            e.SetObserved();
        }

        protected override void PrepareViewFirst(NavigationPage navigationPage) {
            //navigationPage.BarBackgroundColor = Color.Green;
            this.Container.Instance<INavigationService>(new NavigationPageAdapter(navigationPage));
        }



        protected override void OnResume() {
            base.OnResume();
        }

        protected override void OnSleep() {
            base.OnSleep();
        }


        protected override void OnStart() {
            base.OnStart();
        }
    }
}
