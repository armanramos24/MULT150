using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class MyBirthday : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        for (int day = 1; day <= 31; day += 1)
        {
            print(day);
            if (day == 28)
            {
                day++;
                print("It's my birthday!");
            }
            
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
