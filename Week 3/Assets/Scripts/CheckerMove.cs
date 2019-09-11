using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckerMove : MonoBehaviour 
{

    public Transform Hazard;
    public Transform Playerpiece;
    Vector3 Pos1 = new Vector3(1f,0f,1f);    //movement for upright
    Vector3 Pos2 = new Vector3(1f,0f,-1f);   //movement for bottom right
    //Vector3 Pos3 = new Vector3(-1f, 0f, 1f);  //movement for up left
    //Vector3 Pos4 = new Vector3(-1f, 0f, -1f);   //movement for bottom right
    Vector3 pos5 = new Vector3(0f, 0f, 1f);     //movement for forward
    //Vector3 pos6 = new Vector3(0f, 0f, -1f);    //movement for backward   this isnt needed refer to line 41 and 39 for an example
    float tileset = 1f;         // dont need this up here ^ refer to lines 40 ++++ for references and compare to lines 26-38


	// Use this for initialization
	void Start () {
       
	}
	
	// Update is called once per frame
	void Update () {

        //Playerpiece.position += Pos1;     //adds this by the ammout of the Pos1 position += <-
        //if (Input.GetKeyDown("w"))              // moves upright
        //{ Playerpiece.position += Pos1; }
        //if (Input.GetKeyDown("d"))              // moves bottom right
        //{ Playerpiece.position += Pos2; }
        //if (Input.GetKeyDown("a"))              // moves up left
        //{ Playerpiece.position += Pos3; }
        //if (Input.GetKeyDown("s"))              // moves bottom left
        //{ Playerpiece.position += Pos4; }
        //if (Input.GetKeyDown("q"))
        //{ Playerpiece.position += pos5; }       // moves up
        //if (Input.GetKeyDown("e"))
        //{ Playerpiece.position += pos6; }       //moves down

        if (Input.GetKeyDown("w"))
        { Playerpiece.position += new Vector3(0f, 0f, tileset); }
        if (Input.GetKeyDown("s"))
        { Playerpiece.position += new Vector3(0f, 0f, -tileset); }
        if (Input.GetKeyDown("a"))
        { Playerpiece.position += new Vector3(-tileset, 0f, 0f); }
        if (Input.GetKeyDown("d"))
        { Playerpiece.position += new Vector3(tileset, 0f, 0f); }

        if (Playerpiece.position == Hazard.position)
        { Destroy(Hazard.gameObject);       //to destroy the game object.
            Playerpiece.position += new Vector3(0f, 0f, tileset);     // this line shall move the checker piece over after eating the other checker piece
        }        

    }
}
