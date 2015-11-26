using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UWPTest.ViewModels {
    public class SettingViewModel : Screen {

        public string Title { get; set;}

        public SettingViewModel() {
            this.Title = "AA";
            this.DisplayName = "Setting";
        }

    }
}
