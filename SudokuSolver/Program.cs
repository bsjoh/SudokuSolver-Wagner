using System;

namespace SudokuSolver {
  class Program {
    static void Main(string[] args) {
      int?[,] initialBoard = new int?[,] {
<<<<<<< HEAD
<<<<<<< HEAD
        { null,  7  , null,    9  , null,  4  ,    3  , null,  1   },
        { null,  3  , null,   null,  5  ,  7  ,   null, null, null },
        { null, null,  9  ,    6  ,  1  , null,   null,  8  , null },
=======
=======
>>>>>>> 52712af092ae0e5093d4aeff6093db1d1b05b5fa
        { null , null, null,    2  , null, null,   null, null,  1   },
        { null, null,  3  ,    8  , null, null,   null,  9  , null },
        {  7  , null,  4  ,   null,  9  ,  5  ,    8  , null, null },
>>>>>>> 52712af (Add board output)

        {  1  , null, null,   null,  3  ,  2  ,    9  , null,  6   },
        { null, null,  6  ,   null,  4  ,  5  ,    1  , null,  8   },
        {  2  ,  8  ,  4  ,   null, null, null,   null,  7  , null },

        {  4  , null,  5  ,   null,  7  ,  8  ,   null, null,  2   },
        { null, null,  3  ,   null, null, null,   null, null, null },
        {  9  , null, null,    5  ,  6  ,  1  ,    7  , null,  4   }
      };

      SudokuBoard board = new SudokuBoard(initialBoard);

      bool solved = SudokuSolver.Solve(board);
<<<<<<< HEAD
<<<<<<< HEAD
      Console.Write("This Sudoku is ... ");
=======
=======
>>>>>>> 52712af092ae0e5093d4aeff6093db1d1b05b5fa




<<<<<<< HEAD
>>>>>>> 52712af (Add board output)
=======
>>>>>>> 52712af092ae0e5093d4aeff6093db1d1b05b5fa
      Console.WriteLine($"{(solved ? "SOLVED" : "UNSOLVABLE")}");
            Console.WriteLine(board.ToString());
    }
  }
}
