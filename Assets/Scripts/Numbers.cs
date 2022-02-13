using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Numbers : MonoBehaviour
{
    int[] numbers = { 1, 10, 100 };

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 1; i <= 100; i++)
        {
            Debug.Log(i);
        }

        for (int i = 0; i < numbers.Length; i++)
        {
            Debug.Log(numbers[i] * 2);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
