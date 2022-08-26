using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Puerconios : MonoBehaviour
{
    public float SpeedPig;
    Rigidbody rb;

    float InputY;
    float InputX;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        InputY = Input.GetAxis("Vertical");
        InputX = Input.GetAxis("Horizontal");

        if (Input.GetAxisRaw("Vertical") != 0 || Input.GetAxisRaw("Horizontal") != 0)
        {
            rb.velocity = new Vector3(-InputX, 0.0f, -InputY) * SpeedPig;
        }

        if (Input.GetAxisRaw("Horizontal") == 0 && Input.GetAxis("Vertical") != 0)  //delante
        {
            transform.rotation = new Quaternion(0, 0, 0, 1); //mira hacia delante
        }

        if (Input.GetAxisRaw("Horizontal") == -1)
        {
            transform.rotation = new Quaternion(0, -0.258819014f, 0, 0.965925872f);
        }
        else if (Input.GetAxisRaw("Horizontal") == 1)
        {
            transform.rotation = new Quaternion(0, 0.258819103f, 0, 0.965925813f);
        }

        //add lerp
    }
}
