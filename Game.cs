using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess
{
    internal class Game : ChessBoard
    {
        public List<ChessPieces> Pieces = new List<ChessPieces>();

        public void Play()
        {
            // 판을 그리고 - > 기물 선택 -> 위치 선택 -> 충돌 체크, 이동 가능한지 체크 -> 수정사항 바꾸고 다시 그림
            PlayDraw(Pieces);
            Console.WriteLine();
            PlayChoice(Pieces);
            PlayDraw(Pieces);
           
        }


        private void PlayDraw(List<ChessPieces> Pieces)
        {
            for (int i = 0; i < 8; i++)
            {
                int count = 0;
                Console.Write($"{8 - i} ");
                for (int j = 0; j < 8; j++)
                {
                    foreach (ChessPieces pos in Pieces)
                    {
                        if (pos.x == i && pos.y == j)
                        {
                            count++;
                            Console.Write(pos.image);
                        }
                    }
                    if (count == 0) Console.Write("빈");
                }
                Console.WriteLine();
            }
            Console.WriteLine("  A B C D E F G H");
        }

        private void PlayChoice(List<ChessPieces> Pieces) // 좌표 선택 --> 경로 계산 --> 가능한 경로인지, 중간에 기물이 존재하는지 체크 ---> 수정사항 전달 --> 그리기
        {
            int Start_pos_x;
            int Start_pos_y;
            int Dest_pos_x;
            int Dest_pos_y;

            Console.WriteLine("움직일 기물의 좌표를 공백으로 구분하여 입력하세요. ex) 2열 G행 : 2 G, 4열 F행 : 4 F");
            InputChoice(out Start_pos_x, out Start_pos_y);

            Console.WriteLine("기물을 옮길 위치 좌표를 입력하세요. ex) 2열 G행 : 2 G, 4열 F행 : 4 F");
            InputChoice(out Dest_pos_x, out Dest_pos_y);


            foreach (ChessPieces pos in Pieces)
            {
                if (pos.x == Start_pos_x && pos.y == Start_pos_y)
                {
                    pos.x = pos.x + (Dest_pos_x - Start_pos_x);
                    pos.y = pos.y + (Dest_pos_y - Start_pos_y);
                }
            }
        }

        private void PlayCheck()
        {

        }

        private void InputChoice(out int pos_x, out int pos_y)
        {
            string choice = Console.ReadLine();
            string[] pos = choice.Split(' ');
            pos_x = 8 - Convert.ToInt32(pos[0]);
            pos_y = pos[1][0] - 65;
        }

        
    }
}
