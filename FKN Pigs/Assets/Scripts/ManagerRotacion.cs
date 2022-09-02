using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManagerRotacion : MonoBehaviour
{
    public Transform[] Posiciones;

    public ManagerVidas managerVidas;

    public int[] PosPigs = new int[3]; //0 = pig1, 1 = pig2, 2 = pig3

    private void Awake()
    {
        //Setear posiciones;
        managerVidas.TodosLosPigs[0].transform.position = Posiciones[0].position;
        managerVidas.TodosLosPigs[1].transform.position = Posiciones[1].position;
        managerVidas.TodosLosPigs[2].transform.position = Posiciones[2].position;

        PosPigs[0] = 1;
        PosPigs[1] = 2;
        PosPigs[2] = 3;
    }

    public void ChangePosOfPigs(int TeclaPulsada) //Si fue izquierda es -1, si fue derecha es +1
    {
        if(managerVidas.TodosLosPigs.Count > 2) //funcion con 3 cerdos vivos//
        {
            int[] preResult = new int[3];
            int i = 0;
            foreach(int elemento in PosPigs)
            {
                preResult[i] = elemento + TeclaPulsada;
                if (preResult[i] > 3)
                {
                    preResult[i] = 1;
                }
                else if (preResult[i] <= 0)
                {
                    preResult[i] = 3;
                }
                i++;
            }
            PosPigs = preResult;

            CheckPosPig1();
            CheckPosPig2();
            CheckPosPig3();
        }
        else if(managerVidas.TodosLosPigs.Count == 2)
        {
            int[] preResult = new int[3];
            int i = 0;
            foreach (int elemento in PosPigs)
            {
                preResult[i] = elemento + TeclaPulsada;
                if (preResult[i] > 2)
                {
                    preResult[i] = 1;
                }
                else if (preResult[i] <= 0)
                {
                    preResult[i] = 2;
                }
                i++;
            }
            PosPigs = preResult;

            CheckPosPig1();
            CheckPosPig2();
        }
        else
        {
            PosPigs[0] = 1;
            CheckPosPig1();
        }
    }

    public void CheckPosPig1()
    {
        //Caso primer puerco
        if (PosPigs[0] == 1)
        {
            managerVidas.TodosLosPigs[0].transform.position = Posiciones[0].position;
            managerVidas.vidasPigs_Actual = managerVidas.TodosLosPigs[0];
        }
        else if (PosPigs[0] == 2)
        {
            managerVidas.TodosLosPigs[0].transform.position = Posiciones[1].position;
        }
        else if (PosPigs[0] == 3)
        {
            managerVidas.TodosLosPigs[0].transform.position = Posiciones[2].position;
        }
    }

    public void CheckPosPig2()
    {
        //Caso segundo puerco
        if (PosPigs[1] == 1)
        {
            managerVidas.TodosLosPigs[1].transform.position = Posiciones[0].position;
            managerVidas.vidasPigs_Actual = managerVidas.TodosLosPigs[1];
        }
        else if (PosPigs[1] == 2)
        {
            managerVidas.TodosLosPigs[1].transform.position = Posiciones[1].position;
        }
        else if (PosPigs[1] == 3)
        {
            managerVidas.TodosLosPigs[1].transform.position = Posiciones[2].position;
        }
    }

    public void CheckPosPig3()
    {
        //Caso tercer puerco
        if (PosPigs[2] == 1)
        {
            managerVidas.TodosLosPigs[2].transform.position = Posiciones[0].position;
            managerVidas.vidasPigs_Actual = managerVidas.TodosLosPigs[2];
        }
        else if (PosPigs[2] == 2)
        {
            managerVidas.TodosLosPigs[2].transform.position = Posiciones[1].position;
        }
        else if (PosPigs[2] == 3)
        {
            managerVidas.TodosLosPigs[2].transform.position = Posiciones[2].position;
        }
    }
}
