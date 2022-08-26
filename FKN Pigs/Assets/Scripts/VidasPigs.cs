using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class VidasPigs : MonoBehaviour
{
    public RawImage[] Lives_RawImages;
    public int livesThisPig = 2;

    public void ActualizacionDeVidas(int Valor)
    {
        if (Valor < 0) //Daño
        {
            this.livesThisPig--;
            if(this.livesThisPig <= 0)
            {
                this.livesThisPig = 0;
            }
        }

        if(Valor > 0) //Cura
        {
            this.livesThisPig++;
            if (this.livesThisPig >= 2)
            {
                this.livesThisPig = 2;
            }
        }
        ActualizacionHUDVidas();
    }

    private void ActualizacionHUDVidas()
    {
        if (livesThisPig == 2)
        {
            Lives_RawImages[1].gameObject.SetActive(true);
            Lives_RawImages[0].gameObject.SetActive(true);
        }
        else if(livesThisPig == 1)
        {
            Lives_RawImages[1].gameObject.SetActive(false);
            Lives_RawImages[0].gameObject.SetActive(true);
        }
        else
        {
            Lives_RawImages[1].gameObject.SetActive(false);
            Lives_RawImages[0].gameObject.SetActive(false);
        }
    }
}
