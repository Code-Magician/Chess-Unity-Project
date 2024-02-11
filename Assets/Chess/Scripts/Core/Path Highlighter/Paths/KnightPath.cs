namespace Chess.Scripts.Core
{
    public class KnightPath
    {
        internal static void Path(int row, int col, PIECECOLOR color)
        {
            Traverse.From(row + 2, col, DIRECTION.LEFT, color, 1);
            Traverse.From(row + 2, col, DIRECTION.RIGHT, color, 1);

            Traverse.From(row - 2, col, DIRECTION.LEFT, color, 1);
            Traverse.From(row - 2, col, DIRECTION.RIGHT, color, 1);

            Traverse.From(row, col + 2, DIRECTION.TOP, color, 1);
            Traverse.From(row, col + 2, DIRECTION.BOTTOM, color, 1);

            Traverse.From(row, col - 2, DIRECTION.TOP, color, 1);
            Traverse.From(row, col - 2, DIRECTION.BOTTOM, color, 1);
        }
    }

}
