// See https://aka.ms/new-console-template for more information
using System;


namespace Chess
{
    class Program
    {
        static void Main(string[] args)
        {
            Game game = new Game();
            game.Pieces.Add(game.B_King);
            game.Pieces.Add(game.B_Queen);
            game.Pieces.Add(game.B_Bishop1);
            game.Pieces.Add(game.B_Bishop2);
            game.Pieces.Add(game.B_Rook1);
            game.Pieces.Add(game.B_Rook2);
            game.Pieces.Add(game.B_Knight1);
            game.Pieces.Add(game.B_Knight2);
            game.Pieces.Add(game.W_King);
            game.Pieces.Add(game.W_Queen);
            game.Pieces.Add(game.W_Bishop1);
            game.Pieces.Add(game.W_Bishop2);
            game.Pieces.Add(game.W_Rook1);
            game.Pieces.Add(game.W_Rook2);
            game.Pieces.Add(game.W_Knight1);
            game.Pieces.Add(game.W_Knight2);

            game.Play();

        }
    }
   
}
