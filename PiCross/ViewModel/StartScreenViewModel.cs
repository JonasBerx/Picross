using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ViewModel
{
    public class StartScreenViewModel
    {
        public StartScreenViewModel(MainViewModel mainWindowView)
        {
            this.vm = mainWindowView;
            this.LevelSelect = new Command(() => this.vm.LevelSelect());
            this.QuitCommand = new Command(() => this.vm.CloseWindow());
        }

        private MainViewModel vm { get; }

        public ICommand LevelSelect { get; }

        public ICommand QuitCommand { get; }
    }
}