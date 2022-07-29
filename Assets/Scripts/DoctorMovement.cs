using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoctorMovement : MonoBehaviour
{

    private float speed = 40f;

    private Rigidbody2D doctor;

    void Awake(){ //initialization
        doctor = GetComponent<Rigidbody2D> ();
    }


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    // Fixed update once every couple frames
    void FixedUpdate ()
    {
        Vector2 velocity = doctor.velocity;
        velocity.x = Input.GetAxis("Horizontal") * speed;
        doctor.velocity = velocity;
    }

    void move(){

    }
}
