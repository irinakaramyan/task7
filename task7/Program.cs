// See https://aka.ms/new-console-template for more information
using System;

class A
{
    static int[,] chessboard = new int[8, 8];

    static void PlaceQueens()
    {
        

        Random rand = new Random();
        for (int row = 0; row < 8; row++)
        {
            int maxFree = 0;
            int colWithMaxFree = 0;

            for (int col = 0; col < 8; col++)
            {
                if (chessboard[row, col] == 0)
                {
                    int freeCount = CountFreeSpaces(row, col);
                    if (freeCount > maxFree)
                    {
                        maxFree = freeCount;
                        colWithMaxFree = col;
                    }
                }
            }

            chessboard[row, colWithMaxFree] = 1;
        }
    }

    static int CountFreeSpaces(int row, int col)
    {
        
        int count = 0;
        for (int i = 0; i < 8; i++)
        {
            if (chessboard[row, i] == 0) count++;
            if (chessboard[i, col] == 0) count++;
        }
        return count;
    }

    static void Main()
    {
        
        for (int i = 0; i < 8; i++)
        {
            for (int j = 0; j < 8; j++)
            {
                chessboard[i, j] = 0;
            }
        }

        PlaceQueens();

        
        for (int i = 0; i < 8; i++)
        {
            for (int j = 0; j < 8; j++)
            {
                Console.Write(chessboard[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}
