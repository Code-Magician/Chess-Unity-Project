namespace Chess.Scripts.Core
{
    public class BishopPath
    {
        internal static void Path(int row, int col, PIECECOLOR color)
        {
            PIECECOLOR oppositeColor = (
                color == PIECECOLOR.BLACK ?
                PIECECOLOR.WHITE :
                PIECECOLOR.BLACK
            );


            // Top-Right Diagonal
            int offset = 1;
            while (ChessPathHighlighter.DoNotHasPieceAt(row + offset, col + offset, color))
            {
                ChessBoardPlacementHandler.Instance.Highlight(row + offset, col + offset, color);
                if (ChessPathHighlighter.HasPieceAt(row + offset, col + offset, oppositeColor)) break;

                offset++;
            }

            // Top-Left Diagonal
            offset = 1;
            while (ChessPathHighlighter.DoNotHasPieceAt(row + offset, col - offset, color))
            {
                ChessBoardPlacementHandler.Instance.Highlight(row + offset, col - offset, color);
                if(ChessPathHighlighter.HasPieceAt(row + offset, col - offset, oppositeColor)) break;

                offset++;
            }

            // Down-Right Diagonal
            offset = 1;
            while (ChessPathHighlighter.DoNotHasPieceAt(row - offset, col + offset, color))
            {
                ChessBoardPlacementHandler.Instance.Highlight(row - offset, col + offset, color);
                if (ChessPathHighlighter.HasPieceAt(row - offset, col + offset, oppositeColor)) break;

                offset++;
            }


            // Down-Left Diagonal
            offset = 1;
            while (ChessPathHighlighter.DoNotHasPieceAt(row - offset, col - offset, color))
            {
                ChessBoardPlacementHandler.Instance.Highlight(row - offset, col - offset, color);
                if(ChessPathHighlighter.HasPieceAt(row - offset, col - offset, oppositeColor)) break;

                offset++;
            }
        }
    }
}
