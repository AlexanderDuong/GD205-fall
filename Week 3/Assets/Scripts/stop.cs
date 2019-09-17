using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stop : MonoBehaviour
{
    public Transform Playerpiece;
    public Transform Reverse;
    float tileset = 1f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Playerpiece.position == Reverse.position)
        {
            Playerpiece.position += new Vector3(0f, 0f, -tileset);
        }
    }
}
