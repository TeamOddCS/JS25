using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JS7_2_fc : MonoBehaviour
{
    public Sprite[] js7_face;
    public GameObject js7;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (JinSang7_2.facenum == 1)
        {
            js7.GetComponent<SpriteRenderer>().sprite = js7_face[0];
        }
        else if (JinSang7_2.facenum == 2)
        {
            js7.GetComponent<SpriteRenderer>().sprite = js7_face[1];
        }
        else if (JinSang7_2.facenum == 3)
        {
            js7.GetComponent<SpriteRenderer>().sprite = js7_face[2];
        }
        else if (JinSang7_2.facenum == 4)
        {
            js7.GetComponent<SpriteRenderer>().sprite = js7_face[3];
        }

    }
}
