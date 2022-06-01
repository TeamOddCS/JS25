using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JS5_1_fc : MonoBehaviour
{
    public Sprite[] js5_face;
    public GameObject js5;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (JinSang5_1.facenum == 1)
        {
            js5.GetComponent<SpriteRenderer>().sprite = js5_face[0];
        }
        else if (JinSang5_1.facenum == 2)
        {
            js5.GetComponent<SpriteRenderer>().sprite = js5_face[1];
        }
        else if (JinSang5_1.facenum == 3)
        {
            js5.GetComponent<SpriteRenderer>().sprite = js5_face[2];
        }
        else if (JinSang5_1.facenum == 4)
        {
            js5.GetComponent<SpriteRenderer>().sprite = js5_face[3];
        }
        else if (JinSang5_1.facenum == 5)
        {
            js5.GetComponent<SpriteRenderer>().sprite = js5_face[4];
        }
        else if (JinSang5_1.facenum == 6)
        {
            js5.GetComponent<SpriteRenderer>().sprite = js5_face[5];
        }
        else if (JinSang5_1.facenum == 7)
        {
            js5.GetComponent<SpriteRenderer>().sprite = js5_face[6];
        }
        else if (JinSang5_1.facenum == 8)
        {
            js5.GetComponent<SpriteRenderer>().sprite = js5_face[7];
        }
      
    }
}
