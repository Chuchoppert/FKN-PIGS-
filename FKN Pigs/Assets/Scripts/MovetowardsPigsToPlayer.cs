using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovetowardsPigsToPlayer : MonoBehaviour
{
    public Transform PlayerCam; 

    void Update()
    {
        this.gameObject.transform.position = Vector3.MoveTowards(this.gameObject.transform.position, PlayerCam.position, 1);
    }
}
