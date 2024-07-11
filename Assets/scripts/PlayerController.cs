using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public CharacterController cc;
    public float moveSpeed;
    public float jumpForce;
    public float gravity;
    private Vector3 moveDir;

    void Update()
    {
        moveDir = new Vector3(Input.GetAxis("Horizontal") * moveSpeed, moveDir.y, Input.GetAxis("Vertical") * moveSpeed);
        moveDir.y -= gravity * Time.deltaTime;

        if (Input.GetButtonDown("Jump") && cc.isGrounded)
        {
            moveDir.y = jumpForce; 
        }
        if (moveDir.y != 0 || moveDir.y != 0)
        {
            transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(new Vector3(moveDir.x, 0, moveDir.z)), 0.15f);
        }

        cc.Move(moveDir * Time.deltaTime);
    }
}
