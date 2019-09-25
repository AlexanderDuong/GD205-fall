using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour
{
    public Transform key;
    public Transform PlayerPiece;
    public Transform Door;
    public TextMesh TextWin;
    bool haskey = false;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (PlayerPiece.position == key.position)
        {
            haskey = true;
            key.gameObject.SetActive(false);
            Door.gameObject.SetActive(false); //instead of using or hiding it you can deactivate it like this
            TextWin.text = "key obtained";
        }
    }
}
