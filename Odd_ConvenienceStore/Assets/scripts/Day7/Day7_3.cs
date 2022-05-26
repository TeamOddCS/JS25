using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;

public class Day7_3 : MonoBehaviour
{
    [SerializeField] private Text txt_name;// 이름 담는 객체 
    [SerializeField] private Text txt_dialogue; //대화내용 담는 객체
    public static bool isDialogue = false;
    public static int count = 0;
    private List<Dictionary<string, object>> data;
    public FadeInOut fade;
    public AudioClip touchclip;
    public AudioClip kbdclip;
    public AudioClip bell;
    public static int facenum = 0;
    public GameObject HealthControlScript;
    public AudioClip minus;
    public GameObject GameController;


    public void Showdialogue()// 처음시작할때 다 초기화하고 대화내용을 보여주는 함수
    {
        txt_dialogue.gameObject.SetActive(true);
        txt_name.gameObject.SetActive(true);
        //count = 0;
        isDialogue = true;
        if(count==0)
            Nextdialogue();
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
        if (count > 0)
        {
            SoundManager.instance.SFXPlay("Touch", touchclip);
            //SoundManager.instance.SFXPlay("Keyboard", kbdclip);
        }
        if(count == 0)
        {
            SoundManager.instance.SFXPlay("Bell", bell);
        }
        if (count == 47)
        {
            SoundManager.instance.SFXPlay("Bell", bell);
        }
        if (count == 74)
        {
            SoundManager.instance.SFXPlay("Bell", bell);
        }
        if (count == 101)
        {
            SoundManager.instance.SFXPlay("Bell", bell);
        }
        if (count == 157)
        {
            SoundManager.instance.SFXPlay("Bell", bell);
        }
        count++;
    }
    public void TextColorChange()
    {
        data[count]["Script"] = data[count]["Script"].ToString().Replace("ⓑ", "<color=#2782cc>");//파란색 "중요한부분"
        data[count]["Script"] = data[count]["Script"].ToString().Replace("ⓡ", "<color=#a83a22>");//빨간색 (생명력 -)
        data[count]["Script"] = data[count]["Script"].ToString().Replace("ⓖ", "<color=#13c216>");//초록색 (생명력 +) 
        data[count]["Script"] = data[count]["Script"].ToString().Replace("ⓔ", "</color>");// 바꿀 색깔이 끝났을때 쓰는 기호
        data[count]["Script"] = data[count]["Script"].ToString().Replace("ⓐ", "<color=#a8a3a2>");//주인공 독백 
    }

    private void Hidedialogue()//대화가 끝났으면 대화내용 숨기는 함수
    {
        txt_name.gameObject.SetActive(false);
        txt_dialogue.gameObject.SetActive(false);
        isDialogue = false;
    }
    public void Awake()
    {
        SaveData.DoLoadData = true;
        SaveData.TempScene = "Day7-3";
        count = SaveData.TempCount;
        SaveData.Saves();
    }
    private void FaceChange()
    {
        if (data[count]["Face"].ToString().Equals("7_1_1"))
        {
            facenum = 1;
        }
        if (data[count]["Face"].ToString().Equals("7_1_2"))
        {
            facenum = 2;
        }
        if (data[count]["Face"].ToString().Equals("7_1_3"))
        {
            facenum = 3;
        }
        if (data[count]["Face"].ToString().Equals("7_1_4"))
        {
            facenum = 4;
        }
        if (data[count]["Face"].ToString().Equals("7_2_1"))
        {
            facenum = 5;
        }
        if (data[count]["Face"].ToString().Equals("7_2_2"))
        {
            facenum = 6;
        }
        if (data[count]["Face"].ToString().Equals("7_2_3"))
        {
            facenum = 7;
        }
        if (data[count]["Face"].ToString().Equals("7_2_4"))
        {
            facenum = 8;
        }
    }
    private void day7_3_JD()//첫번째 선택지를 골랐을 경우 선택지 대화를 다본후 다음 대화로 넘어가는 함수
    {
        if (count < data.Count)
        {
            Nextdialogue();

            if (count == 15)
            {
                count += 29 - 15;
            }

            if (count == 24)
            {
                count += 29 - 24;
            }
            if (count == 39)
            {
                count += 47 - 39;
            }



            if (count == 58)
            {
                count += 64 - 58;
            }
            if (count == 85)
            {
                count += 91 - 85;
            }
            if (count == 95)
            {
                count += 101 - 95;
            }

            if (count == 114)
            {
                count += 124 - 114;
            }
            if (count == 131)
            {
                count += 139 - 131;
            }


            if (count == 144)
            {
                count += 157 - 144;
            }
            if (count == 197)
            {
                count += 218 - 197;
            }
            if (count == 208)
            {
                count += 218 - 208;
            }
            
            if (count == 221)
            {
                fade.Fade();
                Hidedialogue();
            }
        }
        else
        {
            fade.Fade();
            Hidedialogue();
            count = 1;
            GameController.GetComponent<JSChoice>().D2_JSChoice();
        }
    }

    private void day7_3_HC()
    {
       
        if (count == 100)
        {
            SoundManager.instance.SFXPlay("Minus", minus);
            SaveData.JSName = " JS9";
            HealthControlScript.GetComponent<HealthControlScript>().health_decrease();
        }
        if (count == 155)
        {
            SoundManager.instance.SFXPlay("Minus", minus);
            SaveData.JSName = " JS4";
            HealthControlScript.GetComponent<HealthControlScript>().health_decrease();
        }
        if (count == 202)
        {
            SoundManager.instance.SFXPlay("Minus", minus);
            SaveData.JSName = " JS3";
            HealthControlScript.GetComponent<HealthControlScript>().health_decrease();
        }
        if (count == 212)
        {
            SoundManager.instance.SFXPlay("Minus", minus);
            SaveData.JSName = " JS3";
            HealthControlScript.GetComponent<HealthControlScript>().health_decrease();
        }
     
    }
    private void Start()
    {
        data = CSVReader.Read("Day7-3");
        HealthControlScript.GetComponent<HealthControlScript>().Show_Health();
        Showdialogue();
    }
    // Update is called once per frame
    void Update()
    {
        if (isDialogue)
        {
            if (Input.GetMouseButtonUp(0))
            {
                if (EventSystem.current.IsPointerOverGameObject() == false)
                {
                    day7_3_JD();
                    day7_3_HC();
                    SaveData.TempCount = count - 1;
                    SaveData.Saves();
                }
            }
        }
        else
            Hidedialogue();
    }
}
