using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneReset : MonoBehaviour
{
    public void SceneRestart()
    {
        SceneManager.LoadScene(0);
        ScoringUpdate.thescore = 0;
    }
}
