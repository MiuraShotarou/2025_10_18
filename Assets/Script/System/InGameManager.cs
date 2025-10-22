using System;
using UnityEngine;

/// <summary> ゲームシステム全般 </summary>
public class InGameManager : MonoBehaviour
{
    public Action AdvanceTurn;
    int _turnCount; 
    int TurnCount
    {
        get => _turnCount;
        set
        {
            _turnCount = value;
            if (_turnCount == 0)
            {
                Restart();
            }
            else
            {
                AdvanceTurn?.Invoke();
            }
        }
    }
    public void SetTurnCount(int turnCount) => TurnCount += turnCount;
    public int GetTurnCount() => TurnCount;
    void Restart()
    {
        
    }
}
