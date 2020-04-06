using PiCross;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModel
{
    public class MainWindowViewModel
    {

        public MainWindowViewModel()
        {
            this.Pi = new PiCrossFacade();
            this.ActiveWindow = new GameViewModel(this);
        }


        public PiCrossFacade Pi { get; }
        private object activeWindow;
        public event PropertyChangedEventHandler PropertyChanged;
        public object ActiveWindow
        {
            get
            {
                
                return activeWindow;
            }
            private set
            {
                activeWindow = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(ActiveWindow)));
            }
        }

        public void StartGame()
        {
            this.ActiveWindow = new GameViewModel(this);
        }

    }
}
