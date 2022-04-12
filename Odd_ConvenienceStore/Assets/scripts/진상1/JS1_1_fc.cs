using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JS1_1_fc : MonoBehaviour
{
    public Sprite[] js1_face;
    public GameObject js1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (JinSang1_1.facenum == 1)
        {
            js1.GetComponent<SpriteRenderer>().sprite = js1_face[0];
        }
        else if (JinSang1_1.facenum == 2)
        {
            js1.GetComponent<SpriteRenderer>().sprite = js1_face[1];
        }
        else if (JinSang1_1.facenum == 3)
        {
            js1.GetComponent<SpriteRenderer>().sprite = js1_face[2];
        }
        else if (JinSang1_1.facenum == 4)
        {
            js1.GetComponent<SpriteRenderer>().sprite = js1_face[3];
        }
        else if (JinSang1_1.facenum == 5)
        {
            js1.GetComponent<SpriteRenderer>().sprite = js1_face[4];
        }
        else if (JinSang1_1.facenum == 6)
        {
            js1.GetComponent<SpriteRenderer>().sprite = js1_face[5];
        }
    }
}
