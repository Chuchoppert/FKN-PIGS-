using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Butcher : MonoBehaviour
{
    GameObject Player;
    public float ShootInterval = 1.5f;
    public GameObject bullet_Prefab;

    public Transform ShootingPoint;
    public GameObject ButcherGo;

    public float counter;

    private bool onetime = false;

    private void Update()
    {
        
        if (Player != null)
        {
            LookPlayer();
            counter += Time.deltaTime;

            if (counter >= ShootInterval)
            {
                ShootPlayer();
                counter = 0;
            }

        }
        

    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            Player = other.gameObject;
            
            Debug.Log("Player found");
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            Player = null;
            onetime = false;
            Debug.Log("Player lost");
        }
    }

    void LookPlayer()
    {
        //Debug.DrawRay(gameObject.transform.position, gameObject.transform.forward * 100, Color.red);
        //Debug.Log("Looking for player");
        if (Player != null)
        {
            ButcherGo.transform.LookAt(Player.transform);     
        }
    }

    void ShootPlayer()
    { 
        GameObject bullet = Instantiate<GameObject>(bullet_Prefab);
        bullet.transform.position = ShootingPoint.transform.position;
        //bullet.transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z);

        if (Player != null)
        {
            bullet.transform.LookAt(Player.transform.position);
        }
            
    }


}
