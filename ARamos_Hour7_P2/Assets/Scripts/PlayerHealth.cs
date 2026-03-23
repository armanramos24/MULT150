using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class PlayerHealth : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        float health = 1004;
        float poisonDamage = 125.5f;
        print(health);
        health -= poisonDamage;
        print(health);

        while (health > 0)
        {
            health -= poisonDamage;
            print(health);
        }

        if (health <= 0)
        { print("Player has been unalived!"); }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
