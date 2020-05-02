using PiCross;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ViewModel
{
    public class LevelSelectViewModel
    {
        public LevelSelectViewModel(MainViewModel mainViewModel)
        {
            this.vm = mainViewModel;
            this.LevelSelectCommand = new LevelSelectCommand(mainViewModel);
            this.MenuCommand = new Command(() => this.vm.StartView());
            this.OptionsCommand = new Command(() => this.vm.Options());
        }

        private MainViewModel vm { get; }
        public ICommand LevelSelectCommand { get; }
        public ICommand MenuCommand { get; }
        public ICommand OptionsCommand { get; }
    }

    public class LevelSelectCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;
        private MainViewModel vm { get; }
        public Puzzle Puzzle;
        public LevelSelectCommand(MainViewModel mainViewModel)
        {
            this.vm = mainViewModel;
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            var puzzle = Puzzle.FromRowStrings(this.RandomPuzzle(Int32.Parse(parameter as string)));
            this.vm.StartGame(puzzle);
        }
        public String[] RandomPuzzle(int x)
        {
            Random rnd = new Random();
            String[] output = new String[x];

            for (int i = 0; i < x; i++)
            {
                String line = "";
                for (int j = 0; j < x; j++)
                {
                    if (rnd.Next(3) == 0)
                    {
                        line += ".";
                    }
                    else
                    {
                        line += "x";
                    }
                }
                output[i] = line;
            }
            return output;
        }
    }
}