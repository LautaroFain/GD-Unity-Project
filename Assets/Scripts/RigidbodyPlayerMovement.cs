using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RigidbodyPlayerMovement : MonoBehaviour
{

    [Header("Player RigidBody Instance")]
    [SerializeField] private Rigidbody PlayerBody;

    [Header("Basic Movement Mechanic")]
    [SerializeField] private float Speed;
    private Vector3 PlayerMovementInput;

    [Header("Jumping Mechanic")]
    [SerializeField] private float JumpForce;


    // Update is called once per frame
    void Update()
    {
        PlayerMovementInput = new Vector3(Input.GetAxis("Horizontal"), 0f, Input.GetAxis("Vertical"));

        MovePlayer();
    }

    void MovePlayer()
    {
        Vector3 MoveVector = transform.TransformDirection(PlayerMovementInput) * Speed;
        PlayerBody.velocity = new Vector3(MoveVector.x, PlayerBody.velocity.y, MoveVector.z);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            PlayerBody.AddForce(Vector3.up * JumpForce, ForceMode.Impulse);
        }
    }

}
