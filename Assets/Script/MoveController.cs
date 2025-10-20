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
                int x = (int)_move.x;
                int y = (int)_move.y;
                _time = 0;
            }
        }
    }
}