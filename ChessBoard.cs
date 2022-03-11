using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess
{
    internal class ChessBoard
    {
        public ChessPieces B_King = new King('B'); // 킹
        public ChessPieces W_King = new King('W');

        public ChessPieces B_Queen = new Queen('B'); // 퀸
        public ChessPieces W_Queen = new Queen('W');

        public ChessPieces B_Rook1 = new Rook(0, 0); // 룩
        public ChessPieces B_Rook2 = new Rook(0, 7);
        public ChessPieces W_Rook1 = new Rook(7, 0);
        public ChessPieces W_Rook2 = new Rook(7, 7);

        public ChessPieces B_Knight1 = new Knight(0, 1); // 나이트
        public ChessPieces B_Knight2 = new Knight(0, 6);
        public ChessPieces W_Knight1 = new Knight(7, 1);
        public ChessPieces W_Knight2 = new Knight(7, 6);

        public ChessPieces B_Bishop1 = new Bishop(0, 2); // 비숍
        public ChessPieces B_Bishop2 = new Bishop(0, 5);
        public ChessPieces W_Bishop1 = new Bishop(7, 2);
        public ChessPieces W_Bishop2 = new Bishop(7, 5);

        public ChessPieces[] W_Pawns = new Pawn[8]; // 폰
        public ChessPieces[] B_Pawns = new Pawn[8];

    }
}
