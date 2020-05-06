using Microsoft.Win32;
using PiCross;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Media;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;


namespace ViewModel
{
    public class MainViewModel : INotifyPropertyChanged
    {
        private readonly MediaPlayer Player;
        public MainViewModel()
        {
            
            Debug.WriteLine("Constructor Main viewmodel");
            this.ActiveWindow = new StartScreenViewModel(this);
            this.PiCrossFacade = new PiCrossFacade();
            this.Player = new MediaPlayer();
            this.Theme = new Theme(this, Player);
            this.Music = new Music(Player);
            CaramelDansen();
            

        }

        public PiCrossFacade PiCrossFacade { get; }
        private object activeWindow;
        public Action ClosingAction { get; set; }
        public event PropertyChangedEventHandler PropertyChanged;
        public Theme Theme { get; }
        public Music Music { get; }

        public object ActiveWindow
        {
            get
            {
                Debug.WriteLine(activeWindow);
                return activeWindow;
            }
            private set
            {
                activeWindow = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(ActiveWindow)));
            }
        }
        
        public void Rewind()
        {
            Debug.WriteLine("Rewinding");
            Music.Rewind();
        }
        public void Play()
        {
            Music.Play();
        }
        public void Stop()
        {
           Music.Stop();
        }
        public void StartGame(Puzzle puzzle)
        {
            this.ActiveWindow = new GameViewModel(this, puzzle);
        }

        public void LevelSelect()
        {
            this.ActiveWindow = new LevelSelectViewModel(this);
        }
        public void Options()
        {
            Debug.WriteLine("Getting in options");

            this.ActiveWindow = new OptionsViewModel(this);
        }

        public void StartView()
        {
            this.ActiveWindow = new StartScreenViewModel(this);
        }

        public void CloseWindow()
        {
            this.ClosingAction?.Invoke();
        }

        public void Sans() 
        {
            this.Theme.Sans();
        }
        public void Easter()
        {
            this.Theme.Easter();
        }
        public void CaramelDansen()
        {
            this.Theme.CaramelDansen();
        }
    }
}