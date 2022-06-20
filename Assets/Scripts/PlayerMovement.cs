using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementFPP : MonoBehaviour
{
    public CharacterController controller;

    public float speed = 12f;
    public float gravity = -9.81f;
    public float jumpHeight = 3f;

    public Transform groundCheck;
    public float groundDistance = 0.4f;
    public LayerMask groundMask;

   

    //audio
    float dirX;
    [SerializeField]
    AudioSource audioSrc;
    bool isMoving = false;

    Vector3 velocity;
    bool isGrounded;



    void Update()
    {
        isGrounded = Physics.CheckSphere(groundCheck.position, groundDistance, groundMask);
        if (isGrounded && velocity.y < 0)
        {
            velocity.y = -2f;
        }

        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 move = transform.right * x + transform.forward * z;

        controller.Move(move * speed * Time.deltaTime);

        if (Input.GetButtonDown("Jump") && isGrounded)
        {
            velocity.y = Mathf.Sqrt(jumpHeight * -2f * gravity);
        }

        velocity.y += gravity * Time.deltaTime;

        controller.Move(velocity * Time.deltaTime);


        //audio
        if (x != 0 || z != 0)
            isMoving = true;
        else
            isMoving = false;


        if (isMoving)
        {
            if (!audioSrc.isPlaying)
                audioSrc.Play();
        }
        else
            audioSrc.Stop();

    }
    void Start()
    {
        transform.position.Set(134, 38, 96);

        audioSrc = GetComponent<AudioSource>();

    }
}
