using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SudokuSolve
{
        public class SudokuSolver
        {
            public bool SolveSudoku(int[,] board)
            {
                int row = 0;
                int col = 0;

                if (!FindEmptyCell(board, ref row, ref col))
                {
                    return true; // Всі клітинки заповнені, судоку вирішено
                }

                for (int num = 1; num <= 9; num++)
                {
                    if (IsValidMove(board, row, col, num))
                    {
                        board[row, col] = num;

                        if (SolveSudoku(board))
                        {
                            return true; // Розв'язок знайдено
                        }

                        board[row, col] = 0; // Скасування останнього присвоєння (backtrack)
                    }
                }

                return false; // Неможливо знайти розв'язок
            }

            private bool FindEmptyCell(int[,] board, ref int row, ref int col)
            {
                int size = board.GetLength(0);

                for (row = 0; row < size; row++)
                {
                    for (col = 0; col < size; col++)
                    {
                        if (board[row, col] == 0) // Знайдено порожню клітинку
                        {
                            return true;
                        }
                    }
                }

                return false; // Всі клітинки заповнені
            }

            private bool IsValidMove(int[,] board, int row, int col, int num)
            {
                // Перевірка чи число не зустрічається в тому ж рядку або стовпчику
                for (int i = 0; i < 9; i++)
                {
                    if (board[row, i] == num || board[i, col] == num)
                    {
                        return false;
                    }
                }

                // Перевірка чи число не зустрічається в тому ж квадраті 3x3
                int startRow = row - row % 3;
                int startCol = col - col % 3;

                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        if (board[startRow + i, startCol + j] == num)
                        {
                            return false;
                        }
                    }
                }

                return true; // Дозволений хід
            }
        }
}
