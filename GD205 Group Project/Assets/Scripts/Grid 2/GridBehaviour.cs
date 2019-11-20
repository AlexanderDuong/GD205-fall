using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridBehaviour : MonoBehaviour
{
    public int rows = 10;
    public int columns = 10;
    public int scale = 1;
    public GameObject gridPrefab;
    public Vector3 leftbottomLocation = new Vector3(0, 0, 0);

    // Start is called before the first frame update
    void Awake()
    {
        if (gridPrefab)
            GenerateGrid();
        else print
                ("missing gridprefab, please assign.");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void GenerateGrid()
    {
        for(int i = 0; i < columns; i++)
        {
            for(int j = 0; j < rows; j++)
            {
                GameObject obj = Instantiate(gridPrefab, new Vector3(leftbottomLocation.x + scale * i, leftbottomLocation.y + scale * j, leftbottomLocation.z+scale*j), Quaternion.identity);
                obj.transform.SetParent(gameObject.transform);
                obj.GetComponent<GridStats>().x = i;
                obj.GetComponent<GridStats>().y = j;
            }
        }
    }
}
