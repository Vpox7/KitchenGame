using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField]private float MovementSpeed = 7f;
    [SerializeField] private PlayerInputs playerInput;
    private bool isWalking;
  private void Update()
  {
       Vector2 InputVector=playerInput.GetMovementVectorNormalized();   
        Vector3 MoveDir=new Vector3(InputVector.x,0,InputVector.y);
        transform.position += MoveDir*Time.deltaTime*MovementSpeed;

        isWalking=MoveDir!=Vector3.zero;

        float rotationspeed = 9f;
        transform.forward=Vector3.Slerp(transform.forward,MoveDir, Time.deltaTime*rotationspeed); 

  }

    public bool IsWalking()
    {
        return isWalking;
    }
    
        
            
}
