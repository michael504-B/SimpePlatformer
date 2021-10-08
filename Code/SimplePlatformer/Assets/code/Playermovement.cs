using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playermovement : MonoBehaviour
{
    
    public float MoveSpeed = 3;

    public float JumpHeight = 6;

    public bool isGround = false;

    public float distToGround = 1f;

    public GameObject DeathLine;

    Vector3 StartPos;

    Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {

      float h = Input.GetAxis("Horizontal");
      float v = Input.GetAxis("Vertical");

      rb.velocity = new Vector3(h * MoveSpeed, rb.velocity.y, v);


      if (isGround && Input.GetButtonDown("Jump"))
      {
        Jump();
      }

      GroundCheck();

      DeathLineAndRespawn();  
    }

    void Jump()
    {
        rb.velocity = new Vector3(rb.velocity.x, JumpHeight, rb.velocity.z);
    }


    void GroundCheck()
    {
        if (Physics.Raycast(transform.position, Vector3.down, distToGround + 0.1f))
        {
            isGround = true;
        }
        else
        {
            isGround = false;
        }

       
    }

    void DeathLineAndRespawn()
    {
        if(transform.position.y < DeathLine.transform.position.y)
        {
            transform.position = StartPos;
        }
    }

}