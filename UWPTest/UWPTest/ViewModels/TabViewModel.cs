using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UWPTest.ViewModels {
    public class TabViewModel : Screen {

        public BindableCollection<Screen> Datas {
            get; set;
        }


        //public TabViewModel(SimpleContainer container) {
        //    this.DisplayName = "Tabs";
        //    this.Datas = new BindableCollection<Screen>() {
        //        container.GetInstance<HomeViewModel>(),
        //        container.GetInstance<ProductViewModel>()
        //    };
        //}

        public TabViewModel() {
            this.DisplayName = "Tabs";
            this.Datas = new BindableCollection<Screen>() {
                    new HomeViewModel(),
                    new ProductViewModel()
                };
        }
    }
}
