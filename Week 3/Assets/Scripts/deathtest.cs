using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class deathtest : MonoBehaviour
{
    public AudioClip death;
    public AudioSource died;

    public Transform Playerpiece;
    public Transform Death;
    public TextMesh TextWin;

    // Start is called before the first frame update
    void Start()
    {
        died = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {

        if (Playerpiece.position == Death.position)
        {
            //Destroy(Playerpiece.gameObject);
            Playerpiece.position = new Vector3(2f, 1f, -1f);
            TextWin.text = "You Died";
            died.PlayOneShot(death, 0.1f);
        }

        if (Playerpiece.position == new Vector3(3f, 1f, -1f))
        {
            TextWin.text = "WelcomeBack";
        }
        
    }
}
