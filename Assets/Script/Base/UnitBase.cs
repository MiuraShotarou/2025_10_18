using UnityEngine;
/// <summary> Unitの規定クラス。汎用的なフィールドとメソッドを持つ</summary>
public abstract class UnitBase : MonoBehaviour
{
    public BulletType BulletType;
    // protected Vector3Int _attackTilePos;
    protected Transform Muzzle;
    /// <summary> BulletTypeに応じて攻撃UIの表示を切り替えるメソッド </summary>
    protected virtual void Shoot()
    {
        if (BulletType == BulletType.Normal)
        {
            GameDataManager.Instance.Tilemap.SetTile(Vector3Int.RoundToInt(Muzzle.position), GameDataManager.Instance.AttackTileBase);
        }
    }
}
