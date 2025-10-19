using UnityEngine;
using UnityEngine.InputSystem;

public class ShooterController : MonoBehaviour
{
    [SerializeField] GameObject _bulletPrefab;
    [SerializeField] Transform _muzzlePosition;
    void Update()
    {
        if (Mouse.current.leftButton.wasPressedThisFrame)
        {
            Shoot();
        }
    }
    void Shoot()
    {
        if (GameDataManager.Instance.BulletType == BulletType.Normal)
        {
            Instantiate(_bulletPrefab, _muzzlePosition);
        }
    }
}