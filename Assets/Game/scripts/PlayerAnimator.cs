using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimator : MonoBehaviour
{
    private Animator animator;
    [SerializeField] private Player Player;
    private const string Is_Walking = "IsWalking";
    

    private void Awake()
    {
        animator = GetComponent<Animator>();
    }
    private void Update()
    {
        animator.SetBool(Is_Walking,Player.IsWalking());
    }
}
