using DataStructures;
using PiCross;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Grid = DataStructures.Grid;
using Size = DataStructures.Size;

namespace View
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, ISkinManager
    {
        private MediaPlayer music;
        public MainWindow()
        {
            Switch("Jojo");
            InitializeComponent();
            
        }

        public void Switch(string name)
        {
            var resourceDictionary = new ResourceDictionary();
            var uri = $"Skins/{name}.xaml";
            resourceDictionary.MergedDictionaries.Add((ResourceDictionary)Application.LoadComponent(new Uri(uri, UriKind.Relative)));
            resourceDictionary.MergedDictionaries.Add((ResourceDictionary)Application.LoadComponent(new Uri($"Skins/shared.xaml", UriKind.Relative)));
            Application.Current.Resources = resourceDictionary;

            music = new MediaPlayer();
            music.Stop();
            Uri musicuri = new Uri(AppDomain.CurrentDomain.BaseDirectory + $"Resources\\Theme.mp3", UriKind.Relative);
            Debug.WriteLine(musicuri);
            music.Open(musicuri);
            music.Volume = 0.2f;
            music.Play();
        }
        private void Media_Ended(object sender, EventArgs e)
        {
            music.Position = TimeSpan.Zero;
            music.Play();
        }
    }
}