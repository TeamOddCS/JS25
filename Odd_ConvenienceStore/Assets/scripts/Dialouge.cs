using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[System.Serializable]
public class dialouge
{
    [TextArea]
    public string _dialouge;
    public string _name;
    
}
public class Dialouge : MonoBehaviour
{
    [SerializeField] private Text txt_dialouge; //대화내용 담는 객체
    [SerializeField] private Text txt_name;// 이름 담는 객체
   
    public static bool isDialouge = false;
    public static int count = 0;
    [SerializeField] private dialouge[] dialouge;
    
    // Start is called before the first frame update

    public void ShowDialouge()// 처음시작할때 다 초기화하고 대화내용을 보여주는 함수
    {
        txt_dialouge.gameObject.SetActive(true);
        txt_name.gameObject.SetActive(true);
        count = 0;
        isDialouge = true;
        NextDialouge();
    }
    public void NextDialouge()//대화내용 넘기는 함수
    {
        txt_dialouge.gameObject.SetActive(true);
        txt_name.gameObject.SetActive(true);
        txt_name.text = dialouge[count]._name;
        txt_dialouge.text = dialouge[count]._dialouge;       
        count++;
        if (count == 13)
        {
            count += 4;
        }
    }

    
    private void HideDialouge()//대화가 끝났으면 대화내용 숨기는 함수
    {
        txt_name.gameObject.SetActive(false);
        txt_dialouge.gameObject.SetActive(false);
        isDialouge = false;
    }
    private void Start()
    {
        ShowDialouge();        
    }
    // Update is called once per frame
    void Update()
    {
        if (isDialouge)
        {
            if (Input.GetMouseButtonUp(0))
            {
                if (count < dialouge.Length)
                {
                    NextDialouge();
                }
                else
                    HideDialouge();
            }
        }
        else
            HideDialouge();
    }
}
