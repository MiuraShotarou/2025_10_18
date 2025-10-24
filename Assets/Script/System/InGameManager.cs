using System;
using UnityEngine;
using UnityEngine.SceneManagement;
using DG.Tweening;

/// <summary> ゲームシステム全般 </summary>
public class InGameManager : MonoBehaviour
{
    public event Action AdvanceTurn;
    int _turnCount;
    // int _stageIndex;
    public int TurnCount { get => _turnCount; set { _turnCount = value; AdvanceTurn?.Invoke(); }}
    public int StageIndex { get; private set; }
    public GameObject _CanBusterObject {private get; set; }
    void Awake()
    {
        StageIndex = 0;
    }
    /// <summary> シーンを切り替える </summary>
    public void NextStage()
    {
        StageIndex++;
        SceneManager.LoadScene($"Stage{StageIndex}");
    }

    public void Restart()
    {
         SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
