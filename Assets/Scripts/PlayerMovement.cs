using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 5f;
    
    [HideInInspector] public Vector2 moveInput;
    [HideInInspector] public float lastHorizontalVector;
    [HideInInspector] public float lastVerticalVector;
    
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
        
        moveInput = new Vector2(moveX, moveY).normalized;

        if (moveInput.x != 0) lastHorizontalVector = moveX;
        if (moveInput.y != 0) lastVerticalVector = moveY;
    }
    
    private void Move()
    {
        _playerRigidbody.linearVelocity = new Vector2(moveInput.x * moveSpeed, moveInput.y * moveSpeed);
    }
}
