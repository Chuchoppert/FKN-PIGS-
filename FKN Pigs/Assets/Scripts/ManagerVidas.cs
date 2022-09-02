using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManagerVidas : MonoBehaviour
{
    public Puerconios puerconios;
    public VidasPigs vidasPigs_Actual;
    public List<VidasPigs> TodosLosPigs;
    public int PigSeleccionado;

    public ManagerRotacion managerRotacion;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.L))
        {
            if(PigSeleccionado < TodosLosPigs.Count - 1)
            {
                PigSeleccionado++;
                managerRotacion.ChangePosOfPigs(1);
            }
        }
        else if (Input.GetKeyDown(KeyCode.K))
        {
            if(PigSeleccionado > 0)
            {
                PigSeleccionado--;
                managerRotacion.ChangePosOfPigs(-1);
            }
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
            managerRotacion.ChangePosOfPigs(0);
        }
    }


}
