using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
    Animator myAnim;

    // Start is called before the first frame update
    void Start()
    {
        myAnim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        myAnim.SetInteger("Idle", -1);

        if (Input.GetKey(KeyCode.W))
        {
            myAnim.SetInteger("Idle", 1);
        }
        else
        {
            myAnim.SetInteger("Idle", -1);
        }

        if (Input.GetKey(KeyCode.A))
        {
            myAnim.SetInteger("Left", 1);
        }
        else
        {
            myAnim.SetInteger("Left", 0);
        }

        if (Input.GetKey(KeyCode.D))
        {
            myAnim.SetInteger("Right", 1);
        }
        else
        {
            myAnim.SetInteger("Right", 0);
        }

        if (Input.GetKey(KeyCode.Q))
        {
            myAnim.SetInteger("Left Strafe", 1);
        }
        else
        {
            myAnim.SetInteger("Left Strafe", 0);
        }

        if (Input.GetKey(KeyCode.E))
        {
            myAnim.SetInteger("Right Strafe", 1);
        }
        else
        {
            myAnim.SetInteger("Right Strafe", 0);
        }

        if ( Input.GetKey(KeyCode.LeftShift))
        {
            myAnim.SetInteger("Run", 2);
        }
        else
        {
            myAnim.SetInteger("Run", 0);
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            myAnim.SetInteger("Jump", 1);
        }
        else
        {
            myAnim.SetInteger("Jump", 0);
        }
    }
}