using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media;

namespace ViewModel
{
    public class OptionsViewModel
    {
        public OptionsViewModel(MainViewModel main)
        {
            this.vm = main;
            this.MenuCommand = new Command(() => this.vm.StartView());
            this.SansCommand = new Command(() => this.vm.Sans());
            this.EasterCommand = new Command(() => this.vm.Easter());
            this.CaramelDansenCommand = new Command(() => this.vm.CaramelDansen());

            
        }

        private MainViewModel vm { get; }

        public ICommand MenuCommand { get; }
        public ICommand SansCommand { get; }
        public ICommand EasterCommand { get; }
        public ICommand CaramelDansenCommand { get; }
    }
}
