using Cells;
using DataStructures;
using PiCross;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ViewModel
{
    public class PicrossViewModel
    {
        public PicrossViewModel()
        {
            var puzzle = Puzzle.FromRowStrings(
                "x.xxx",
                "x...x",
                "x...x",
                "x.x.x",
                "xx..x"
           );
            var facade = new PiCrossFacade();
            var playablePuzzle = facade.CreatePlayablePuzzle(puzzle);

            playablePuzzle.Grid[new Vector2D(0, 0)].Contents.Value = Square.FILLED;
            playablePuzzle.Grid[new Vector2D(1, 0)].Contents.Value = Square.EMPTY;


            /*picrossControl.Grid = playablePuzzle.Grid;

            picrossControl.RowConstraints = playablePuzzle.RowConstraints;
            picrossControl.ColumnConstraints = playablePuzzle.ColumnConstraints;*/
        }

        public ICommand Fill { get; }
        public ICommand Empty { get; }




        /*var puzzle = Puzzle.FromRowStrings(
                "x.xxx",
                "x...x",
                "x...x",
                "x.x.x",
                "xx..x"
           );
           var facade = new PiCrossFacade();
           var playablePuzzle = facade.CreatePlayablePuzzle(puzzle);

            playablePuzzle.Grid[new Vector2D(0, 0)].Contents.Value = Square.FILLED;
            playablePuzzle.Grid[new Vector2D(1, 0)].Contents.Value = Square.EMPTY;
            
            picrossControl.Grid = playablePuzzle.Grid;

            picrossControl.RowConstraints = playablePuzzle.RowConstraints;
            picrossControl.ColumnConstraints = playablePuzzle.ColumnConstraints; */
    }
}
