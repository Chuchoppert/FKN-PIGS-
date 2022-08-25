using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speedBullet = 20f;

    private void Start()
    {
        Object.Destroy(gameObject, 4.0f);
    }
    private void Update()
    {
        transform.position += transform.forward * speedBullet * Time.deltaTime;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player" || other.gameObject.tag == "Wall")
        {
            
            Destroy(gameObject);
            if (other.gameObject.tag == "Player")
            {
                //Player hp --
                Debug.Log("Player hit");
            }
        }
    }

}
