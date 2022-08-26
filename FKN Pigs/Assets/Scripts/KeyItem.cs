using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyItem : MonoBehaviour
{
    
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            //Destroy(this.gameObject);
            GameManager.KeyScore++;
            GameManager.KeyCounterText.text = GameManager.KeyScore.ToString();
        }
    }

}
