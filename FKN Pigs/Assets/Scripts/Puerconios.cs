using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Puerconios : MonoBehaviour
{
    //public ManagerVidas managerVidas;

    public float SpeedPig;
    public float SpeedRotationPig;
    public float StepRotationPig;
    Rigidbody rb;

    float InputY;
    float InputX;

    public float IntervalDash = 3.0f;
    public float counter = 0.0f;
    public float SpeedDashPig;
    public bool DashIsActivate; 
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        InputY = Input.GetAxis("Vertical");
        InputX = Input.GetAxis("Horizontal");

        counter += Time.deltaTime;

        if (Input.GetAxisRaw("Vertical") != 0)//Input.GetAxisRaw("Vertical") != 0 || Input.GetAxisRaw("Horizontal") != 0)
        {
            //transform.Translate(new Vector3(0.0f, 0.0f, -InputY) * SpeedPig);
            //rb.AddForce(new Vector3(0.0f, 0.0f, -InputY).normalized * SpeedPig, ForceMode.Force);
            //rb.AddForce(new Vector3(-InputX, 0.0f, -InputY).normalized * SpeedPig, ForceMode.Force);
            //rb.velocity = new Vector3(0.0f, 0.0f, -InputY) * SpeedPig;
            //rb.MovePosition(transform.position + new Vector3(-InputX, 0.0f, -InputY) * SpeedPig * Time.deltaTime);


            if (Input.GetKeyDown(KeyCode.LeftShift) && counter >= IntervalDash)
            {
                DashIsActivate = true;
                Vector3 Dashdirection = new Vector3(0.0f, 0.0f, -1.0f);
                Dashdirection = transform.TransformDirection(Dashdirection);

                rb.AddForce(Dashdirection * SpeedDashPig, ForceMode.Impulse);
                counter = 0;
                Invoke("DeactivateDash", 0.3f);
            }
            else
            {
                Vector3 movedirection = new Vector3(0.0f, 0.0f, -InputY);
                movedirection = transform.TransformDirection(movedirection);

                rb.MovePosition(transform.position + movedirection * SpeedPig); //* SpeedPig * Time.deltaTime);
            }           
        }

        if (Input.GetAxisRaw("Horizontal") == 0 && Input.GetAxis("Vertical") != 0)  //delante
        {
            //transform.rotation = transform.rotation;//new Quaternion(0, 0, 0, 1); //mira hacia delante
        }

        if (Input.GetAxisRaw("Horizontal") == -1)
        {
            transform.Rotate(Vector3.down, SpeedRotationPig);
            //transform.LeanRotateAroundLocal(Vector3.up, StepRotationPig, SpeedRotationPig);
            //rb.MoveRotation(Quaternion.Euler(transform.rotation.x, transform.rotation.y, transform.rotation.z) * Quaternion.Euler(0.0f, -SpeedRotationPig * Time.deltaTime, 0.0f));
            //rb.MoveRotation(Quaternion.Euler(0.0f, -SpeedRotationPig, 0.0f));
            //rb.AddTorque(new Vector3(0.0f, -SpeedRotationPig, 0.0f), ForceMode.Force);
            //LeanTween.rotateAround(gameObject, Vector3.up, StepRotationPig,SpeedRotationPig); //= new Quaternion(0, -0.258819014f, 0, 0.965925872f);
        }
        else if (Input.GetAxisRaw("Horizontal") == 1)
        {
            transform.Rotate(Vector3.up, SpeedRotationPig);
            //transform.LeanRotateAroundLocal(Vector3.down, StepRotationPig, SpeedRotationPig);
            //rb.MoveRotation(Quaternion.Euler(transform.rotation.x, transform.rotation.y, transform.rotation.z) * Quaternion.Euler(0.0f, SpeedRotationPig * Time.deltaTime, 0.0f));
            //rb.MoveRotation(Quaternion.Euler(0.0f, SpeedRotationPig, 0.0f));
            //rb.AddTorque(new Vector3(0.0f, SpeedRotationPig, 0.0f), ForceMode.Force);
            //LeanTween.rotateAround(gameObject, Vector3.down, StepRotationPig, SpeedRotationPig); //transform.rotation = new Quaternion(0, 0.258819103f, 0, 0.965925813f);
        }

        //add lerp
    }

    private void DeactivateDash()
    {
        DashIsActivate = false;
    }
}
