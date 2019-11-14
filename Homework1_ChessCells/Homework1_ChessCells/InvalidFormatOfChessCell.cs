using System;
namespace Homework1_ChessCells
{
    class InvalidFormatOfChessCell : Exception
    {
        public InvalidFormatOfChessCell(string message) : base(message) { }
    }
}
