using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Day3_3 : MonoBehaviour
{
    [SerializeField] private Text txt_dialogue; //대화내용 담는 객체
    [SerializeField] private Text txt_name;// 이름 담는 객체 
    public static bool isDialogue = false;
    public static int count = 0;
    private List<Dictionary<string, object>> data;
    public FadeInOut fade;

    public GameObject HealthControlScript;
    public void TextColorChange()
    {
        data[count]["Script"] = data[count]["Script"].ToString().Replace("ⓑ", "<color=#2782cc>");//파란색 "중요한부분"
        data[count]["Script"] = data[count]["Script"].ToString().Replace("ⓡ", "<color=#a83a22>");//빨간색 (생명력 -)
        data[count]["Script"] = data[count]["Script"].ToString().Replace("ⓖ", "<color=#13c216>");//초록색 (생명력 +) 
        data[count]["Script"] = data[count]["Script"].ToString().Replace("ⓔ", "</color>");// 바꿀 색깔이 끝났을때 쓰는 기호
    }
    public void Showdialogue()// 처음시작할때 다 초기화하고 대화내용을 보여주는 함수
    {
        txt_dialogue.gameObject.SetActive(true);
        txt_name.gameObject.SetActive(true);
        count = 0;
        isDialogue = true;
        //Nextdialogue();
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
        count++;
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
    }
    private void Start()
    {
        data = CSVReader.Read("Day3-3");
        HealthControlScript.GetComponent<HealthControlScript>().Show_Health();
        Showdialogue();
    }

    private void day3_3_JD()
    {
        if (count < data.Count)
        {
            Nextdialogue();
            if (count == 9)
            {//역시.. 그런가요?
                count += 3;
            }
            if (count == 29)
            {//안녕히 계세요
                count += 9;
            }
            if (count == 55)
            {//나한테 줬다 하면 별말 안할겨
                count += 7;
            }
            if (count == 71)
            {//이 조그만 거 하나 주기 어렵나?
                count += 6;
            }
            if (count == 96)
            {//닦기도 싫다.. 
                count += 23;
            }
            if (count == 107)
            {//…안녕히 가세요.
                count += 11;
            }
            if (count == 134)
            {//…흠, 잘 된 일일지도.
                count += 7;
            }
            if (count == 149)
            {//이곳에 와서야 깨닫다니.
                count += 6;
            }
            if (count == 160)
            {//무례를 범했군ㅡ
                count += 5;
            }
        }
        else
        {
            fade.Fade();
            Hidedialogue();
        }
    }

    private void day3_3_HC()
    {
        if (count == 25)
        {//신경써주신 게 너무 감사해서요
            HealthControlScript.GetComponent<HealthControlScript>().health_increase();
        }
        if (count == 95)
        {//진상 5(남)는 바닥에 가래침을 뱉고서
            SaveData.JSName = "JS5";
            HealthControlScript.GetComponent<HealthControlScript>().health_decrease();
        }
        if(count == 109)
        {//저도 제 돈에서 까는거에요..
            SaveData.JSName = "JS5";
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
                day3_3_JD();
                day3_3_HC();
            }
        }
        else
            Hidedialogue();
    }
}
