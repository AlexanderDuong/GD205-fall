using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoringUpdate : MonoBehaviour
{
    public GameObject scoreText;
    public GameObject info;
    public static int thescore;


    void Update()
    {

        scoreText.GetComponent<Text>().text = "Collected: " + thescore;


    }
}
