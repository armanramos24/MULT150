using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightScript : MonoBehaviour
{
    // Start is called before the first frame update
    Light lightComponent;
    void Start()
    {
        lightComponent = GetComponent<Light>();
        lightComponent.type = LightType.Point;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.L))
            lightComponent.intensity = Mathf.PingPong(Time.time, 8);
        else if (Input.GetKeyDown(KeyCode.L))
            lightComponent.intensity = Mathf.PingPong(Time.time, 0);
    }
}