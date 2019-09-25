using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckerMove : MonoBehaviour 
{
    public AudioClip Move;
    public AudioSource sauce;

    public Transform Reverse;
    public Transform Ice;
    public Transform Gravity;
   // public Transform Win;   (in a different Script file)
    public Transform Playerpiece;
    //public Transform Death; (in a different script file)
    public Transform obstacle;
    public Transform Hazard;
    public TextMesh TextWin;
    float tileset = 1f;         // 30+ to figure out movement


	// Use this for initialization
	void Start () {
        sauce = GetComponent<AudioSource>();
    }
	
	// Update is called once per frame
	void Update () {
        Vector3 newPos = Playerpiece.position;  //new movement command that helps with movement see lines 48 + for better explaination.
        
        if (Input.GetKeyDown("w"))
        { newPos += new Vector3(0f, 0f, tileset);
            sauce.PlayOneShot(Move, 0.2f);
        }
        if (Input.GetKeyDown("s"))
        { newPos += new Vector3(0f, 0f, -tileset);
            sauce.PlayOneShot(Move, 0.2f);
        }
        if (Input.GetKeyDown("a"))
        { newPos += new Vector3(-tileset, 0f, 0f);
            sauce.PlayOneShot(Move, 0.2f);
        }
        if (Input.GetKeyDown("d"))
        { newPos += new Vector3(tileset, 0f, 0f);
            sauce.PlayOneShot(Move, 0.2f);
        }



        if (obstacle.position != newPos)      //because of the code on 33 helps remove need to block movement for all directions
        {
            Playerpiece.position = newPos;
        }

        if (Playerpiece.position == Hazard.position)
        {
            //Destroy(Hazard.gameObject);       //to destroy the game object.
            Playerpiece.position += new Vector3(0f, 0f, tileset);     // this line shall move the checker piece over after eating the other checker piece
        }

        if (Playerpiece.position == Reverse.position)
        {
            Playerpiece.position += new Vector3(0f, 0f, -tileset);
        }
        if (Playerpiece.position == Ice.position)
        {
            Playerpiece.position += new Vector3(0f, tileset, 0f);
        }
        if (Playerpiece.position == Gravity.position)
        {
            Playerpiece.position += new Vector3(0f, -tileset, 0f);
        }
    }
}