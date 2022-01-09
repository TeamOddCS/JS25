using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Resolution : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Screen.SetResolution(1080, 1920, true);
        Screen.SetResolution(Screen.width, (Screen.width * 16) / 9, true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
