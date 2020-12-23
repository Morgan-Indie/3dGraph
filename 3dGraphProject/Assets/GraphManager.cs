using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GraphManager : MonoBehaviour
{
    public GameObject indexMarker;

    private float offSetAmount = 1.5f;

    public float spacingRatio = 3f;

    //array with 2 rows, 0 for X indices, 1 for Z indices
    public GameObject[,] markers;

    // Start is called before the first frame update
    void Start()
    {
        markers = new GameObject[5, 2];
        for (int i=0; i<5; i++)
        {
            for (int j=0; j<2; j++)
            {
                markers[i, j] = Instantiate(indexMarker, Vector3.zero, indexMarker.transform.rotation);
            }
        }

        SetupMarkers();
    }
    public void SetupMarkers()
    {
        float spacing = Vector3.Distance(Camera.main.transform.position, Vector3.zero) / spacingRatio;
        
        for (int i=0; i<markers.GetLength(0); i++)
        {
            markers[i, 0].transform.position = new Vector3(spacing * i, 0, -offSetAmount);
            markers[i, 1].transform.position = new Vector3(-offSetAmount, 0, spacing * i);

            markers[i, 0].GetComponentInChildren<Text>().text = i.ToString();
            markers[i, 1].GetComponentInChildren<Text>().text = i.ToString();
        }
    }
}
