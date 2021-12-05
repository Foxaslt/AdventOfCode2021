namespace Day4
{
    internal interface IBoard
    {
        bool IsWinner { get; }
        void Mark(int number);
        int GetSum();
    }
}