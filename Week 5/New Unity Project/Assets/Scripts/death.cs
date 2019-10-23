using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class death : MonoBehaviour
{
    public GameObject Player;
    public GameObject Hazard;

    
    void OnTriggerEnter(Collider other)
    {
       
        Destroy(gameObject);

    }

}
