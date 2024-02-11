namespace Chess.Scripts.Core
{
    public class KingPath
    {
        internal static void Path(int row, int col, PIECECOLOR color)
        {
            Traverse.From(row, col, DIRECTION.TOP, color, 1);
            Traverse.From(row, col, DIRECTION.BOTTOM, color, 1);

            Traverse.From(row, col, DIRECTION.LEFT, color, 1);
            Traverse.From(row, col, DIRECTION.RIGHT, color, 1);

            Traverse.From(row, col, DIRECTION.TOPLEFT, color, 1);
            Traverse.From(row, col, DIRECTION.TOPRIGHT, color, 1);
            
            Traverse.From(row, col, DIRECTION.BOTTOMLEFT, color, 1);
            Traverse.From(row, col, DIRECTION.BOTTOMRIGHT, color, 1);
        }
    }
}
