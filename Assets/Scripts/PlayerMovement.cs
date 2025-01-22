using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 5f;

    public Vector2 MoveInput { get; private set; }
    public float LastHorizontalVector { get; private set;}
    private Rigidbody2D _playerRigidbody;
    
    private void Start()
    {
        _playerRigidbody = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        InputManager();
    }
    
    private void FixedUpdate()
    {
        Move();
    }
    
    private void InputManager()
    {
        float moveX = Input.GetAxisRaw("Horizontal");
        float moveY = Input.GetAxisRaw("Vertical");
        
        MoveInput = new Vector2(moveX, moveY).normalized;

        if (MoveInput.x != 0) LastHorizontalVector = moveX;
    }
    
    private void Move()
    {
        _playerRigidbody.linearVelocity = new Vector2(MoveInput.x * moveSpeed, MoveInput.y * moveSpeed);
    }
}
