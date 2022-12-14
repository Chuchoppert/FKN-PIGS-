using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Butcher_RecepcionDaño : MonoBehaviour
{
    GameManager GameManager;

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Dash")
        {
                Destroy(transform.parent.gameObject);
                GameManager.GuardScore++;
                GameManager.GuardCounterText.text = GameManager.GuardScore.ToString();   
        }
        else if(other.gameObject.tag == "Player")
        {
            if (!other.GetComponent<ManagerVidas>().puerconios.DashIsActivate)
            {
                Debug.Log("CambioVidas");
                other.GetComponent<ManagerVidas>().CambioVidasPigs(-1);
            }
        }
    }
}
