using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CheckUserData : MonoBehaviour
{
    public static Text �̸�Ȯ�ο�;
    public static Text ���̵�Ȯ�ο�;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void Awake()
    {
        �̸�Ȯ�ο� = GameObject.Find("TestName").GetComponent<Text>();
        ���̵�Ȯ�ο� = GameObject.Find("TestLevel").GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
