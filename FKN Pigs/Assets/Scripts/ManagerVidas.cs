using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManagerVidas : MonoBehaviour
{
    public Puerconios puerconios;
    public VidasPigs vidasPigs_Actual;
    public List<VidasPigs> TodosLosPigs;
    public int PigSeleccionado;


    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.L))
        {
            if(PigSeleccionado > 0)
            {
                PigSeleccionado++;
                //PigSeleccionado = 0;
            }

            vidasPigs_Actual = TodosLosPigs[PigSeleccionado];
        }

        if (Input.GetKeyDown(KeyCode.K))
        {
            if(PigSeleccionado < TodosLosPigs.Count)
            {
                PigSeleccionado--;
            }
            //if (PigSeleccionado >= TodosLosPigs.Length)
            //{
            //    PigSeleccionado = TodosLosPigs.Length;
            //}

            vidasPigs_Actual = TodosLosPigs[PigSeleccionado];
        }   
    }

    public void CambioVidasPigs(int Valor)
    {
        vidasPigs_Actual.ActualizacionDeVidas(Valor);

        if(vidasPigs_Actual.livesThisPig <= 0)
        {
            TodosLosPigs.Remove(vidasPigs_Actual);
            Destroy(vidasPigs_Actual.gameObject);
            vidasPigs_Actual = TodosLosPigs[0];          
        }
    }


}
