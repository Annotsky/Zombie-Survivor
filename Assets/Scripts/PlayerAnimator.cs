using UnityEngine;

public class PlayerAnimator : MonoBehaviour
{
    private Animator _animator;
    private PlayerMovement _playerMovement;
    private SpriteRenderer _spriteRenderer;
    
    private void Start()
    {
        _animator = GetComponent<Animator>();
        _playerMovement = GetComponent<PlayerMovement>();
        _spriteRenderer = GetComponent<SpriteRenderer>();
    }

    private void Update()
    {
        if (_playerMovement.moveInput.x != 0 || _playerMovement.moveInput.y != 0)
        {
            _animator.SetBool("Move", true);
            FlipSprite();
        }
        else _animator.SetBool("Move", false);
    }
    
    private void FlipSprite()
    {
        _spriteRenderer.flipX = _playerMovement.lastHorizontalVector < 0;
    }
}
