using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JS8_3_fc : MonoBehaviour
{
    public Sprite[] js8_face;
    public GameObject js8;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (JinSang8_3.facenum == 1)
        {
            js8.GetComponent<SpriteRenderer>().sprite = js8_face[0];
        }
        else if (JinSang8_3.facenum == 2)
        {
            js8.GetComponent<SpriteRenderer>().sprite = js8_face[1];
        }
        else if (JinSang8_3.facenum == 3)
        {
            js8.GetComponent<SpriteRenderer>().sprite = js8_face[2];
        }
        else if (JinSang8_3.facenum == 4)
        {
            js8.GetComponent<SpriteRenderer>().sprite = js8_face[3];
        }
        else if (JinSang8_3.facenum == 5)
        {
            js8.GetComponent<SpriteRenderer>().sprite = js8_face[4];
        }
        else if (JinSang8_3.facenum == 6)
        {
            js8.GetComponent<SpriteRenderer>().sprite = js8_face[5];
        }
        else if (JinSang8_3.facenum == 7)
        {
            js8.GetComponent<SpriteRenderer>().sprite = js8_face[6];
        }
        else if (JinSang8_3.facenum == 8)
        {
            js8.GetComponent<SpriteRenderer>().sprite = js8_face[7];
        }
    }
}
