using System;
using System.Collections.Generic;
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
        public OptionsWindow()
        {
            InitializeComponent();
        }

        

        //private void SetSkin(string name)
        //{
        //    var resourceDictionary = new ResourceDictionary();
        //    var uri = $"Skins/{name}.xaml";
        //    resourceDictionary.MergedDictionaries.Add((ResourceDictionary)Application.LoadComponent(new Uri(uri, UriKind.Relative)));
        //    Application.Current.Resources = resourceDictionary;
        //}
    }
}
