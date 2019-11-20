using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SA
{

    public class GridBase : MonoBehaviour
    {


        #region Variables
        Node[,] grid;
        [SerializeField]
        float xzScale = 1f;
        [SerializeField]
        //float yScale = 2;
        Vector3 minPos;

        int maxX;
        int maxZ;
        int maxY;

        //this isn't but it helps mainly with vizualizing where the nodes are
        List<Vector3> nodeViz = new List<Vector3>();
        public Vector3 extends = new Vector3(.8f, .8f, .8f);

        #endregion

        private void Start()
        {
            ReadLevel();
        }

        void ReadLevel()
        {

            GridPosition[] gp = GameObject.FindObjectsOfType<GridPosition>();

            float minX = float.MaxValue;
            float maxX = float.MinValue;
            float minZ = minX;
            float maxZ = maxX;


            //code belows are basically boundaries for the area
            for (int i = 0; i < gp.Length; i++)
            {
                Transform t = gp[i].transform;

                #region Read Posiitons
                if(t.position.x < minX)
                {
                    minX = t.position.x;
                }

                if (t.position.x > maxX)
                {
                    maxX = t.position.x;
                }

                if (t.position.z > minZ)
                {
                    minZ = t.position.z;
                }

                if (t.position.x > maxZ)
                {
                    maxZ = t.position.z;
                }
                #endregion
            }

            //code below how many nodes we have for X and Z
            int pos_x = Mathf.FloorToInt((maxX - minX) / xzScale);
            int pos_z = Mathf.FloorToInt((maxZ - minZ) / xzScale);

            minPos = Vector3.zero;
            minPos.x = minX;
            minPos.z = minZ;

            CreateGrid(pos_x, pos_z);
        }

        //this creates the grid from one node to the other
        void CreateGrid(int pos_x, int pos_z)
        {

            grid = new Node[pos_x, pos_z];

            for (int x = 0; x < pos_x; x++)
            {
                for (int z = 0; z < pos_z; z++)
                {
                    Node n = new Node();
                    n.x = x;
                    n.z = z;

                    Vector3 tp = minPos;
                    tp.x += x * xzScale;
                    tp.z += z * xzScale;
                    n.worldPosition = tp;

                    nodeViz.Add(n.worldPosition);

                    grid[x, z] = n;
                }
            }
        }


        private void OnDrawGizmos()
        {
            Gizmos.color = Color.red;
            for (int i = 0; i < nodeViz.Count; i++)
            {
                Gizmos.DrawWireCube(nodeViz[i], extends);
            }
        }


    }

}