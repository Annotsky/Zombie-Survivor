using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
[RequireComponent(typeof(PlayerInput))]
public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 5f;
    
    private Rigidbody2D _playerRigidbody;
    private PlayerInput _playerInput;
    
    private void Awake()
    {
        _playerRigidbody = GetComponent<Rigidbody2D>();
        _playerInput = GetComponent<PlayerInput>();
    }
    
    private void FixedUpdate()
    {
        Move();
    }
    
    private void Move()
    {
        Vector2 moveInput = _playerInput.MoveInput;
        _playerRigidbody.linearVelocity = new Vector2(moveInput.x * moveSpeed, moveInput.y * moveSpeed);
    }
}
