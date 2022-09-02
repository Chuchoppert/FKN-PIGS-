using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class KeyItem : MonoBehaviour
{

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            Destroy(this.gameObject);
            GameManager.KeyScore++;
            GameManager.KeyCounterText.text = GameManager.KeyScore.ToString();

            if (GameManager.KeyScore >= 3)
            {
                SceneManager.LoadScene("Win");
            }
        }
    }

}
