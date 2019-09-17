using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class deathtest : MonoBehaviour
{

    public Transform Playerpiece;
    public Transform Death;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (Playerpiece.position == Death.position)
        {
            Destroy(Playerpiece.gameObject);
        }
    }
}
