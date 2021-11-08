using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Otomatik olarak bileþen ekliyor
[RequireComponent(typeof(CharacterController))]
public class Player : MonoBehaviour
{
    public float hareketHizi = 7.5f;
    public float kosuHizi = 11.5f;
    public float ziplamaGucu = 8.0f;
    public float yercekimi = 20.0f;


    CharacterController characterController;
    Vector3 moveDirection = Vector3.zero;


    [HideInInspector]
    public bool canMove = true;

    void Start()
    {
        characterController = GetComponent<CharacterController>();


    }

    void Update()
    {

        Vector3 forward = transform.TransformDirection(Vector3.forward);
        Vector3 right = transform.TransformDirection(Vector3.right);

        bool isRunning = Input.GetKey(KeyCode.LeftShift);
        float curSpeedX = canMove ? (isRunning ? kosuHizi : hareketHizi) * Input.GetAxis("Vertical") : 0; //W S
        float curSpeedY = canMove ? (isRunning ? kosuHizi : hareketHizi) * Input.GetAxis("Horizontal") : 0; //A D
        float movementDirectionY = moveDirection.y;
        moveDirection = (forward * curSpeedX) + (right * curSpeedY);

       

        if (Input.GetButton("Jump") && canMove && characterController.isGrounded)
        {
            moveDirection.y = ziplamaGucu;
        }
        else
        {
            moveDirection.y = movementDirectionY;
        }


        if (!characterController.isGrounded)
        {
            moveDirection.y -= yercekimi * Time.deltaTime;
        }

        if (characterController.isGrounded == true && characterController.velocity.magnitude > 2f && GetComponent<AudioSource>().isPlaying == false)
        {
            GetComponent<AudioSource>().volume = Random.Range(0.3f, 0.10f);
            GetComponent<AudioSource>().pitch = Random.Range(0.8f,1.5f);
            GetComponent<AudioSource>().Play();
        }



        characterController.Move(moveDirection * Time.deltaTime);



    }
}
