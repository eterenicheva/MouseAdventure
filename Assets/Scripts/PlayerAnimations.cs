using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class PlayerAnimations : PlayerController
{
    private Animator _animator;
    private PlayerController _playerController;
    
    
    private void Start()
    {
        _animator = GetComponent<Animator>();
        _playerController = GetComponent<PlayerController>();
    }

    private void Update()
    {
        float directionX = _playerController.Velocity.x;
        if (directionX == 0)
            _animator.SetInteger("State", 1);
        if (directionX != 0)
        {
            _animator.SetInteger("State", 2);
            Flip(directionX);
        }
        if (!grounded)
            _animator.SetInteger("State", 3);

    }

    private void Flip(float direction)
    {
        if (direction > 0)
            transform.DOLocalRotate(new Vector3(0, 0, 0), 0);
        if (direction < 0)
            transform.DOLocalRotate(new Vector3(0, 180, 0), 0);
    }
}
