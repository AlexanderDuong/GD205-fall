using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundEffects : MonoBehaviour
{
    public AudioClip Finish;
    public AudioSource End;
    public Transform Playerpiece;
    public Transform Win;
    public TextMesh TextWin;


    // Start is called before the first frame update
    void Start()
    {
        End = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Playerpiece.position == Win.position)
        {
            TextWin.text = "You WIN";
            Playerpiece.position = new Vector3(8f, 1f, 2f);
            End.PlayOneShot(Finish, 0.2f);
        }
    }
}
