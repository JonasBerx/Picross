using System.Windows;
using ViewModel;

namespace View
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            var mainWindow = new MainWindow();

            MainViewModel vm = new MainViewModel();

            vm.ClosingAction += ViewModel_ApplicationExit;

            mainWindow.DataContext = vm;
            mainWindow.Show();
        }

        private void ViewModel_ApplicationExit()
        {
            Application.Current.Shutdown();
        }
    }
}