using System;
using UnityEngine;

namespace Chess.Scripts.Core
{
    public class ChessPlayerPlacementHandler : MonoBehaviour
    {
        [Header("Location")]
        [SerializeField] private int row, col;

        [Header("Items Description")]
        [SerializeField] private PIECECOLOR color;
        [SerializeField] private PIECETYPE type;



        private void Start()
        {
            transform.position = ChessBoardPlacementHandler.Instance
                .GetTile(row, col).transform.position;

            ChessBoardPlacementHandler.Instance.SetPiece(this);
        }


        private void OnMouseDown()
        {
            ChessPathHighlighter.HighlightPath(color, type, row, col);
        }


        internal int GetRow() { return row; }
        internal int GetCol() { return col; }
        internal PIECECOLOR GetPieceColor() { return color; }
    }
}