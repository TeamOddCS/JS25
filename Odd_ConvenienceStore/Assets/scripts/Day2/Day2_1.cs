using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Day2_1 : MonoBehaviour
{
    [SerializeField] private Text txt_name;// 이름 담는 객체 
    [SerializeField] private Text txt_dialogue; //대화내용 담는 객체
    public static bool isDialogue = false;
    public static int count = 0;
    private List<Dictionary<string, object>> data;
    public FadeInOut fade;
    public AudioClip touchclip;
    public AudioClip kbdclip;
    public static int facenum = 0;
    public GameObject HealthControlScript;

    public GameObject GameController;


    public void Showdialogue()// 처음시작할때 다 초기화하고 대화내용을 보여주는 함수
    {
        txt_dialogue.gameObject.SetActive(true);
        txt_name.gameObject.SetActive(true);
        //count = 0;
        isDialogue = true;
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
        SaveData.TempScene = "Day2-1";
        count = SaveData.TempCount;
        SaveData.Saves();
    }
    private void FaceChange()
    {
        if (data[count]["Face"].ToString().Equals("9_1_1"))
        {
            facenum = 1;
        }
        if (data[count]["Face"].ToString().Equals("9_1_2"))
        {
            facenum = 2;
        }
        if (data[count]["Face"].ToString().Equals("9_1_3"))
        {
            facenum = 3;
        }
        if (data[count]["Face"].ToString().Equals("9_1_4"))
        {
            facenum = 4;
        }
        if (data[count]["Face"].ToString().Equals("9_2_1"))
        {
            facenum = 5;
        }
        if (data[count]["Face"].ToString().Equals("9_2_2"))
        {
            facenum = 6;
        }
        if (data[count]["Face"].ToString().Equals("9_2_3"))
        {
            facenum = 7;
        }
        if (data[count]["Face"].ToString().Equals("9_2_4"))
        {
            facenum = 8;
        }
    }
    private void day2_1_JD()//첫번째 선택지를 골랐을 경우 선택지 대화를 다본후 다음 대화로 넘어가는 함수
    {
        if (count < data.Count)
        {
            Nextdialogue();

            if (count == 14)
            {
                count += 18 - 14;
            }

            if (count == 27)
            {
                count += 30 - 27;
            }
            if (count == 55)
            {
                count +=  66 - 55;
            }
           


            if (count == 64)
            {
                count += 66 - 64;
            }
            if (count == 91)
            {
                count += 106 - 91;
            }
            if (count == 104)
            {
                count += 106 - 104;
            }
           
            if (count == 108)
            {
                count += 110 - 108;
            }
            if (count == 70)
            {
                count += 110 - 70;
            }
            

            if (count == 125)
            {
                count += 151 - 125;
            }
            if (count == 143)
            {
                count += 151 - 143;
            }
            if (count == 150)
            {
                count += 151 - 150;
            }
            if (count == 165)
            {
                count += 183 - 165;
            }
            if (count == 169)
            {
                count += 183 - 169;
            }
            if (count == 177)
            {
                count += 181 - 177;
            }
            if (count == 182)
            {
                count += 160 - 182;
            }
            if (count == 201)
            {
                count += 205 - 201;
            }
            if (count == 210)
            {
                count += 217 - 210;
            }
            if (count == 217)
            {
                count += 217 - 217;
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

    private void day2_1_HC()
    {
        if (count == 3)
        {
            SaveData.JSName = " JS9";
            HealthControlScript.GetComponent<HealthControlScript>().health_decrease();
        }
        if (count == 4)
        {
            SaveData.JSName = " JS9";
            HealthControlScript.GetComponent<HealthControlScript>().health_increase();
        }
        if (count == 61)
        {
            SaveData.JSName = " JS9";
            HealthControlScript.GetComponent<HealthControlScript>().health_decrease();
        }
        if (count == 77)
        {
            SaveData.JSName = " JS9";
            HealthControlScript.GetComponent<HealthControlScript>().health_decrease();
        }
        if (count == 90)
        {
            SaveData.JSName = " JS9";
            HealthControlScript.GetComponent<HealthControlScript>().health_increase();
        }
        if (count == 98)
        {
            SaveData.JSName = " JS9";
            HealthControlScript.GetComponent<HealthControlScript>().health_decrease();
        }
        if (count == 142)
        {
            SaveData.JSName = " JS9";
            HealthControlScript.GetComponent<HealthControlScript>().health_decrease();
        }
        if (count == 164)
        {
            SaveData.JSName = " JS9";
            HealthControlScript.GetComponent<HealthControlScript>().health_decrease();
        }
        if (count == 181)
        {
            SaveData.JSName = " JS9";
            HealthControlScript.GetComponent<HealthControlScript>().health_decrease();
        }
    }
    private void Start()
    {
        data = CSVReader.Read("Day2-1");
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
                day2_1_JD();
                day2_1_HC();
                SaveData.TempCount = count - 1;
                SaveData.Saves();
            }
        }
        else
            Hidedialogue();
        if (count == 220)
        {
            SceneManager.LoadScene("Day2-3");
        }
        
    }
}
