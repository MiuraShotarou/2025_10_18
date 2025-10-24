using System.Linq;
using UnityEngine;
using UnityEngine.Tilemaps;

/// <summary>
/// ゲーム全体で保持する必要のあるデータを格納する。
/// </summary>
public class GameDataManager : MonoBehaviour
{
    public GameObject PlayerObj;
    [HideInInspector] public GameObject[] EnemyObjectArray;
    public InGameManager InGameManager;
    public Tilemap Tilemap;
    public TileBase NormalTileBase;
    public TileBase PredictedAttackTileBase;
    public TileBase AttackTileBase;
    public (string name, GameObject obj)[] EnemyTupleArray;
    private InputSystem_Actions InputSystem;
    [HideInInspector] public string[] StageSceneArray = {"Stage0", "Stage1"};
    public static GameDataManager Instance { get; private set; }
    private void Awake()
    {
        #if UNITY_EDITOR
        Time.timeScale = 10;
        #endif
        if (Instance && Instance != this)
        {
            Destroy(gameObject);
            return;
        }
        Instance = this;
        DontDestroyOnLoad(gameObject);
        InputSystem = new InputSystem_Actions();
        EnemyObjectArray = FindObjectsByType<EnemyUnit>(FindObjectsSortMode.None).Select(unit => unit.gameObject).ToArray();
        EnemyTupleArray = EnemyObjectArray.Select(enemy => (enemy.name, enemy)).ToArray();
    }

    private void OnEnable()
    {
        if (InputSystem != null)
        {
            InputSystem.Enable();
        }
    }
    //<パラメーター関連>
}