using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JS3_3_fc : MonoBehaviour
{
    public Sprite[] js3_face;
    public GameObject js3;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (JinSang3_3.facenum == 1)
        {
            js3.GetComponent<SpriteRenderer>().sprite = js3_face[0];
        }
        else if (JinSang3_3.facenum == 2)
        {
            js3.GetComponent<SpriteRenderer>().sprite = js3_face[1];
        }
        else if (JinSang3_3.facenum == 3)
        {
            js3.GetComponent<SpriteRenderer>().sprite = js3_face[2];
        }
        else if (JinSang3_3.facenum == 4)
        {
            js3.GetComponent<SpriteRenderer>().sprite = js3_face[3];
        }
        else if (JinSang3_3.facenum == 5)
        {
            js3.GetComponent<SpriteRenderer>().sprite = js3_face[4];
        }
        else if (JinSang3_3.facenum == 6)
        {
            js3.GetComponent<SpriteRenderer>().sprite = js3_face[5];
        }
    }
}
