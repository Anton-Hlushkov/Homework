using System;

namespace Homework1_ChessCells
{
    class Program
    {
        static void Main(string[] args)
        {

            string cell;
            while (true)
            {
                try
                {
                    Console.Write("Enter file of cell#1: ");
                    cell = Console.ReadLine();
                    CheckInputString(cell);
                    ChessCell cell1 = new ChessCell(cell);
                    Console.WriteLine($"{cell} is {cell1.GetColor()}");

                    Console.Write("Enter file of cell#2: ");
                    cell = Console.ReadLine();
                    CheckInputString(cell);
                    ChessCell cell2 = new ChessCell(cell);
                    Console.WriteLine($"{cell} is {cell2.GetColor()}");


                    Console.WriteLine(cell1.RelativePositionResearch(cell2));
                    //break;
                }
                catch (InvalidFormatOfChessCell ex)
                {
                    Console.WriteLine(ex.Message + "Try again.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message + "Try again.");
                }
            }
        }

        private static void CheckInputString(string cell)
        {
            const string files = "abcdefgh";
            const string ranks = "12345678";
            if (cell.Length != 2 || files.Contains(cell[0].ToString()) == false || ranks.Contains(cell[1].ToString()) == false)
                throw new InvalidFormatOfChessCell("Invalid format of chess cell.");
        }
    }
}
