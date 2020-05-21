using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Interop;
using System.Windows.Media;

namespace ViewModel
{
    public class Theme
    {
        private readonly Music Player;

        public Theme(MainViewModel main, MediaPlayer player)
        {
           
            this.Vm = main;
            this.Player = new Music(player);
        }

        private MainViewModel Vm { get; }
        public void Sans()
        {
            SetSkin("Sans");
        }

        public void Easter()
        {
            SetSkin("Easter");
        }

        public void CaramelDansen()
        {
            SetSkin("CarmelDansen");

        }

        private void SetSkin(string name)
        {
            var resourceDictionary = new ResourceDictionary();
            var uri = $"Skins/{name}.xaml";
            resourceDictionary.MergedDictionaries.Add((ResourceDictionary)Application.LoadComponent(new Uri(uri, UriKind.Relative)));
            resourceDictionary.MergedDictionaries.Add((ResourceDictionary)Application.LoadComponent(new Uri($"Skins/shared.xaml", UriKind.Relative)));
            Application.Current.Resources = resourceDictionary;

            Player.Stop();
            Player.Open(new Uri(AppDomain.CurrentDomain.BaseDirectory + $"\\Resources\\{name}.mp3"));
            Player.Play();
            this.Vm.StartView();

        }
    }

    
}
