using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JS7_2_fc : MonoBehaviour
{
    public Sprite[] js7_face;
    public GameObject js7;
    public Sprite[] js_face;
    public GameObject js;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (JinSang7_2.facenum == 1) //일반손님 
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
        if (JinSang7_2.facenum2 == 1)  //진상 
        {
            js.GetComponent<SpriteRenderer>().sprite = js_face[0];
        }
        if (JinSang7_2.facenum2 == 2)
        {
            js.GetComponent<SpriteRenderer>().sprite = js_face[1];
        }
        if (JinSang7_2.facenum2 == 3)
        {
            js.GetComponent<SpriteRenderer>().sprite = js_face[2];
        }


    }
}
