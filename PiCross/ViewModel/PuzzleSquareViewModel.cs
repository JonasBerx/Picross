using Cells;
using PiCross;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ViewModel
{
    public class PuzzleSquareViewModel
    {
        public PuzzleSquareViewModel(IPlayablePuzzleSquare puzzleSquare)
        {
            this.PuzzleSquare = puzzleSquare;
            this.FillCommand = new FillCommand(this);
            this.EmptyCommand = new EmptyCommand(this);
        }
        public Cell<Square> Contents
        {
            get
            {
                return PuzzleSquare.Contents;
            }
        }

        public IPlayablePuzzleSquare PuzzleSquare { get; }
        public ICommand FillCommand { get; }
        public ICommand EmptyCommand { get; }

    }
    public class FillCommand : ICommand
    {
        private PuzzleSquareViewModel vm;

        public FillCommand(PuzzleSquareViewModel puzzleSquareViewModel)
        {
            vm = puzzleSquareViewModel;
        }

        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            var square = parameter as IPlayablePuzzleSquare;
            square.Contents.Value = Square.FILLED;
        }
    }

    public class EmptyCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;
        private PuzzleSquareViewModel vm;

        public EmptyCommand(PuzzleSquareViewModel puzzleSquareViewModel)
        {
            vm = puzzleSquareViewModel;
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            var square = parameter as IPlayablePuzzleSquare;
            square.Contents.Value = Square.EMPTY;
        }
    }


}
