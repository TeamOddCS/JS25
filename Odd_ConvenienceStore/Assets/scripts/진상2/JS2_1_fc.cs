using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JS2_1_fc : MonoBehaviour
{
    public Sprite[] js2_face;
    public GameObject js2;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (JinSang2_1.facenum == 1)
        {
            js2.GetComponent<SpriteRenderer>().sprite = js2_face[0];
        }
        else if (JinSang2_1.facenum == 2)
        {
            js2.GetComponent<SpriteRenderer>().sprite = js2_face[1];
        }
        else if (JinSang2_1.facenum == 3)
        {
            js2.GetComponent<SpriteRenderer>().sprite = js2_face[2];
        }
        else if (JinSang2_1.facenum == 4)
        {
            js2.GetComponent<SpriteRenderer>().sprite = js2_face[3];
        }
        else if (JinSang2_1.facenum == 5)
        {
            js2.GetComponent<SpriteRenderer>().sprite = js2_face[4];
        }
        else if (JinSang2_1.facenum == 6)
        {
            js2.GetComponent<SpriteRenderer>().sprite = js2_face[5];
        }

    }
}
