using System;

namespace Chess
{
    class Piece
    {
        public string rank;
        public string colour;
        public Piece(string rank, string colour)
        {
            this.rank = rank;
            this.colour = colour;
        }
    }
    class ClassicBoard
    {
        public Piece[,] board;
        public ClassicBoard()
        {
            this.board = new Piece[8, 8];
            // Creates an empty piece object for every place in the board
            for (int x = 0; x < 8; x++) 
            {
                for (int y = 0; y < 8; y++)
                {
                    this.board[x, y] = new Piece(null, null);
                }
            }
            // Initialise Pawns
            for (int i = 0; i < 8; i++)
            {
                this.board[i, 1] = new Piece("pawn", "white");
                this.board[i, 6] = new Piece("pawn", "black");
            }
            {
                // Initialise Rooks
                this.board[0, 0] = new Piece("rook", "white");
                this.board[7, 0] = new Piece("rook", "white");
                this.board[0, 7] = new Piece("rook", "black");
                this.board[7, 7] = new Piece("rook", "black");
                // Initialise Knights
                this.board[1, 0] = new Piece("knight", "white");
                this.board[6, 0] = new Piece("knight", "white");
                this.board[1, 7] = new Piece("knight", "black");
                this.board[6, 7] = new Piece("knight", "black");
                // Initialize Bishops
                this.board[2, 0] = new Piece("bishop", "white");
                this.board[5, 0] = new Piece("bishop", "white");
                this.board[2, 7] = new Piece("bishop", "black");
                this.board[5, 7] = new Piece("bishop", "black");
                // Initialize Queens
                this.board[3, 0] = new Piece("queen", "white");
                this.board[3, 7] = new Piece("queen", "black");
                // Initialize Kings
                this.board[4, 0] = new Piece("king", "white");
                this.board[4, 7] = new Piece("king", "black");
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            // Testing the opening position for the board
            ClassicBoard board = new ClassicBoard();
            Random n = new Random();
            for (int i = 0; i < 10; i++)
            {
                int x = n.Next(0, 8);
                int y = n.Next(0, 8);
                Console.WriteLine($"x: {x}| y: {y}\nrank: {board.board[x, y].rank} | colour: {board.board[x, y].colour}");
            }
        }
    }
}