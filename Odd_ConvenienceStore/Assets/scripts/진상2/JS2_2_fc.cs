using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JS2_2_fc : MonoBehaviour
{
    public Sprite[] js2_face;
    public GameObject js2;
    public Sprite[] js9_face;
    public GameObject js9;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (JinSang2_2.facenum == 1)
        {
            js2.GetComponent<SpriteRenderer>().sprite = js2_face[0];
        }
        else if (JinSang2_2.facenum == 2)
        {
            js2.GetComponent<SpriteRenderer>().sprite = js2_face[1];
        }
        else if (JinSang2_2.facenum == 3)
        {
            js2.GetComponent<SpriteRenderer>().sprite = js2_face[2];
        }
        else if (JinSang2_2.facenum == 4)
        {
            js2.GetComponent<SpriteRenderer>().sprite = js2_face[3];
        }
        else if (JinSang2_2.facenum == 5)
        {
            js2.GetComponent<SpriteRenderer>().sprite = js2_face[4];
        }
        else if (JinSang2_2.facenum == 6)
        {
            js2.GetComponent<SpriteRenderer>().sprite = js2_face[5];
        }
        if (JinSang2_2.facenum2 == 0)// 손님 그래픽 추가 테스트 코드
        {
            js9.GetComponent<SpriteRenderer>().sprite = js9_face[0];
        }
        if (JinSang2_2.facenum2 == 1)// 손님 그래픽 추가 테스트 코드
        {
            js9.GetComponent<SpriteRenderer>().sprite = js9_face[1];
        }
        if (JinSang2_2.facenum2 == 2)// 손님 그래픽 추가 테스트 코드
        {
            js9.GetComponent<SpriteRenderer>().sprite = js9_face[2];
        }
        if (JinSang2_2.facenum2 == 3)// 손님 그래픽 추가 테스트 코드
        {
            js9.GetComponent<SpriteRenderer>().sprite = js9_face[3];
        }
        if (JinSang2_2.facenum2 == 4)// 손님 그래픽 추가 테스트 코드
        {
            js9.GetComponent<SpriteRenderer>().sprite = js9_face[4];
        }
        if (JinSang2_2.facenum2 == 5)// 손님 그래픽 추가 테스트 코드
        {
            js9.GetComponent<SpriteRenderer>().sprite = js9_face[5];
        }

    }
}
