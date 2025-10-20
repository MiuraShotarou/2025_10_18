using UnityEngine;

/// <summary>
/// ゲーム全体で保持する必要のあるデータを格納する。
/// </summary>
public class GameDataManager : MonoBehaviour
{
    public GameObject PlayerObj;
    public InputSystem_Actions InputSystem;
    public BulletType BulletType;
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
    }

    private void OnEnable()
    {
        if (InputSystem != null)
        {
            InputSystem.Enable();
        }
    }
}