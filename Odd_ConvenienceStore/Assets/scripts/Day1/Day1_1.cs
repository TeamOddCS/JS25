using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Day1_1 : MonoBehaviour
{
    [SerializeField] private Text txt_name;// 이름 담는 객체 
    [SerializeField] private Text txt_dialogue; //대화내용 담는 객체
    public static bool isDialogue = false;
    public static int count = 0;
    private List<Dictionary<string, object>> data;
    public FadeInOut fade;



    public void Showdialogue()// 처음시작할때 다 초기화하고 대화내용을 보여주는 함수
    {
        txt_dialogue.gameObject.SetActive(true);
        txt_name.gameObject.SetActive(true);
        count = 0;
        isDialogue = true;
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
        txt_dialogue.text = data[count]["Script"].ToString();
        count++;
    }


    private void Hidedialogue()//대화가 끝났으면 대화내용 숨기는 함수
    {
        txt_name.gameObject.SetActive(false);
        txt_dialogue.gameObject.SetActive(false);
        isDialogue = false;
    }
    private void day1_1_JD()//첫번째 선택지를 골랐을 경우 선택지 대화를 다본후 다음 대화로 넘어가는 함수
    {
        if (count < data.Count)
        {
            Nextdialogue();
            if (count == 3)
            {
                GameControlScript.health -= 1;
            }

            if (count == 45)
            {
                count += 64 - 45;
            }

            if (count == 48)
            {
                count += 64 - 48;
            }
            if (count == 58)
            {
                count += 64 - 58;
            }
            if (count == 62)
            {
                count += 64 - 62;
            }
            if (count == 101)
            {
                count += 105 - 101;
            }
            if (count == 105)
            {
                count += 105 - 105;
            }
            if (count == 111)
            {
                count += 115 - 111;
            }
          
            if (count == 125)
            {
                fade.Fade();
                Hidedialogue();
            }
        }
        else
        {
            fade.Fade();
            Hidedialogue();
            SceneManager.LoadScene("Day2-1");
        }
    }
    private void Start()
    {
        data = CSVReader.Read("Day1-1");
        Showdialogue();
    }
    // Update is called once per frame
    void Update()
    {
        if (isDialogue)
        {
            if (Input.GetMouseButtonUp(0))
            {
                day1_1_JD();
            }
        }
        else
            Hidedialogue();
    }
}
