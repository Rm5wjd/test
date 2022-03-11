using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess
{
    internal class ChessPieces
    {
        public int x; //자신의 숫자 좌표
        public int y; //자신의 알파벳 좌표
        public char image; //기물의 이미지 문자
        // ♔♕♖♗♘♙  화이트
        // ♚♛♜♝♞♟  블랙

        protected void SetPos(int x, int y, char image)
        {
            this.x = x;
            this.y = y;
            this.image = image;
        }
    }

    class King : ChessPieces
    {       
        public King(char color)
        {
            if (color == 'B') SetPos(0, 4, '킹');
            else SetPos(7, 4, '킹');
        }

    }
    
    class Queen : ChessPieces
    {
        public Queen(char color)
        {
            if (color == 'B') SetPos(0, 3, '퀸');
            else SetPos(7, 3,'퀸');
        }
    }

    class Bishop : ChessPieces
    {
        public Bishop(int x, int y)
        {
            SetPos(x, y, '비');    
        }
    }

    class Knight : ChessPieces
    {
        public Knight(int x, int y)
        {
            SetPos(x, y, '나');
        }
    }

    class Rook : ChessPieces
    {
        public Rook(int x, int y)
        {
            SetPos(x, y, '룩');
        }
    }

    class Pawn : ChessPieces
    {
        public Pawn(int x, int y)
        {
            SetPos(x, y, '폰');
        }
    }

}
