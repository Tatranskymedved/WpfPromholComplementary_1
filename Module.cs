using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfPromholComplementary_1
{
    public class Module : INotifyPropertyChanged
    {
        private string _number;
        public string Number
        {
            get { return this._number; }
            set
            {
                if (_number == value) return;
                _number = value;
                OnPropertyChanged(nameof(Number));
            }
        }

        private double _ch1;
        public double Ch1
        {
            get { return this._ch1; }
            set
            {
                if (_ch1 == value) return;
                _ch1 = value;
                OnPropertyChanged(nameof(Ch1));
            }
        }
        private double _ch2;
        public double Ch2
        {
            get { return this._ch2; }
            set
            {
                if (_ch2 == value) return;
                _ch2 = value;
                OnPropertyChanged(nameof(Ch2));
            }
        }
        private double _ch3;
        public double Ch3
        {
            get { return this._ch3; }
            set
            {
                if (_ch3 == value) return;
                _ch3 = value;
                OnPropertyChanged(nameof(Ch3));
            }
        }
        private double _ch4;
        public double Ch4
        {
            get { return this._ch4; }
            set
            {
                if (_ch4 == value) return;
                _ch4 = value;
                OnPropertyChanged(nameof(Ch4));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string aNameOfProperty)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(aNameOfProperty));
        }
    }
}
