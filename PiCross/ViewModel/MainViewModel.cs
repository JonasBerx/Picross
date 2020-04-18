using Microsoft.Win32;
using PiCross;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
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
            Player.Open(new Uri("C://Users//JojoS//Desktop//2TI-BS//VGO//Picross//PiCross//ViewModel//Resources//VanillaDreams.mp3", UriKind.Absolute));
            Player.Volume = 0.3f;
            Player.Play();

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
            Player.Position = Player.Position.Add(new TimeSpan(-5, 0, -5));
        }
        public void PlayMusic()
        {
            Player.Play();
        }
        public void FastForwardMusic()
        {
            //Not Implemented yet...
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

        public void StartView()
        {
            this.ActiveWindow = new StartScreenViewModel(this);
        }

        public void CloseWindow()
        {
            this.ClosingAction?.Invoke();
        }
    }
}