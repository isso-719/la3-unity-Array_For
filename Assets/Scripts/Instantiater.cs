using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instantiater : MonoBehaviour
{
    public GameObject[] prefabs = new GameObject[3];

    // Start is called before the first frame update
    void Start()
    {
        //Instantiate(prefabs[0], new Vector3(0, 0, 0), Quaternion.identity);
        //Instantiate(prefabs[1], new Vector3(5, 0, 0), Quaternion.identity);
        //Instantiate(prefabs[2], new Vector3(10, 0, 0), Quaternion.identity);

        for (int i = 0; i < prefabs.Length; i++)
        {
            Instantiate(prefabs[i], new Vector3(i * 5, 0, 0), Quaternion.identity);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
