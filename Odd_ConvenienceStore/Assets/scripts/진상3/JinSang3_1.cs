using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class JinSang3_1 : MonoBehaviour
{
    [SerializeField] private Text txt_dialogue; //대화내용 담는 객체
    [SerializeField] private Text txt_name;// 이름 담는 객체 
    public static bool isDialogue = false;
    public static int count = 0;
    private List<Dictionary<string, object>> data;
    public FadeInOut fade;
    public AudioClip touchclip;
    public AudioClip bellclip;
    public static int facenum=0;


    public void Showdialogue()// 처음시작할때 다 초기화하고 대화내용을 보여주는 함수
    {
        txt_dialogue.gameObject.SetActive(true);
        txt_name.gameObject.SetActive(true);
        count = 0;
        isDialogue = true;
        Nextdialogue();
        SoundManager.instance.SFXPlay("Bell", bellclip);
    }
    public void Nextdialogue()//대화내용 넘기는 함수
    {
        Debug.Log(count);
        txt_dialogue.gameObject.SetActive(true);
        txt_name.gameObject.SetActive(true);
        txt_name.text = data[count]["Name"].ToString();
        data[count]["Script"] = data[count]["Script"].ToString().Replace("#", ",");
        data[count]["Script"] = data[count]["Script"].ToString().Replace("  ", "\n");
        TextColorChange();
        txt_dialogue.text = data[count]["Script"].ToString();
        FaceChange();
        if(count>0)
            SoundManager.instance.SFXPlay("Touch", touchclip);
        count++;

    }
    public void TextColorChange()
    {
        data[count]["Script"] = data[count]["Script"].ToString().Replace("ⓑ", "<color=#2782cc>");//파란색 "중요한부분"
        data[count]["Script"] = data[count]["Script"].ToString().Replace("ⓡ", "<color=#a83a22>");//빨간색 (생명력 -)
        data[count]["Script"] = data[count]["Script"].ToString().Replace("ⓖ", "<color=#13c216>");//초록색 (생명력 +) 
        data[count]["Script"] = data[count]["Script"].ToString().Replace("ⓔ", "</color>");// 바꿀 색깔이 끝났을때 쓰는 기호
    }


    private void Hidedialogue()//대화가 끝났으면 대화내용 숨기는 함수
    {
        txt_name.gameObject.SetActive(false);
        txt_dialogue.gameObject.SetActive(false);
        isDialogue = false;
    }
    private void FaceChange()
    {
        if (data[count]["Face"].ToString().Equals("3_1_1")) 
        {
            facenum = 1;
        }
        if (data[count]["Face"].ToString().Equals("3_1_2"))
        {
            facenum = 2;
        }
        if (data[count]["Face"].ToString().Equals("3_2_1")) 
        {
            facenum = 3;
        }
        if (data[count]["Face"].ToString().Equals("3_2_2"))
        {
            facenum = 4;
        }
        if (data[count]["Face"].ToString().Equals("3_3_1"))
        {
            facenum = 5;
        }
        if (data[count]["Face"].ToString().Equals("3_3_2"))
        {
            facenum = 6;
        }
    }
    private void Start()
    {
        data = CSVReader.Read("진상3-1");
        Showdialogue();
    }
    // Update is called once per frame
    void Update()
    {
        if (isDialogue)
        {
            if (Input.GetMouseButtonUp(0))
            {
                if (count < data.Count)
                {
                    
                    Nextdialogue();
                    if (count == 27)
                    {
                        fade.Fade();
                        Hidedialogue();
                    }
                    if (count == 35)
                    {
                        fade.Fade();
                        Hidedialogue();
                    }
                    if (count == 53)
                    {
                        fade.Fade();
                        Hidedialogue();
                    }
                }
                else
                {
                    fade.Fade();
                    Hidedialogue();
                }

            }
        }
        else
            Hidedialogue();
    }
}
