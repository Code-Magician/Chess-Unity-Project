namespace Chess.Scripts.Core
{
    public class PieceChecker
    {
        internal static bool DoNotHasPieceAt(int i, int j, PIECECOLOR color)
        {
            return (
                ChessBoardPlacementHandler.Instance.GetTile(i, j) &&
                !ChessBoardPlacementHandler.Instance.GetPiece(i, j, color)
            );
        }

        internal static bool HasPieceAt(int i, int j, PIECECOLOR color)
        {
            return (
                ChessBoardPlacementHandler.Instance.GetTile(i, j) &&
                ChessBoardPlacementHandler.Instance.GetPiece(i, j, color)
            );
        }
    }
}
