using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour
{
    public Transform key;
    public Transform PlayerPiece;
    public Transform Door;
    


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (PlayerPiece.position == key.position)
        {
            key.position = new Vector3(20f, 20f, 20f);
            Door.position = new Vector3(20f, 20f, 20f);
        }
    }
}
