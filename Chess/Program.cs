using System;
using System.Numerics;

class Chess
{
    static void Main(string[] args)
    {
        string[,] boardState = {{"♜", "♞", "♝", "♛", "♚", "♝", "♞", "♜"},
                                {"♟", "♟", "♟", "♟", "♟", "♟", "♟", "♟"},
                                {"　", "　", "　", "　", "　", "　", "　", "　"},
                                {"　", "　", "　", "　", "　", "　", "　", "　"},
                                {"　", "　", "　", "　", "　", "　", "　", "　"},
                                {"　", "　", "　", "　", "　", "　", "　", "　"},
                                {"♙", "♙", "♙", "♙", "♙", "♙", "♙", "♙"},
                                {"♖", "♘", "♗", "♕", "♔", "♗", "♘", "♖"}};

        while(true)
        {
            PrintBoard(boardState);
            Console.WriteLine(" ");

            Console.WriteLine("What piece do you want to move?");
            Console.Write("x y: ");
            
            string input = Console.ReadLine();
            if(input[0] == 'Q' || input[0] == 'q')
                break;
            
            string[] splitInput = input.Split();

            int selectX = int.Parse(splitInput[0]); 
            int selectY = int.Parse(splitInput[1]); 

            Console.WriteLine("You slected "+ boardState[selectY, selectX] +" Where do you want to move?");
            Console.Write("x y: ");
             
            input = Console.ReadLine();
            if(input[0] == 'Q' || input[0] == 'q')
                break;
            
            splitInput = input.Split();

            int targetX = int.Parse(splitInput[0]);
            int targetY = int.Parse(splitInput[1]);

            boardState[targetY,targetX] = boardState[selectY,selectX];
            boardState[selectY,selectX] = "　";

        }
    }


    static void PrintBoard(string[,] board)
    {
        for (int i = 0; i < board.GetLength(0); i++)
        {
            Console.Write(i + " ");
            for (int j = 0; j < board.GetLength(1); j++)
            {
                Console.Write("|" + board[i, j]);
            }
            
            Console.WriteLine("|");
        }

        Console.Write(" ");
        for(int i = 0; i < board.GetLength(1); i++)
            Console.Write("  " + (i).ToString());
        Console.WriteLine(" ");
    }
}