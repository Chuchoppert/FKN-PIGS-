using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vida_PowerUp : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            if (other.GetComponent<ManagerVidas>().vidasPigs_Actual.livesThisPig < 2)
            {
                other.GetComponent<ManagerVidas>().CambioVidasPigs(1);
                Destroy(this.gameObject);
            }
        }
    }
}
