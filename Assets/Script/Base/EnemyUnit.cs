using System;
using UnityEngine;
/// <summary> Script内で敵の情報を参照するためのクラス。ScriptableObjectを保持し、EnemyPrefabにアタッチして使う </summary>
public class EnemyUnit : UnitBase
{
    public EnemyDataBase Data;
    [HideInInspector] public Vector3Int MovePos;
    //Data
    [HideInInspector] public string Name;
    [HideInInspector] public int[] AttackRange;
    [HideInInspector] public int MoveRange;
    [HideInInspector] public Action<EnemyUnit> DeathAction;
    void Start()
    {
        Name = Data.Name;
        AttackRange = Data.AttackRange;
        MoveRange = Data.MoveRange;
        DeathAction = Data.DeathAction;
        GameDataManager.Instance.InGameManager.AdvanceTurn += Advance;
        DecideMovePos();
    }
    void Advance()
    {
        transform.position += MovePos;
        if (transform.position == new Vector3(0, 0, 0))
        {
            GameDataManager.Instance.InGameManager.Restart();
        }
    }

    public void Death()
    {
        GameDataManager.Instance.InGameManager.AdvanceTurn -= Advance;
        DeathAction?.Invoke(this);
    }

    void DecideMovePos()
    {
        Vector2 pos = transform.position;
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
