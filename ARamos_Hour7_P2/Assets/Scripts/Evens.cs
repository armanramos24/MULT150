using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Evens : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int count = 22;

        while (count <= 100)
        {
            print(count);
            count++;
            count++;
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
