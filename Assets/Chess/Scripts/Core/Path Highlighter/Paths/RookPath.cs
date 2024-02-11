namespace Chess.Scripts.Core
{
    public class RookPath
    {
        internal static void Path(int row, int col, PIECECOLOR color)
        {
            Traverse.From(row, col, DIRECTION.TOP, color);
            Traverse.From(row, col, DIRECTION.LEFT, color);
            Traverse.From(row, col, DIRECTION.RIGHT, color);
            Traverse.From(row, col, DIRECTION.BOTTOM, color);
        }
    }
}

