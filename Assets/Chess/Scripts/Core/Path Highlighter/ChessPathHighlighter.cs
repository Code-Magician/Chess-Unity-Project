namespace Chess.Scripts.Core
{
    public class ChessPathHighlighter
    {
        internal static void HighlightPath(
            PIECECOLOR color, 
            PIECETYPE type,
            int row, 
            int col
        )
        {
            ChessBoardPlacementHandler.Instance.ClearHighlights();

            switch (type)
            {
                case PIECETYPE.PAWN: PawnPath.Path(row, col, color); break;
                case PIECETYPE.ROOK: RookPath.Path(row, col, color); break;
                case PIECETYPE.KING: KingPath.Path(row, col, color); break;
                case PIECETYPE.QUEEN: QueenPath.Path(row, col, color); break;
                case PIECETYPE.BISHOP: BishopPath.Path(row, col, color); break;
                case PIECETYPE.KNIGHT: KnightPath.Path(row, col, color); break;
            }
        }
    }
}