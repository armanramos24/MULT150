using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrefabGenerator : MonoBehaviour
{

    public GameObject prefab;
    public int spawnCount = 10;
    // Start is called before the first frame update
    void Start()
    {
        float spacing = 3.0f;
        for (int i = 0; i < spawnCount; i++)
        {
            Vector3 spawnPos = new Vector3(i * spacing, 0, -5);
            Instantiate(prefab, spawnPos, Quaternion.identity);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.B))
        {
            Instantiate(prefab);
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(prefab, transform.position, transform.rotation);
        }
    }
}
