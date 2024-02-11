using System;
using UnityEditor.Experimental.GraphView;

namespace Chess.Scripts.Core
{
    public class Traverse
    {
        private static PIECECOLOR GetOppositeColor(PIECECOLOR color)
        {
            return (
                color == PIECECOLOR.BLACK ?
                PIECECOLOR.WHITE :
                PIECECOLOR.BLACK
            );
        }


        private static int GetRowMultiplier(DIRECTION direction)
        {
            if (
                    direction == DIRECTION.TOP ||
                    direction == DIRECTION.TOPRIGHT ||
                    direction == DIRECTION.TOPLEFT
                )
                return 1;
            else if (
                    direction == DIRECTION.RIGHT ||
                    direction == DIRECTION.LEFT
                )
                return 0;
            else
                return -1;
        }


        private static int GetColumnMultiplier(DIRECTION direction)
        {
            if (
                    direction == DIRECTION.RIGHT ||
                    direction == DIRECTION.TOPRIGHT ||
                    direction == DIRECTION.BOTTOMRIGHT
                )
                return 1;
            else if (
                    direction == DIRECTION.TOP ||
                    direction == DIRECTION.BOTTOM
                )
                return 0;
            else
                return -1;
        }


        internal static void From(
            int row, 
            int col, 
            DIRECTION direction, 
            PIECECOLOR color,
            int steps = 100
        )
        {
            int offset = 1;
            int rowMultiplier = GetRowMultiplier(direction);
            int colMultiplier = GetColumnMultiplier(direction);

            while (
                steps-->0 && 
                ChessPathHighlighter.DoNotHasPieceAt(
                    row + rowMultiplier*offset, 
                    col + colMultiplier*offset, 
                    color
                )
            )
            {
                ChessBoardPlacementHandler.Instance.Highlight(
                    row + rowMultiplier*offset, 
                    col + colMultiplier*offset, 
                    color
                );

                if (ChessPathHighlighter.HasPieceAt(
                    row + rowMultiplier*offset, 
                    col + colMultiplier*offset, 
                    GetOppositeColor(color)
                )) 
                    break;

                offset++;
            }
        }
    }
}