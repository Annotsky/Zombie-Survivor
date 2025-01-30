using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    public Vector2 MoveInput { get; private set; }
    public float LastHorizontalVector { get; private set; }
    
    private const string HorizontalAxis = "Horizontal";
    private const string VerticalAxis = "Vertical";

    private void Update()
    {
        HandleInput();
    }

    private void HandleInput()
    {
        float moveX = Input.GetAxisRaw(HorizontalAxis);
        float moveY = Input.GetAxisRaw(VerticalAxis);

        MoveInput = new Vector2(moveX, moveY).normalized;

        SetLastHorizontalVector(moveX);
    }

    private void SetLastHorizontalVector(float moveX)
    {
        if (MoveInput.x != 0) 
            LastHorizontalVector = moveX;
    }
}
