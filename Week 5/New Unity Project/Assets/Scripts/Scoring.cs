using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Scoring : MonoBehaviour
{

    public AudioSource collected;

    void OnTriggerEnter(Collider other)
    {
        collected.Play();
        ScoringUpdate.thescore += 1;
        gameObject.SetActive(false);

    }

}
