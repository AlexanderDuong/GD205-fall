using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playermove : MonoBehaviour
{
    public float Speed;
    public float force;
    public float toss;

    // Update is called once per frame
    void Update()
    {
        PlayerMovement();

        if (Input.GetMouseButton(0))
        {

            Ray laser = Camera.main.ScreenPointToRay(Input.mousePosition);

            RaycastHit hit = new RaycastHit();

            if (Physics.Raycast(laser, out hit, 10000f))
            {
                Debug.Log("you hit" + hit.transform.gameObject.name + " with the ray");

                if (hit.rigidbody)
                {
                    hit.rigidbody.AddForce(0f, force, 0f);
                }
            }
        }

        if (Input.GetMouseButton(1))
        {

            Ray laser = Camera.main.ScreenPointToRay(Input.mousePosition);

            RaycastHit hit = new RaycastHit();

            if (Physics.Raycast(laser, out hit, 10000f))
            {
                Debug.Log("you hit" + hit.transform.gameObject.name + " with the ray");

                if (hit.rigidbody)
                {
                    hit.rigidbody.AddForce(0f, 0f, toss);
                }
            }
        }
    }

    void PlayerMovement()
    {
        float hor = Input.GetAxis("Horizontal");
        //float ver = Input.GetAxis("Vertical");
        Vector3 playerMovement = new Vector3(hor, 0f, 0f) * Speed * Time.deltaTime;
        transform.Translate(playerMovement, Space.Self);

    }

}
