using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    public Vector2 MoveInput { get; private set; }
    public float LastHorizontalVector { get; private set; }

    private void Update()
    {
        HandleInput();
    }

    private void HandleInput()
    {
        float moveX = Input.GetAxisRaw("Horizontal");
        float moveY = Input.GetAxisRaw("Vertical");

        MoveInput = new Vector2(moveX, moveY).normalized;

        if (MoveInput.x != 0) 
            LastHorizontalVector = moveX;
    }
}
