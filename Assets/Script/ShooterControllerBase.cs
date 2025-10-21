using UnityEngine;
using UnityEngine.InputSystem;
/// <summary> 撃つ規定クラス </summary>
public abstract class ShooterControllerBase : MonoBehaviour
{
    protected Vector3Int _playerTilePos;
    protected Vector3Int _targetTilePos;
    protected virtual void Update()
    {
        if (Mouse.current.leftButton.wasPressedThisFrame)
        {
            Shoot();
        }
    }
    protected virtual void Shoot()
    {
        if (GameDataManager.Instance.BulletType == BulletType.Normal)
        {
            GameDataManager.Instance.Tilemap.SetTile(_targetTilePos, GameDataManager.Instance.AttackTileBase);
        }
    }
}