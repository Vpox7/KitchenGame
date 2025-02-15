using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices.WindowsRuntime;
using UnityEngine;

public class PlayerInputs : MonoBehaviour
{
    private PlayerInputAction PlayerInputAction;
    private void Awake()
    {
        PlayerInputAction  = new PlayerInputAction();
        PlayerInputAction.Player.Enable();
    }
    public Vector2 GetMovementVectorNormalized()
    {
        Vector2 InputVector = PlayerInputAction.Player.Move.ReadValue<Vector2>();

     
        InputVector =InputVector.normalized;
        return InputVector;
    }
       
}
