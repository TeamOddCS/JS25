using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;

public class Day4_3 : MonoBehaviour 
{ 
    [SerializeField] private Text txt_name;// 이름 담는 객체 
    [SerializeField] private Text txt_dialogue; //대화내용 담는 객체
    public static bool isDialogue = false;
    public static int count = 0;
    public AudioClip touchclip;
    private List<Dictionary<string, object>> data;
    public FadeInOut fade;
    public GameObject HealthControlScript;
    public AudioClip bell;
    public AudioClip Pos;
    public AudioClip hiccups;
    public AudioClip minus;
    public static int facenum = 0;
    Camera Camera;


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
        if (count == 39)
        {
            SoundManager.instance.SFXPlay("Bell", bell);
            fade.Fade();
        }
        if (count == 55)
        {
            SoundManager.instance.SFXPlay("Pos", Pos);
        }
        if (count == 71)
        {
            SoundManager.instance.SFXPlay("Bell", bell);
            fade.Fade();
        }
        if (count == 73)
        {
            SoundManager.instance.SFXPlay("Hiccups", hiccups);
        }
        if (count == 93)
        {
            SoundManager.instance.SFXPlay("Hiccups", hiccups);
        }
        if (count == 119)
        {
            SoundManager.instance.SFXPlay("Hiccups", hiccups);
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
    private void day4_3_JD()//첫번째 선택지를 골랐을 경우 선택지 대화를 다본후 다음 대화로 넘어가는 함수
    {
        if (count < data.Count)
        {
            Nextdialogue();
            
            if (count == 11)
            {
                count += 6;
            }
            if (count == 30)
            {
                count += 8;
            }
            if (count == 67)
            {
                count += 4;
            }
            if (count == 86)
            {
                count += 4;
            }
            if (count == 97)
            {
                count += 7;
            }
            if (count == 126)
            {
                count += 11;
            }
            if (count == 158)
            {
                count += 6;
            }
            if (count == 187)
            {
                count += 38;
            }
            if (count == 194)
            {
                count += 31;
            }
            if (count == 213)
            {
                count +=12;
            }
            if (count == 227)
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
            SceneManager.LoadScene("Day4-F");
        }
    }
    private void FaceChange()
    {
        if (data[count]["Face"].ToString().Equals("a3_1_1"))
        {
            facenum = 1;
        }
        if (data[count]["Face"].ToString().Equals("a3_2"))
        {
            facenum = 2;
        }
        if (data[count]["Face"].ToString().Equals("a3_3"))
        {
            facenum = 3;
        }
        if (data[count]["Face"].ToString().Equals("a3_6"))
        {
            facenum = 4;
        }
        if (data[count]["Face"].ToString().Equals("a3_7"))
        {
            facenum = 5;
        }
        if (data[count]["Face"].ToString().Equals("a5_1_1"))
        {
            facenum = 6;
        }
        if (data[count]["Face"].ToString().Equals("a5_1_2"))
        {
            facenum = 7;
        }
        if (data[count]["Face"].ToString().Equals("a5_1_3"))
        {
            facenum = 8;
        }
        if (data[count]["Face"].ToString().Equals("a5_1_4"))
        {
            facenum = 9;
        }
        if (data[count]["Face"].ToString().Equals("a5_1_5"))
        {
            facenum = 10;
        }
        if (data[count]["Face"].ToString().Equals("a5_1_6"))
        {
            facenum = 11;
        }
        if (data[count]["Face"].ToString().Equals("2_1_1"))
        {
            facenum = 12;
        }
        if (data[count]["Face"].ToString().Equals("2_1_2"))
        {
            facenum = 13;
        }
        if (data[count]["Face"].ToString().Equals("2_2_1"))
        {
            facenum = 14;
        }
        if (data[count]["Face"].ToString().Equals("2_2_2"))
        {
            facenum = 15;
        }
        if (data[count]["Face"].ToString().Equals("2_3_1"))
        {
            facenum = 16;
        }
        if (data[count]["Face"].ToString().Equals("2_3_2"))
        {
            facenum = 17;
        }
        if (data[count]["Face"].ToString().Equals("8_1_1"))
        {
            facenum = 18;
        }
        if (data[count]["Face"].ToString().Equals("8_1_2"))
        {
            facenum = 19;
        }
        if (data[count]["Face"].ToString().Equals("8_1_3"))
        {
            facenum = 20;
        }
        if (data[count]["Face"].ToString().Equals("8_2_1"))
        {
            facenum = 21;
        }
        if (data[count]["Face"].ToString().Equals("8_2_2"))
        {
            facenum = 22;
        }
        if (data[count]["Face"].ToString().Equals("8_2_3"))
        {
            facenum = 23;
        }
        if (data[count]["Face"].ToString().Equals("8_1_1a"))
        {
            facenum = 24;
        }
        if (data[count]["Face"].ToString().Equals("8_1_2a"))
        {
            facenum = 25;
        }
        if (data[count]["Face"].ToString().Equals("8_1_3a"))
        {
            facenum = 26;
        }
        if (data[count]["Face"].ToString().Equals("8_2_1a"))
        {
            facenum = 27;
        }
        if (data[count]["Face"].ToString().Equals("8_2_2a"))
        {
            facenum = 28;
        }
        if (data[count]["Face"].ToString().Equals("8_2_3a"))
        {
            facenum = 29;
        }
    }

    private void day4_3_HC()
    {

        if (count == 182)
        {
            SoundManager.instance.SFXPlay("Minus", minus);
            SaveData.JSName = " JS8";
            HealthControlScript.GetComponent<HealthControlScript>().health_decrease();
        }
        if (count == 201)
        {
            SoundManager.instance.SFXPlay("Minus", minus);
            SaveData.JSName = " JS8";
            HealthControlScript.GetComponent<HealthControlScript>().health_decrease();
        }

        if (count == 221)
        {
            SoundManager.instance.SFXPlay("Minus", minus);
            SaveData.JSName = " JS8";
            HealthControlScript.GetComponent<HealthControlScript>().health_decrease();
        }
      

    }
    public void Awake()
    {
        SaveData.DoLoadData = true;
        SaveData.TempScene = "Day4-3";
        count = SaveData.TempCount;
        SaveData.Saves();
    }
    private void Start()
    {
        Camera = GameObject.FindWithTag("MainCamera").GetComponent<Camera>();
        data = CSVReader.Read("Day4-3");
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
                Vector2 mousePos = Input.mousePosition;
                mousePos = Camera.ScreenToWorldPoint(mousePos);
                if (EventSystem.current.IsPointerOverGameObject() == false && mousePos.y < 0)
                {
                    day4_3_JD();
                    day4_3_HC();
                    SaveData.TempCount = count - 1;
                    SaveData.Saves();
                }
            }
        }
        else
            Hidedialogue();
    }
}
