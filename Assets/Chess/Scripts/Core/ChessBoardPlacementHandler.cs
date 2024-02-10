using System;
using UnityEngine;
using System.Diagnostics.CodeAnalysis;
using Chess.Scripts.Core;

[SuppressMessage("ReSharper", "MemberCanBePrivate.Global")]
public sealed class ChessBoardPlacementHandler : MonoBehaviour {
    [SerializeField] private GameObject[] _rowsArray;
    [SerializeField] private GameObject _blackPlayerHighlightPrefab, _whitePlayerHighlightPrefab;

    private GameObject[,] _chessBoard;
    private GameObject[,] _blackPieces, _whitePieces;

    internal static ChessBoardPlacementHandler Instance;

    private void Awake() {
        Instance = this;
        GenerateArray();
    }

    private void GenerateArray() {
        _chessBoard = new GameObject[8, 8];
        _blackPieces = new GameObject[8, 8];
        _whitePieces = new GameObject[8, 8];

        for (var i = 0; i < 8; i++) {
            for (var j = 0; j < 8; j++) {
                _chessBoard[i, j] = _rowsArray[i].transform.GetChild(j).gameObject;

                _blackPieces[i, j] = null;
                _whitePieces[i, j] = null;
            }
        }
    }

    internal GameObject GetTile(int i, int j) {
        try {
            return _chessBoard[i, j];
        } catch (Exception) {
            return null;
        }
    }

    internal void Highlight(int row, int col, PIECECOLOR color) {
        var tile = GetTile(row, col).transform;
        if (tile == null) {
            return;
        }

        Instantiate(
            (
                color == PIECECOLOR.BLACK ? 
                _blackPlayerHighlightPrefab :
                _whitePlayerHighlightPrefab 
            ), 
            tile.transform.position, 
            Quaternion.identity, 
            tile.transform
        );
    }

    internal void ClearHighlights() {
        for (var i = 0; i < 8; i++) {
            for (var j = 0; j < 8; j++) {

                var tile = GetTile(i, j);

                if (tile.transform.childCount <= 0) continue;

                foreach (Transform childTransform in tile.transform) {
                    Destroy(childTransform.gameObject);
                }

            }
        }
    }

    internal void SetPiece(ChessPlayerPlacementHandler playerHandler) {
        int row = playerHandler.GetRow();
        int col = playerHandler.GetCol();

        if (playerHandler.GetPieceColor() == PIECECOLOR.BLACK)
            _blackPieces[row, col] = playerHandler.transform.gameObject;
        else if (playerHandler.GetPieceColor() == PIECECOLOR.WHITE)
            _whitePieces[row, col] = playerHandler.transform.gameObject;

    }

    internal GameObject GetPiece(int row, int col, PIECECOLOR color) {
        if (color == PIECECOLOR.BLACK)
            return _blackPieces[row, col];
        else if (color == PIECECOLOR.WHITE)
            return _whitePieces[row, col];

        return null;
    }


    #region Highlight Testing

    // private void Start() {
    //     StartCoroutine(Testing());
    // }

    // private IEnumerator Testing() {
    //     Highlight(2, 7);
    //     yield return new WaitForSeconds(1f);
    //
    //     ClearHighlights();
    //     Highlight(2, 7);
    //     Highlight(2, 6);
    //     Highlight(2, 5);
    //     Highlight(2, 4);
    //     yield return new WaitForSeconds(1f);
    //
    //     ClearHighlights();
    //     Highlight(7, 7);
    //     Highlight(2, 7);
    //     yield return new WaitForSeconds(1f);
    // }

    #endregion
}