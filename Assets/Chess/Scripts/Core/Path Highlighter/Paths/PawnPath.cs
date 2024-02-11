namespace Chess.Scripts.Core
{
    public class PawnPath
    {
        internal static void Path(int row, int col, PIECECOLOR color)
        {
            PIECECOLOR oppositeColor = (
                color == PIECECOLOR.BLACK ? 
                PIECECOLOR.WHITE : 
                PIECECOLOR.BLACK
            );

            // Foward Movement
            for (var i = 1; i <= 2; i++)
            {
                int mRow = row;
                switch(color)
                {
                    case PIECECOLOR.BLACK: mRow += i; break;
                    case PIECECOLOR.WHITE: mRow -= i; break;
                }

                
                if (PieceChecker.DoNotHasPieceAt(mRow, col, color) &&
                    PieceChecker.DoNotHasPieceAt(
                        mRow, 
                        col, 
                        oppositeColor
                    )
                )
                {
                    ChessBoardPlacementHandler.Instance.Highlight(mRow, col, color);
                }
                else break;
            }


            // Diagonal Attack
            int aRow = row + (color == PIECECOLOR.BLACK ? 1 : -1);
            if (PieceChecker.HasPieceAt(aRow, col + 1, oppositeColor))
                ChessBoardPlacementHandler.Instance.Highlight(aRow, col + 1, color);

            if (PieceChecker.HasPieceAt(aRow, col - 1, oppositeColor))
                ChessBoardPlacementHandler.Instance.Highlight(aRow, col - 1, color);
        }
    }
}
