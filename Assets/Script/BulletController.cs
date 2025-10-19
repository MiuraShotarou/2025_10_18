using UnityEngine;
[RequireComponent(typeof(Rigidbody2D))]
public class BulletController : MonoBehaviour
{
    /// <summary>弾の発射方向</summary>
    [SerializeField] Vector2 _direction = Vector2.up;
    /// <summary>弾の飛ぶ速度</summary>
    [SerializeField] float _bulletSpeed = 10f;
    Rigidbody2D _rb;
    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
        Vector3 v = _direction.normalized * _bulletSpeed; // 弾が飛ぶ速度ベクトルを計算する
        _rb.linearVelocity = v;                            // 速度ベクトルを弾にセットする
    }
}
