using UnityEngine;
using UnityEngine.UI;

public class Reset : MonoBehaviour
{
    public Transform playerpiece;

    public void resetball()
    {
        playerpiece.position = new Vector3(-1f, 1f, -2f);
    }
}