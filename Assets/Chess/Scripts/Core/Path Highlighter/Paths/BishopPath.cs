namespace Chess.Scripts.Core
{
    public class BishopPath
    {
        internal static void Path(int row, int col, PIECECOLOR color)
        {
            Traverse.From(row, col, DIRECTION.TOPLEFT, color);
            Traverse.From(row, col, DIRECTION.TOPRIGHT, color);
            Traverse.From(row, col, DIRECTION.BOTTOMLEFT, color);
            Traverse.From(row, col, DIRECTION.BOTTOMRIGHT, color);
        }
    }
}
