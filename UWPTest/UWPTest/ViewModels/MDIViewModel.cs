using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UWPTest.ViewModels {
    public class MDIViewModel : Screen {

        public Screen Master { get; set; }

        public Screen Detail { get; set; }


        public MDIViewModel(SimpleContainer container) {
            this.Master = container.GetInstance<SettingViewModel>();
            this.Detail = container.GetInstance<TabViewModel>();
        }
    }
}
