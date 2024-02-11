using System;
using UnityEngine;
using System.Diagnostics.CodeAnalysis;
using Chess.Scripts.Core;

[SuppressMessage("ReSharper", "MemberCanBePrivate.Global")]
public sealed class ChessBoardPlacementHandler : MonoBehaviour 
{
    internal static ChessBoardPlacementHandler Instance;

    [Header("Player Path Highlighter Prefabs")]
    [SerializeField] private GameObject _blackPlayerHighlightPrefab, _whitePlayerHighlightPrefab;

    [Header("Chess Board Rows")]
    [SerializeField] private GameObject[] _rowsArray;

    private GameObject[,] _chessBoard;
    private GameObject[,] _blackPieces, _whitePieces;


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

        switch(playerHandler.GetPieceColor())
        {
            case PIECECOLOR.BLACK:
                _blackPieces[row, col] = playerHandler.transform.gameObject; break;
            case PIECECOLOR.WHITE:
                _whitePieces[row, col] = playerHandler.transform.gameObject; break;
        }

    }

    internal GameObject GetPiece(int row, int col, PIECECOLOR color) 
    {
        switch(color)
        {
            case PIECECOLOR.BLACK:
                return _blackPieces[row, col];
            case PIECECOLOR.WHITE:
                return _whitePieces[row, col];
            default: 
                return null;
        }
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