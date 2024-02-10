namespace Chess.Scripts.Core
{
    public class RookPath
    {
        internal static void Path(int row, int col, PIECECOLOR color)
        {
            PIECECOLOR oppositeColor = (
                color == PIECECOLOR.BLACK ?
                PIECECOLOR.WHITE :
                PIECECOLOR.BLACK
            );

            // Top
            int offset = 1;
            while (ChessPathHighlighter.DoNotHasPieceAt(row + offset, col, color))
            {
                ChessBoardPlacementHandler.Instance.Highlight(row + offset, col, color);
                if (ChessPathHighlighter.HasPieceAt(row + offset, col, oppositeColor)) break;

                offset++;
            }

            // Left
            offset = 1;
            while (ChessPathHighlighter.DoNotHasPieceAt(row, col - offset, color))
            {
                ChessBoardPlacementHandler.Instance.Highlight(row, col - offset, color);
                if (ChessPathHighlighter.HasPieceAt(row, col - offset, oppositeColor)) break;

                offset++;
            }

            // Down
            offset = 1;
            while (ChessPathHighlighter.DoNotHasPieceAt(row - offset, col, color))
            {
                ChessBoardPlacementHandler.Instance.Highlight(row - offset, col, color);
                if (ChessPathHighlighter.HasPieceAt(row - offset, col, oppositeColor)) break;

                offset++;
            }


            // Right
            offset = 1;
            while (ChessPathHighlighter.DoNotHasPieceAt(row, col + offset, color))
            {
                ChessBoardPlacementHandler.Instance.Highlight(row, col + offset, color);
                if (ChessPathHighlighter.HasPieceAt(row, col + offset, oppositeColor)) break;

                offset++;
            }
        }
    }
}

