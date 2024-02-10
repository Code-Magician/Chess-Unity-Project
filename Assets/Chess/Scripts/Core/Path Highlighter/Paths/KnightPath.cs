namespace Chess.Scripts.Core
{
    public class KnightPath
    {
        internal static void Path(int row, int col, PIECECOLOR color)
        {
            // Top-Left
            if (ChessPathHighlighter.DoNotHasPieceAt(row + 2, col - 1, color))
            {
                ChessBoardPlacementHandler.Instance.Highlight(row + 2, col - 1, color);
            }

            // Top-Right
            if (ChessPathHighlighter.DoNotHasPieceAt(row + 2, col + 1, color))
            {
                ChessBoardPlacementHandler.Instance.Highlight(row + 2, col + 1, color);
            }

            // Bottom-Left
            if (ChessPathHighlighter.DoNotHasPieceAt(row - 2, col - 1, color))
            {
                ChessBoardPlacementHandler.Instance.Highlight(row - 2, col - 1, color);
            }

            // Bottom-Right
            if (ChessPathHighlighter.DoNotHasPieceAt(row - 2, col + 1, color))
            {
                ChessBoardPlacementHandler.Instance.Highlight(row - 2, col + 1, color);
            }

            // Right-Top
            if (ChessPathHighlighter.DoNotHasPieceAt(row + 1, col + 2, color))
            {
                ChessBoardPlacementHandler.Instance.Highlight(row + 1, col + 2, color);
            }

            // Right-Bottom
            if (ChessPathHighlighter.DoNotHasPieceAt(row - 1, col + 2, color))
            {
                ChessBoardPlacementHandler.Instance.Highlight(row - 1, col + 2, color);
            }

            
            // Left-Top
            if (ChessPathHighlighter.DoNotHasPieceAt(row + 1, col - 2, color))
            {
                ChessBoardPlacementHandler.Instance.Highlight(row + 1, col - 2, color);
            }

            // Left-Bottom
            if (ChessPathHighlighter.DoNotHasPieceAt(row - 1, col - 2, color))
            {
                ChessBoardPlacementHandler.Instance.Highlight(row - 1, col - 2, color);
            }
        }
    }

}
