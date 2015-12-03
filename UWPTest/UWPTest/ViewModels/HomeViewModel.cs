using Caliburn.Micro;
using Caliburn.Micro.Xamarin.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace UWPTest.ViewModels {
    public class HomeViewModel : Screen {

        public ICommand BtnClickCmd { get; set; }

        public HomeViewModel(INavigationService ns, SimpleContainer container) {
            this.DisplayName = "Home";

            this.BtnClickCmd = new Command(() => {
                ns.NavigateToViewModelAsync<ProductViewModel>();
            });
        }

    }
}
