using UnityEngine;

/// <summary> Script内で敵の情報を参照するためのクラス。ScriptableObjectを保持し、EnemyPrefabにアタッチして使う </summary>
public class EnemyUnit : UnitBase
{
    [HideInInspector] public EnemyScriptable Data;
    [HideInInspector] public Vector3Int CurrentPos;
    //Data
    [HideInInspector] public string Name;
    [HideInInspector] public int[] AttackRange;
    [HideInInspector] public int MoveRange;
    void Awake()
    {
        Name = Data.Name;
        AttackRange = Data.AttackRange;
        MoveRange = Data.MoveRange;
    }
}
