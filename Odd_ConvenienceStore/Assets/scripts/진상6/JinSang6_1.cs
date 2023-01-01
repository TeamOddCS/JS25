using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class JinSang6_1 : MonoBehaviour
{
    [SerializeField] private Text txt_dialogue; //대화내용 담는 객체
    [SerializeField] private Text txt_name;// 이름 담는 객체 
    public static bool isDialogue = false;
    public static int count = 0;
    private List<Dictionary<string, object>> data;
    public FadeInOut fade;
    public AudioClip touchclip;
    public AudioClip kbdclip;
    public static int facenum = 0;
    public GameObject HealthControlScript;
    public AudioClip bell;
    public GameObject GameController;
    public AudioClip minus;
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
            //SoundManager.instance.SFXPlay("Keyboard", kbdclip);
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
    private void JinSang6_1_HC()
    {
        if(count == 25)
        {
            SoundManager.instance.SFXPlay("Minus", minus);
            SaveData.JSName = " JS6";
            HealthControlScript.GetComponent<HealthControlScript>().health_decrease();
        }
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
        SaveData.TempScene = "JinSang6_1";
        count = SaveData.TempCount;
        SaveData.Saves();
    }
    private void Start()
    {
        Camera = GameObject.FindWithTag("MainCamera").GetComponent<Camera>();
        data = CSVReader.Read("진상6-1");
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
                    if (count < data.Count)
                    {
                        Nextdialogue();
                        if (count == 22)
                        {
                            count += 4;
                        }
                        if (count == 24)
                        {
                            count++;
                        }
                        JinSang6_1_HC();
                    }
                    else
                    {
                        
                        Hidedialogue();
                        count = 1;
                        GameController.GetComponent<JSChoice>().Check_Day();
                    }
                    SaveData.TempCount = count - 1;
                    SaveData.Saves();
                }
            }
        }
        else
            Hidedialogue();
    }
}
