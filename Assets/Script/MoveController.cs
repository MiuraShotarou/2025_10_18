using UnityEngine;
using UnityEngine.InputSystem;

public class MoveController : MonoBehaviour
{
    [SerializeField, Range(0, 2)] float _duratin;
    GameObject _playerObj;
    Vector2 _move;
    float _time;
    
    void Start()
    {
        _playerObj = GameDataManager.Instance.PlayerObj;
    }
    void Update()
    {
        _time += Time.deltaTime;
        if (_time > _duratin)
        {
            _time = 0;
            _move = Vector2.zero;
        }
    }
    public void OnMove(InputAction.CallbackContext context)
    {
        if (context.performed)
        {
            if (_move != context.ReadValue<Vector2>())
            {
                _move = context.ReadValue<Vector2>();
                if (_move == new Vector2(1, 0))//D入力
                {
                    _playerObj.transform.eulerAngles = new Vector3(0, 0, 270);
                }
                else if (_move == new Vector2(-1, 0))
                {
                    _playerObj.transform.eulerAngles = new Vector3(0, 0, 90);
                }
                else if (_move == new Vector2(0, 1))//W入力
                {
                    _playerObj.transform.eulerAngles = new Vector3(0, 0, 0);
                }
                else if (_move == new Vector2(0, -1))
                {
                    _playerObj.transform.eulerAngles = new Vector3(0, 0, 180);
                }
                _time = 0;
            }
        }
    }
}