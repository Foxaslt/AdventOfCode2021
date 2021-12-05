using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Day4
{
    internal class Board : IBoard
    {
        private bool winner = false;
        private const int dim = 5;
        private Pair<int,bool>[,] board = new Pair<int, bool>[dim,dim];

        public Board(IEnumerable<string> rows)
        {
            int j = 0;
            foreach (var row in rows)
            {
                var arr = Regex.Replace(row.Trim(), @"\s+", " ").Split(' ').Select(int.Parse).ToArray();
                for (int i = 0; i < dim; i++)
                {
                    board[i, j] = new Pair<int, bool>() {First = arr[i]};
                }

                j++;
            }
        }

        public bool IsWinner
        {
            get { return winner; }
            private set { winner = value; }
        }

        public void Mark(int number)
        {
            for (int i = 0; i < dim; i++)
                for (int j = 0; j < dim; j++)
                    if (board[i, j].First == number)
                    {
                        board[i, j].Second = true;
                        if (CheckRow(i) || CheckColumn(j))
                            IsWinner = true;
                    }
        }

        private bool CheckRow(int i)
        {
            bool win = true;
            for(int col = 0; col < dim; col++)
                if (board[i, col].Second == false)
                {
                    win = false;
                }

            return win;
        }

        private bool CheckColumn(int j)
        {
            bool win = true;
            for (int row = 0; row < dim; row++)
                if (board[row, j].Second == false)
                {
                    win = false;
                }

            return win;
        }

        public int GetSum()
        {
            int sum = 0;
            for (int i = 0; i < dim; i++)
            for (int j = 0; j < dim; j++)
                if (board[i, j].Second == false)
                    sum += board[i, j].First;
            return sum;
        }

        private class Pair<T1, T2>
        {
            public T1 First { get; set; }
            public T2 Second { get; set; }
        }
    }
}