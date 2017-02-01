using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace WpfPromholComplementary_1
{
    public class MainViewModel
    {
        public Module Module1 { get; set; } = new Module() { Number = "1", Ch1 = 123.4, Ch2 = 123.4, Ch3 = 123.4, Ch4 = 123.4 };
        public Module Module2 { get; set; } = new Module() { Number = "2", Ch1 = 123.4, Ch2 = 123.4, Ch3 = 123.4, Ch4 = 123.4 };
        public Module Module3 { get; set; } = new Module() { Number = "3", Ch1 = 123.4, Ch2 = 123.4, Ch3 = 123.4, Ch4 = 123.4 };
        public Module Module4 { get; set; } = new Module() { Number = "4", Ch1 = 123.4, Ch2 = 123.4, Ch3 = 123.4, Ch4 = 123.4 };
        public Module Module5 { get; set; } = new Module() { Number = "5", Ch1 = 123.4, Ch2 = 123.4, Ch3 = 123.4, Ch4 = 123.4 };
        public Module Module6 { get; set; } = new Module() { Number = "6", Ch1 = 123.4, Ch2 = 123.4, Ch3 = 123.4, Ch4 = 123.4 };


        private ICommand _DoSomeWorkCmd = null;
        ///<summary>
        /// DoSomeWorkCmd
        ///</summary>
        public ICommand DoSomeWorkCmd
        {
            get
            {
                if (_DoSomeWorkCmd != null) return _DoSomeWorkCmd;

                _DoSomeWorkCmd = new RelayCommand((object aParam)=> { return true; }, (object aParam) =>
                {
                    this.Module1.Number = "MyNewNumber XyZ";
                });

                return this._DoSomeWorkCmd;
            }
        }

    }
}
