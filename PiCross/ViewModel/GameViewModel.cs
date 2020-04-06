using DataStructures;
using PiCross;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModel
{
    public class GameViewModel : INotifyPropertyChanged
    {
        public GameViewModel(MainWindowViewModel main)
        {
            this.puzzle = Puzzle.FromRowStrings(
                "xxxxx",
                "x...x",
                "x...x",
                "x...x",
                "xxxxx"
                );

            this.Vm = main;
            this.PiCrossFacade = new PiCrossFacade();
            this.playable = PiCrossFacade.CreatePlayablePuzzle(this.puzzle);
            this.StartGame(Vm, playable);

            

        }

        public event PropertyChangedEventHandler PropertyChanged;

        public PiCrossFacade PiCrossFacade { get; }
        public Puzzle puzzle;
        public IPlayablePuzzle playable { get; private set; }
        public MainWindowViewModel Vm { get; private set; }
        public IGrid<PuzzleSquareViewModel> Grid { get; private set; }



        public void StartGame(MainWindowViewModel model, IPlayablePuzzle puzzle)
        {
            this.Vm = model;
            this.playable = puzzle;
            this.Grid = this.playable.Grid.Map(puzzlesquare => new PuzzleSquareViewModel(puzzlesquare)).Copy();
        }

        

    }
}
