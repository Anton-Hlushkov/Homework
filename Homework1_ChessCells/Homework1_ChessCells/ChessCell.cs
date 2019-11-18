using System;
namespace Homework1_ChessCells
{
    class ChessCell
    {
        public char File { get; }
        public int Rank { get; }

        public ChessCell(string cell)
        {
            File = cell[0];
            Rank = (int)char.GetNumericValue(cell[1]);
        }

        public string GetColor()
        {
            if ((File + 1 - 'a') % 2 == Rank % 2)
            {
                return "Black";
            }
            else
            {
                return "White";
            }
        }

        public string RelativePositionResearch(ChessCell cell)
        {
            if (File == cell.File && Rank == cell.Rank)
            {
                return "Cell#1 and cell#2 are the same cell.";
            }
            if (File == cell.File)
            {
                return "Cell#1 and cell#2 lies in one file.";
            }
            if (Rank == cell.Rank)
            {
                return "Cell#1 and cell#2 lies in one rank.";
            }
            if (Math.Abs(File - cell.File) == Math.Abs(Rank - cell.Rank))
            {
                return "Cell#1 and cell#2 lies in one diagonal.";
            }
            else
            {
                return "Positions of cell#1 and cell#2 do not relate.";
            }
        }
    }
}

