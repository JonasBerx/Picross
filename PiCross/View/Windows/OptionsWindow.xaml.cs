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

namespace View.Windows
{
    /// <summary>
    /// Interaction logic for OptionsWindow.xaml
    /// </summary>
    public partial class OptionsWindow : UserControl
    {
        //private MediaPlayer Player;
        public OptionsWindow()
        {
            InitializeComponent();
            //Player = new MediaPlayer();
        }

        private void Switch(string name)
        {
            var resourceDictionary = new ResourceDictionary();
            var uri = $"Skins/{name}.xaml";
            resourceDictionary.MergedDictionaries.Add((ResourceDictionary)Application.LoadComponent(new Uri(uri, UriKind.Relative)));
            resourceDictionary.MergedDictionaries.Add((ResourceDictionary)Application.LoadComponent(new Uri($"Skins/shared.xaml", UriKind.Relative)));
            Application.Current.Resources = resourceDictionary;

            //Player.Close();
            //Player.Open(new Uri(AppDomain.CurrentDomain.BaseDirectory + $"\\Resources\\{name}.mp3"));
            //Player.Play();
        }
        private void Sans(object sender, RoutedEventArgs e)
        {
            Switch("Sans");
        }

        private void CarmelDansen(object sender, RoutedEventArgs e)
        {
            Switch("CarmelDansen");
        }

        private void Jojo(object sender, RoutedEventArgs e)
        {
            Switch("Jojo");
        }
    }
}
