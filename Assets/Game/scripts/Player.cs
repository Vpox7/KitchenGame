using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class Player : MonoBehaviour
{
    private bool isWalking;


    [SerializeField] private float MovementSpeed = 0;
    private void Update()
    {
        Vector2 NewInput = new Vector2(0, 0);
        if (Input.GetKey(KeyCode.W))
        {
            NewInput.y += 1;
        }
        if (Input.GetKey(KeyCode.S))
        {
            NewInput.y -= 1;
        }

        if (Input.GetKey(KeyCode.D))
        {
            NewInput.x += 1;
        }
        if (Input.GetKey(KeyCode.A))
        {
            NewInput.x -= 1;
        }
        NewInput = NewInput.normalized;
        Vector3 NewDir = new Vector3(NewInput.x, 0, NewInput.y);

        
        transform.position += NewDir * MovementSpeed * Time.deltaTime;
       

       isWalking = NewDir != Vector3.zero;

        float RoatationSpeed = 10f;
        transform.forward = Vector3.Slerp(transform.forward, NewDir, Time.deltaTime * RoatationSpeed);


    }


    public bool IsWalking()
    {
        return isWalking;
    }

}
 