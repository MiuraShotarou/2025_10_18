using System;
using UnityEngine;

/// <summary> ゲームシステム全般 </summary>
public class InGameManager : MonoBehaviour
{
    public event Action AdvanceTurn;
    int _turnCount; 
    public int TurnCount { get => _turnCount; set { _turnCount = value; if (_turnCount == 0) Restart(); else AdvanceTurn?.Invoke(); }}
    void Restart()
    {
        
    }
}
