using System.Linq;
using UnityEngine;

public class EnemyGenerator : MonoBehaviour
{
    Vector3Int _testGeneratePosition;
    string _testGenerateEnemyName;
    /// <summary>
    /// Test
    /// </summary>
    void Start()
    {
        //どこかにオブジェクト生成のポジションを保持しておく必要がある
        GameObject enemyObj = Instantiate(GameDataManager.Instance.EnemyTupleArray.FirstOrDefault(enemy => enemy.name.Contains(_testGenerateEnemyName)).obj, _testGeneratePosition, Quaternion.identity);
    }
}
