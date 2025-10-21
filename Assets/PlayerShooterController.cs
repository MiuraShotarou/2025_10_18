using UnityEngine;

public class PlayerShooterController : ShooterControllerBase
{
    Vector3Int _beforeTilePos;
    protected override void Shoot()
    {
        GameDataManager.Instance.Tilemap.SetTile(_beforeTilePos, GameDataManager.Instance.NormaltileBase);
        base.Shoot();
        _beforeTilePos = _targetTilePos;
    }
}
