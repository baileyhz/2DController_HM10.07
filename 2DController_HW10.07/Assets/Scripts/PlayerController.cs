using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    GroundDetect groundDetect;

    Rigidbody2D rigidbody;

    public float playerSpeed => math.abs(rigidbody.velocity.x) ;

    public bool IsGrounded => groundDetect.IsGround;

    public bool IsFall => rigidbody.velocity.y < 0f && !IsGrounded;

    private void Awake()
    {
        groundDetect = GetComponentInChildren<GroundDetect>();
        rigidbody = GetComponent<Rigidbody2D>();
    }

    public void Move(float speed)
    {
        if (Keyboard.current.aKey.isPressed) 
        {
            speed *= -1;
            transform.localScale = new Vector3(-1f,1f,1f);
        }else
        {
            transform.localScale = new Vector3(1f, 1f, 1f);
        }
           
            
       
        SetVelocityX(speed);
    }
    public void SetVelocity(Vector3 ver)
    {
        rigidbody.velocity = ver;
    }

    public void SetVelocityX(float verX)
    {
        rigidbody.velocity = new Vector3(verX,rigidbody.velocity.y);
    }
    public void SetVelocityY(float verY)
    {
        rigidbody.velocity = new Vector3(rigidbody.velocity.x, verY);
    }
}
