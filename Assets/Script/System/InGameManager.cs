using System;
using UnityEngine;
using UnityEngine.SceneManagement;

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

    public void NextStage()
    {
        StageIndex++;
        Debug.Log($"{GameDataManager.Instance.StageSceneArray[1]}");
        SceneManager.LoadScene(GameDataManager.Instance.StageSceneArray[StageIndex]);
    }

    public void Restart()
    {
         SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
