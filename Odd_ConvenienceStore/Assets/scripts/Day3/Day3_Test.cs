using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Day3_Test : MonoBehaviour
{
    //사진 테스트
    public Sprite[] ImageTest_Main;
    public Sprite[] ImageTest_F;

    public GameObject ImageTest;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (Day3_F.test_who_is == 0)
        {//최알바
            ImageTest.GetComponent<SpriteRenderer>().sprite = ImageTest_Main[0];
        }
        else if (Day3_F.test_who_is == 1)
        {//친구
            ImageTest.GetComponent<SpriteRenderer>().sprite = ImageTest_F[0];
        }
    }
}
