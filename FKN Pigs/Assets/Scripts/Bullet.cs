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
            if (other.gameObject.tag == "Player")
            {
                other.GetComponent<ManagerVidas>().CambioVidasPigs(-1);

                Debug.Log("Player hit");
            }
            Destroy(gameObject);     
        }
    }

}
