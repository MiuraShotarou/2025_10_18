using UnityEngine;

public class ShooterController : MonoBehaviour
{
    [SerializeField] GameObject _bulletPrefab;

    void Shoot()
    {
        if (GameDataManager.Instance.BulletType == BulletType.Normal)
        {
            
        }
    }
}
