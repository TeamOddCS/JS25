using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CheckUserData : MonoBehaviour
{
    public static Text 이름확인용;
    public static Text 난이도확인용;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void Awake()
    {
        이름확인용 = GameObject.Find("TestName").GetComponent<Text>();
        난이도확인용 = GameObject.Find("TestLevel").GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
