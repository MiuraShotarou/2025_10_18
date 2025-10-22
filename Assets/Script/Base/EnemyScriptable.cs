using UnityEngine;
[CreateAssetMenu(fileName = "EnemyData", menuName = "Scriptable")]
public class EnemyScriptable : ScriptableObject
{
    [SerializeField] public string Name;
    [SerializeField] public int[] AttackRange;
    [SerializeField] public int MoveRange;
    
}
