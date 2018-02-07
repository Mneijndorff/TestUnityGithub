using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Array : MonoBehaviour
{
    public GameObject[] items;
    GameObject[] slots = new GameObject[4];

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void ButtonClick()
    {
        DestoyItemsArray();
        Instantiate(items[Random.Range(0, 3)], new Vector3(-6, -2, 0), Quaternion.identity);
    }

    public void SpawnRandom()
    {
        DestoyItemsArray();

        for (int i = 0; i < 4; i++)
        {
            slots[i] = Instantiate(items[Random.Range(0, 3)], new Vector3(-2 * i, -2, 0), Quaternion.identity) as GameObject;
        }
        CubeRotator();
    }


    public void DestoyItemsArray()
    {
        for (int i = 0; i < 4; i++)
        {
            Destroy(slots[i]);
        }
    }

    public void CubeRotator()
    {
        for (int i = 0; i < 4; i++)
        {
            if(slots[i].name == "Cube 1(Clone)" )
            {
                slots[i].transform.Rotate(-30, 0, 0);
            }
        }
    }
}
