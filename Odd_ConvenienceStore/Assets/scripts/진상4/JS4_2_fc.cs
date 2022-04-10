using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JS4_2_fc : MonoBehaviour
{
    public Sprite[] js4_face;
    public GameObject js4;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (JinSang4_2.facenum == 1)
        {
            js4.GetComponent<SpriteRenderer>().sprite = js4_face[0];
        }
        else if (JinSang4_2.facenum == 2)
        {
            js4.GetComponent<SpriteRenderer>().sprite = js4_face[1];
        }
        else if (JinSang4_2.facenum == 3)
        {
            js4.GetComponent<SpriteRenderer>().sprite = js4_face[2];
        }
        else if (JinSang4_2.facenum == 4)
        {
            js4.GetComponent<SpriteRenderer>().sprite = js4_face[3];
        }
        else if (JinSang4_2.facenum == 5)
        {
            js4.GetComponent<SpriteRenderer>().sprite = js4_face[4];
        }
        else if (JinSang4_2.facenum == 6)
        {
            js4.GetComponent<SpriteRenderer>().sprite = js4_face[5];
        }
    }
}
