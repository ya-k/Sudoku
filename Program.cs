﻿// See https://aka.ms/new-console-template for more information
using SudokuSolve;

int[,] board = new int[,]
{
    { 5, 3, 0, 0, 7, 0, 0, 0, 0 },
    { 6, 0, 0, 1, 9, 5, 0, 0, 0 },
    { 0, 9, 8, 0, 0, 0, 0, 6, 0 },
    { 8, 0, 0, 0, 6, 0, 0, 0, 3 },
    { 4, 0, 0, 8, 0, 3, 0, 0, 1 },
    { 7, 0, 0, 0, 2, 0, 0, 0, 6 },
    { 0, 6, 0, 0, 0, 0, 2, 8, 0 },
    { 0, 0, 0, 4, 1, 9, 0, 0, 5 },
    { 0, 0, 0, 0, 8, 0, 0, 7, 9 }
};

SudokuSolver solver = new SudokuSolver();
if (solver.SolveSudoku(board))
{
    // Розв'язок знайдено, можна вивести результат
    for (int i = 0; i < 9; i++)
    {
        for (int j = 0; j < 9; j++)
        {
            Console.Write(board[i, j] + " ");
        }
        Console.WriteLine();
    }
}
else
{
    Console.WriteLine("Неможливо знайти розв'язок для даного судоку.");
}

