using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Day5_F_fc : MonoBehaviour
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
        if (Day5_F.facenum == 1)
        {
            js4.GetComponent<SpriteRenderer>().sprite = js4_face[0];
        }

    }
}
