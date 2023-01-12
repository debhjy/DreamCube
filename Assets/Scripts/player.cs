using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.TextCore.Text;

public class player : MonoBehaviour
{

    Vector3 direction;
    public float speed = 1f;
    public float gravity = 9f;
    CharacterController characterController;
    public float jumpForce = 1f;

    private void Awake()
    {
        characterController = GetComponent<CharacterController>();


    }
    //reset direction
    private void OnEnable()
    {
        direction = Vector3.zero;
    }

    private void OnDisable()
    {
        CancelInvoke();
    }

    // Update is called once per frame
    void Update()
    {
        direction += Vector3.down * gravity * Time.deltaTime;

        if (characterController.isGrounded)
        {
            //reset again
            direction = Vector3.down;

            if (Input.GetButton("Jump"))
            {
                direction = Vector3.up * jumpForce;
            }
        }

        characterController.Move(direction * Time.deltaTime);

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Collider"))
        {
            FindObjectOfType<gameHandler>().GameOver();

        }
    }
}

