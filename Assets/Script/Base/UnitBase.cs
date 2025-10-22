using UnityEngine;
/// <summary> Unitの規定クラス。汎用的なフィールドとメソッドを持つ</summary>
public abstract class UnitBase : MonoBehaviour
{
    public BulletType BulletType;
    protected Vector3Int _attackTilePos;
    /// <summary> BulletTypeに応じて攻撃UIの表示を切り替えるメソッド </summary>
    protected virtual void Shoot()
    {
        if (BulletType == BulletType.Normal)
        {
            GameDataManager.Instance.Tilemap.SetTile(_attackTilePos, GameDataManager.Instance.AttackTileBase);
        }
    }
    /// <summary> 攻撃範囲を引数の値で上書きし、予測しているエリアを再描画するメソッド </summary>
    /// <param name="updateAttackPos"></param>
    protected virtual void UpdateUnitAttackTileBase(Vector3Int updateAttackPos)
    {
        GameDataManager.Instance.Tilemap.SetTile(_attackTilePos, GameDataManager.Instance.NormalTileBase);
        GameDataManager.Instance.Tilemap.SetTile(updateAttackPos, GameDataManager.Instance.AttackTileBase);
        _attackTilePos = updateAttackPos;
    }
}
