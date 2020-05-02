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
        private MediaPlayer Player;
        public MainViewModel()
        {
            
            Debug.WriteLine("Constructor Main viewmodel");
            this.ActiveWindow = new StartScreenViewModel(this);
            this.PiCrossFacade = new PiCrossFacade();
            this.Player = new MediaPlayer();
            
            CaramelDansen();

        }

        public PiCrossFacade PiCrossFacade { get; }
        private object activeWindow;
        public Action ClosingAction { get; set; }
        public event PropertyChangedEventHandler PropertyChanged;

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

        public void RewindMusic()
        {
            Player.Position = new TimeSpan(-5,-5,-5);
        }
        public void PlayMusic()
        {
            Player.Play();
        }
        public void PauseMusic()
        {
           Player.Pause();
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
            SetSkin("Sans");
            Player.Stop();
            Player.Open(new Uri(AppDomain.CurrentDomain.BaseDirectory + "\\Resources\\2.mp3"));
            Player.Play();
            StartView();
        }

        public void Easter()
        {
            SetSkin("Easter");
            Player.Stop();
            Player.Open(new Uri(AppDomain.CurrentDomain.BaseDirectory + "\\Resources\\1.mp3"));
            Player.Play();
            StartView();
        }

        public void CaramelDansen()
        {
            SetSkin("CarmelDansen");
            Player.Stop();
            Player.Open(new Uri(AppDomain.CurrentDomain.BaseDirectory + "\\Resources\\3.mp3"));
            Player.Play();
            StartView();
        }

        private void SetSkin(string name)
        {
            var resourceDictionary = new ResourceDictionary();
            var uri = $"Skins/{name}.xaml";
            resourceDictionary.MergedDictionaries.Add((ResourceDictionary)Application.LoadComponent(new Uri(uri, UriKind.Relative)));
            resourceDictionary.MergedDictionaries.Add((ResourceDictionary)Application.LoadComponent(new Uri($"Skins/shared.xaml", UriKind.Relative)));
            Application.Current.Resources = resourceDictionary;
        }
    }
}