using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
        double healthpoints = 3992;
        healthpoints = UsePotion(healthpoints, 400);
        print(healthpoints);
        healthpoints = UsePotion(healthpoints, 400);
        print(healthpoints); 
        healthpoints = UsePotion(healthpoints, 400);
        print(healthpoints);
        healthpoints = UsePotion(healthpoints, 400);
        print(healthpoints);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    double UsePotion(double health, double potion)
    {
        return health + potion;
    }
}
