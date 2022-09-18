using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Day6_1_fc : MonoBehaviour
{
    public Sprite[] js4_face;
    public GameObject js4;
    public Sprite[] js_face;
    public GameObject js;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Day6_1.facenum == 1)
        {
            js4.GetComponent<SpriteRenderer>().sprite = js4_face[0];
        }
        else if (Day6_1.facenum == 2)
        {
            js4.GetComponent<SpriteRenderer>().sprite = js4_face[1];
        }
        else if (Day6_1.facenum == 3)
        {
            js4.GetComponent<SpriteRenderer>().sprite = js4_face[2];
        }
        else if (Day6_1.facenum == 4)
        {
            js4.GetComponent<SpriteRenderer>().sprite = js4_face[3];
        }
        else if (Day6_1.facenum == 5)
        {
            js4.GetComponent<SpriteRenderer>().sprite = js4_face[4];
        }
        else if (Day6_1.facenum == 6)
        {
            js4.GetComponent<SpriteRenderer>().sprite = js4_face[5];
        }
        if (Day6_1.facenum2 == 1)
        {
            js.GetComponent<SpriteRenderer>().sprite = js_face[0];
        }
        if (Day6_1.facenum2 == 2)
        {
            js.GetComponent<SpriteRenderer>().sprite = js_face[0];
        }
        if (Day6_1.facenum2 == 3)
        {
            js.GetComponent<SpriteRenderer>().sprite = js_face[0];
        }
        if (Day6_1.facenum2 == 4)
        {
            js.GetComponent<SpriteRenderer>().sprite = js_face[0];
        }





    }
}

