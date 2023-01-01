using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class JinSang6_2 : MonoBehaviour
{
    [SerializeField] private Text txt_dialogue; //대화내용 담는 객체
    [SerializeField] private Text txt_name;// 이름 담는 객체 
    public static bool isDialogue = false;
    public static int count = 0;
    private List<Dictionary<string, object>> data;
    public static bool choiceF = false;
    public FadeInOut fade;
    public static int facenum = 0;
    public AudioClip touchclip;
    public AudioClip bell;
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
        }
        if (count == 0)
        {
            SoundManager.instance.SFXPlay("Bell", bell);
            fade.Fade();
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
    private void FaceChange()
    {
        if (data[count]["Face"].ToString().Equals("6_1_1"))
        {
            facenum = 1;
        }
        if (data[count]["Face"].ToString().Equals("6_1_2"))
        {
            facenum = 2;
        }
        if (data[count]["Face"].ToString().Equals("6_1_3"))
        {
            facenum = 3;
        }
        if (data[count]["Face"].ToString().Equals("6_1_4"))
        {
            facenum = 4;
        }
        if (data[count]["Face"].ToString().Equals("6_2_1"))
        {
            facenum = 5;
        }
        if (data[count]["Face"].ToString().Equals("6_2_2"))
        {
            facenum = 6;
        }
        if (data[count]["Face"].ToString().Equals("6_2_3"))
        {
            facenum = 7;
        }
        if (data[count]["Face"].ToString().Equals("6_2_4"))
        {
            facenum = 8;
        }
    }
    public void Awake()
    {
        SaveData.DoLoadData = true;
        SaveData.TempScene = "JinSang6_2";
        count = SaveData.TempCount;
        SaveData.Saves();
    }
    private void Start()
    {
        SaveData.Loads();
        data = CSVReader.Read("진상6-2");
        HealthControlScript.GetComponent<HealthControlScript>().Show_Health();
        Showdialogue();
    }
    private void JinSang6_2_HC()
    {
        if (count == 8)
        {
            SoundManager.instance.SFXPlay("Minus", minus);
            SaveData.JSName = " JS6";
            HealthControlScript.GetComponent<HealthControlScript>().health_decrease();
        }
        if (count == 35)
        {
            SoundManager.instance.SFXPlay("Minus", minus);
            SaveData.JSName = " JS6";
            HealthControlScript.GetComponent<HealthControlScript>().health_decrease();
        }
        if (count == 41)
        {
            SoundManager.instance.SFXPlay("Minus", minus);
            SaveData.JSName = " JS6";
            HealthControlScript.GetComponent<HealthControlScript>().health_decrease();
        }
        if (count == 42)
        {
            SoundManager.instance.SFXPlay("Minus", minus);
            SaveData.JSName = " JS6";
            HealthControlScript.GetComponent<HealthControlScript>().health_decrease();
        }
        if (count == 43)
        {
            SoundManager.instance.SFXPlay("Minus", minus);
            SaveData.JSName = " JS6";
            HealthControlScript.GetComponent<HealthControlScript>().health_decrease();
        }
        if (count == 45)
        {
            SoundManager.instance.SFXPlay("Minus", minus);
            SaveData.JSName = " JS6";
            HealthControlScript.GetComponent<HealthControlScript>().health_decrease();
        }
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
                    if (count < data.Count)
                    {
                        Nextdialogue();
                        if (count == 11)
                        {
                            count += 58 - 11;
                        }
                        if (count == 12)
                        {
                            if (SaveData.JinSang6Day1 == 1)
                            {
                                Debug.Log("Data : 1");
                            }
                            else if (SaveData.JinSang6Day1 == 2)
                            {
                                Debug.Log("Data : 2");
                                count += 48 - 12;
                            }
                        }
                        if (count == 37)
                        {
                            count += 58 - 37;
                        }
                        if (count == 44)
                        {
                            count += 58 - 44;
                        }
                        if (count == 46)
                        {
                            choiceF = true;
                        }
                        if (count == 48 && choiceF)
                        {
                            count += 58 - 48;
                        }
                    }
                    else
                    {
                        
                        Hidedialogue();
                        count = 1;
                        GameController.GetComponent<JSChoice>().Check_Day();
                    }
                    JinSang6_2_HC();
                    SaveData.TempCount = count - 1;
                    SaveData.Saves();
                }
            }
        }
        else
            Hidedialogue();
    }
}
