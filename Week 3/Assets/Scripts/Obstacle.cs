using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    public Transform obstacleT;
    public Transform Playerpiece;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 newPos = Playerpiece.position;
        if (obstacleT.position != newPos)      //because of the code on 33 helps remove need to block movement for all directions
        {
            Playerpiece.position = newPos;
        }

    }
}
