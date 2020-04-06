using PiCross;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModel
{
    public class PuzzleSquareViewModel
    {
        public PuzzleSquareViewModel(IPlayablePuzzleSquare puzzleSquare)
        {
            this.PlayablePuzzleSquare = puzzleSquare;
        }

        public IPlayablePuzzleSquare PlayablePuzzleSquare { get; }
    }
}
