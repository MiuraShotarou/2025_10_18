using UnityEngine;
/// <summary> Script内で敵の情報を参照するためのクラス。ScriptableObjectを保持し、EnemyPrefabにアタッチして使う </summary>
public class EnemyUnit : UnitBase
{
    public EnemyScriptable Data;
    [HideInInspector] public Vector3Int CurrentPos;
    [HideInInspector] public Vector3Int MovePos;
    //Data
    [HideInInspector] public string Name;
    [HideInInspector] public int[] AttackRange;
    [HideInInspector] public int MoveRange;
    void Start()
    {
        Name = Data.Name;
        AttackRange = Data.AttackRange;
        MoveRange = Data.MoveRange;
        GameDataManager.Instance.InGameManager.AdvanceTurn += Advance;
        DecideMovePos();
    }
    void Advance()
    {
        gameObject.transform.position += MovePos;
    }

    void OnDisable()
    {
        GameDataManager.Instance.InGameManager.AdvanceTurn -= Advance;
    }

    void DecideMovePos()
    {
        Vector2 pos = gameObject.transform.position;
        if (pos.x < 0)
        {
            MovePos = new Vector3Int(1, 0, 0);
        }
        else if (pos.x > 0)
        {
            MovePos = new Vector3Int(-1, 0, 0);
        }
        else if (pos.y < 0)
        {
            MovePos = new Vector3Int(0, 1, 0);
        }
        else if (pos.y > 0)
        {
            MovePos = new Vector3Int(0, -1, 0);
        }
    }
}
