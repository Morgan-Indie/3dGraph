using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeSpawner : MonoBehaviour
{
    public GameObject cube;

    public int xSize = 10;
    public int zSize = 10;

    // Start is called before the first frame update
    void Start()
    {
        for(int x=0; x<xSize; x++)
        {
            for (int z=0; z<zSize; z++)
            {
                Vector3 pos = new Vector3(x, 0, z);
                pos.y = Curves.Instance.Exponential(pos, xSize, xSize);
                Instantiate(cube, pos, Quaternion.identity);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
