namespace Chess.Scripts.Core
{
    public class QueenPath
    {
        internal static void Path(int row, int col, PIECECOLOR color)
        {
            RookPath.Path(row, col, color); 
            BishopPath.Path(row, col, color);
        }
    }
}
