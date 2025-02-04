using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimator : MonoBehaviour
{
    [SerializeField] private Player Player;
   private Animator Animator;
    private const string Is_Walking = "IsWalking";
    private void Wakeup()
    {
        Animator.GetComponent<Animator>();

    }
    private void Update()
    {
        Animator.SetBool(Is_Walking, true);
    }
    
    
}
