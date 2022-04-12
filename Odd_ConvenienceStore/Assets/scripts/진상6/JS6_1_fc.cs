using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JS6_1_fc : MonoBehaviour
{
    public Sprite[] js6_face;
    public GameObject js6;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (JinSang6_1.facenum == 1)
        {
            js6.GetComponent<SpriteRenderer>().sprite = js6_face[0];
        }
        else if (JinSang6_1.facenum == 2)
        {
            js6.GetComponent<SpriteRenderer>().sprite = js6_face[1];
        }
        else if (JinSang6_1.facenum == 3)
        {
            js6.GetComponent<SpriteRenderer>().sprite = js6_face[2];
        }
        else if (JinSang6_1.facenum == 4)
        {
            js6.GetComponent<SpriteRenderer>().sprite = js6_face[3];
        }
        else if (JinSang6_1.facenum == 5)
        {
            js6.GetComponent<SpriteRenderer>().sprite = js6_face[4];
        }
        else if (JinSang6_1.facenum == 6)
        {
            js6.GetComponent<SpriteRenderer>().sprite = js6_face[5];
        }
        else if (JinSang6_1.facenum == 7)
        {
            js6.GetComponent<SpriteRenderer>().sprite = js6_face[6];
        }
        else if (JinSang6_1.facenum == 8)
        {
            js6.GetComponent<SpriteRenderer>().sprite = js6_face[7];
        }
    }
}
