using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blank : MonoBehaviour
{
    float time;

   
    private void Update()
    {
        if (time < 0.5f)
        {
            GetComponent<SpriteRenderer>().color = new Color(1, 1, 1, 1 - time);

        }
        else
        {
            GetComponent<SpriteRenderer>().color = new Color(1, 1, 1, 1 - time);
            if (time > 1f)
            {
                time = 0;
            }
        }
        time += Time.deltaTime;

    }
   
}