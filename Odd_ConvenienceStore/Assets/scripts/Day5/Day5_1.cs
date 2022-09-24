using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Day5_1 : MonoBehaviour
{
    [SerializeField] private Text txt_dialogue; //대화내용 담는 객체
    [SerializeField] private Text txt_name;// 이름 담는 객체 
    public static bool isDialogue = false;
    public static int count = 0;
    private List<Dictionary<string, object>> data;
    public FadeInOut fade;
    public AudioClip touchclip;
    public AudioClip ring;
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
    public void TextColorChange()
    {
        data[count]["Script"] = data[count]["Script"].ToString().Replace("ⓑ", "<color=#2782cc>");//파란색 "중요한부분"
        data[count]["Script"] = data[count]["Script"].ToString().Replace("ⓡ", "<color=#a83a22>");//빨간색 (생명력 -)
        data[count]["Script"] = data[count]["Script"].ToString().Replace("ⓖ", "<color=#13c216>");//초록색 (생명력 +) 
        data[count]["Script"] = data[count]["Script"].ToString().Replace("ⓔ", "</color>");// 바꿀 색깔이 끝났을때 쓰는 기호
        data[count]["Script"] = data[count]["Script"].ToString().Replace("ⓐ", "<color=#a8a3a2>");//주인공 독백 
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
        FaceChange();
        txt_dialogue.text = data[count]["Script"].ToString();
        if (count > 0)
        {
            SoundManager.instance.SFXPlay("Touch", touchclip);
        }
        if (count == 0)
        {
            SoundManager.instance.SFXPlay("Ring", ring);
        }
        if (count == 10)
        {
            SoundManager.instance.SFXPlay("Ring", ring);
        }
        if (count == 92)
        {
            SoundManager.instance.SFXPlay("Ring", ring);
        }

        count++;
    }
    private void FaceChange()
    {
        if (data[count]["Face"].ToString().Equals("4_1_1"))
        {
            facenum = 1;
        }
        if (data[count]["Face"].ToString().Equals("4_1_2"))
        {
            facenum = 2;
        }
        if (data[count]["Face"].ToString().Equals("4_2_1"))
        {
            facenum = 3;
        }
        if (data[count]["Face"].ToString().Equals("4_2_2"))
        {
            facenum = 4;
        }
        if (data[count]["Face"].ToString().Equals("1111"))
        {
            facenum = 5;
        }
        if (data[count]["Face"].ToString().Equals("2222"))
        {
            facenum = 6;
        }
        if (data[count]["Face"].ToString().Equals("3333"))
        {
            facenum = 7;
        }
        if (data[count]["Face"].ToString().Equals("5_1_1"))
        {
            facenum = 8;
        }
        if (data[count]["Face"].ToString().Equals("5_1_2"))
        {
            facenum = 9;
        }
        if (data[count]["Face"].ToString().Equals("5_2_1"))
        {
            facenum = 10;
        }
        if (data[count]["Face"].ToString().Equals("5_2_2"))
        {
            facenum = 11;
        }
        if (data[count]["Face"].ToString().Equals("5_3_1"))
        {
            facenum = 12;
        }
        if (data[count]["Face"].ToString().Equals("5_3_2"))
        {
            facenum = 13;
        }
        if (data[count]["Face"].ToString().Equals("5_4_1"))
        {
            facenum = 14;
        }
        if (data[count]["Face"].ToString().Equals("5_4_2"))
        {
            facenum = 15;
        }

    }
    private void day5_1_HC()
    {
        if (count == 5)
        {
            SoundManager.instance.SFXPlay("Plus", minus);
            SaveData.JSName = " JS9";
            HealthControlScript.GetComponent<HealthControlScript>().health_increase();
        }
        if (count == 6)
        {
            SoundManager.instance.SFXPlay("Plus", minus);
            SaveData.JSName = " JS9";
            HealthControlScript.GetComponent<HealthControlScript>().health_increase();
        }
        if (count == 7)
        {
            SoundManager.instance.SFXPlay("Plus", minus);
            SaveData.JSName = " JS9";
            HealthControlScript.GetComponent<HealthControlScript>().health_increase();
        }
        if (count == 172)
        {
            SoundManager.instance.SFXPlay("Minus", minus);
            SaveData.JSName = " JS5";
            HealthControlScript.GetComponent<HealthControlScript>().health_decrease();
        }
        

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
        SaveData.TempScene = "Day5-1";
        count = SaveData.TempCount;
        SaveData.Saves();
    }
    private void Start()
    {
        data = CSVReader.Read("Day5-1");
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
                    if (count < data.Count)
                    {
                        Nextdialogue();
                        if (count == 32)
                        {// 그러면 저 밥사주세요 끝나고
                            count += 8;
                        }
                        if (count == 52)
                        {//섭섭해 하지 마세요. 끝나고
                            count += 40;
                        }
                        if (count == 58)
                        {// 그렇게까지 저를.. 끝나고
                            count += 34;
                        }
                        if (count == 69)
                            count += 6;
                        if (count == 85)
                            count += 7;
                        if (count == 125)
                            count += 5;
                        if (count == 135)
                            count += 34;
                        if (count == 157)
                            count += 15;
                    }
                    else
                    {
                        fade.Fade();
                        Hidedialogue();
                        count = 1;
                        GameController.GetComponent<JSChoice>().D5_JSChoice();
                    }

                    day5_1_HC();
                    SaveData.TempCount = count - 1;
                    SaveData.Saves();
                }
            }
        }
        else
            Hidedialogue();
    }
}
