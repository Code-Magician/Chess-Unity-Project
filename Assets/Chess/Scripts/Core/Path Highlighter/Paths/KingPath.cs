namespace Chess.Scripts.Core
{
    public class KingPath
    {
        internal static void Path(int row, int col, PIECECOLOR color)
        {
            // Top
            if (ChessPathHighlighter.DoNotHasPieceAt(row + 1, col, color))
            {
                ChessBoardPlacementHandler.Instance.Highlight(row + 1, col, color);
            }

            // Top-Right
            if (ChessPathHighlighter.DoNotHasPieceAt(row + 1, col + 1, color))
            {
                ChessBoardPlacementHandler.Instance.Highlight(row + 1, col + 1, color);
            }

            // Right
            if (ChessPathHighlighter.DoNotHasPieceAt(row, col + 1, color))
            {
                ChessBoardPlacementHandler.Instance.Highlight(row, col + 1, color);
            }

            // Down-Right
            if (ChessPathHighlighter.DoNotHasPieceAt(row - 1, col + 1, color))
            {
                ChessBoardPlacementHandler.Instance.Highlight(row - 1, col + 1, color);
            }

            // Down
            if (ChessPathHighlighter.DoNotHasPieceAt(row - 1, col, color))
            {
                ChessBoardPlacementHandler.Instance.Highlight(row - 1, col, color);
            }

            // Down-Left
            if (ChessPathHighlighter.DoNotHasPieceAt(row - 1, col - 1, color))
            {
                ChessBoardPlacementHandler.Instance.Highlight(row - 1, col - 1, color);
            }

            // Left
            if (ChessPathHighlighter.DoNotHasPieceAt(row, col - 1, color))
            {
                ChessBoardPlacementHandler.Instance.Highlight(row, col - 1, color);
            }

            // Top-Left
            if (ChessPathHighlighter.DoNotHasPieceAt(row + 1, col - 1, color))
            {
                ChessBoardPlacementHandler.Instance.Highlight(row + 1, col + -1, color);
            }
        }
    }
}
