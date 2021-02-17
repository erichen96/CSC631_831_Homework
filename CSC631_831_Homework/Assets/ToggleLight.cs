using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ToggleLight : MonoBehaviour
{
    public GameObject directionalLightObject;
    private Light directionalLight;
    private int count = 0;

    public void ToggleSunlight()
    {
        count++;
        if(count % 2 == 0)
        {
            directionalLight.color = Color.red;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        directionalLight = directionalLightObject.GetComponent<Light>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
