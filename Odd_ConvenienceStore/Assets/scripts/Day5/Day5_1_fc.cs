using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Day5_1_fc : MonoBehaviour
{
    public Sprite[] js4_face;
    public GameObject js4;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Day5_1.facenum == 1)
        {
            js4.GetComponent<SpriteRenderer>().sprite = js4_face[0];
        }
        else if (Day5_1.facenum == 2)
        {
            js4.GetComponent<SpriteRenderer>().sprite = js4_face[1];
        }
        else if (Day5_1.facenum == 3)
        {
            js4.GetComponent<SpriteRenderer>().sprite = js4_face[2];
        }
        else if (Day5_1.facenum == 4)
        {
            js4.GetComponent<SpriteRenderer>().sprite = js4_face[3];
        }
        else if (Day5_1.facenum == 5)
        {
            js4.GetComponent<SpriteRenderer>().sprite = js4_face[4];
        }
        else if (Day5_1.facenum == 6)
        {
            js4.GetComponent<SpriteRenderer>().sprite = js4_face[5];
        }


    }
}
