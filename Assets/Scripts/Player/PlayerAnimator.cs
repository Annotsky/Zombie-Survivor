using UnityEngine;

public class PlayerAnimator : MonoBehaviour
{
    private Animator _animator;
    private PlayerInput _playerInput;
    private SpriteRenderer _spriteRenderer;
    private static readonly int Move = Animator.StringToHash("Move");
    
    private void Awake()
    {
        _animator = GetComponent<Animator>();
        _playerInput = GetComponent<PlayerInput>();
        _spriteRenderer = GetComponent<SpriteRenderer>();
    }

    private void Update()
    {
        MoveAnimation();
    }

    private void MoveAnimation()
    {
        if (_playerInput.MoveInput.x != 0 || _playerInput.MoveInput.y != 0)
        {
            _animator.SetBool(Move, true);
            FlipSprite();
        }
        else
        {
            _animator.SetBool(Move, false);
        }
    }

    private void FlipSprite()
    {
        _spriteRenderer.flipX = _playerInput.LastHorizontalVector < 0;
    }
}
