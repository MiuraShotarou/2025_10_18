using System.Linq;
using UnityEngine;
using UnityEngine.Tilemaps;

/// <summary>
/// ゲーム全体で保持する必要のあるデータを格納する。
/// </summary>
public class GameDataManager : MonoBehaviour
{
    public GameObject PlayerObj;
    public GameObject[] EnemyObjectArray;
    public InGameManager InGameManager;
    public Tilemap Tilemap;
    public TileBase NormalTileBase;
    public TileBase PredictedAttackTileBase;
    public TileBase AttackTileBase;
    public (string name, GameObject obj)[] EnemyTupleArray;
    private InputSystem_Actions InputSystem;
    public static GameDataManager Instance { get; private set; }
    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        } 
        else
        {
            Destroy(gameObject);
        }
        InputSystem = new InputSystem_Actions();
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