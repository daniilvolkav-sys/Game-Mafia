using UnityEngine;

public class movement : MonoBehaviour
{
    public CharacterController controller;
    public float walkspeed = 10f;
    public float gravity = -9.81f;
    public float jumpheight = 3f;

    public Transform groundCheck;
    public float groundDistance = 0.4f;
    public LayerMask groundMask;

    Vector3 velocity;
    bool grounded;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    

    // Update is called once per frame
    void Update()
    {
        grounded = Physics.CheckSphere(groundCheck.position, groundDistance, groundMask);

        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 move = transform.right * x + transform.forward * z;

        controller.Move(move * walkspeed * Time.deltaTime);

        
    }
}
