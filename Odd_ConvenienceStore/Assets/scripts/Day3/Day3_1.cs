using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Day3_1 : MonoBehaviour
{
    [SerializeField] private Text txt_dialogue; //대화내용 담는 객체
    [SerializeField] private Text txt_name;// 이름 담는 객체 
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
        txt_dialogue.text = data[count]["Script"].ToString();
        count++;
    }

    private void Hidedialogue()//대화가 끝났으면 대화내용 숨기는 함수
    {
        txt_name.gameObject.SetActive(false);
        txt_dialogue.gameObject.SetActive(false);
        isDialogue = false;
    }
    private void Start()
    {
        data = CSVReader.Read("Day3-1");
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
                    {//형편이 좋지 않은 것 뿐입니다.
                        count += 3;
                    }
                    if(count == 42)
                    {//3일째 굶고 있습니다.
                        count += 18;
                    }
                    if (count == 46)
                    {//수입이 생기면 바로 갚겠습니다.
                        count += 14;
                    }
                    if (count == 56)
                    {//직업이라고 할 순 없지만, 제가 할 수 있는 건 그것밖에 없어요.
                        count += 4;
                    }
                    if (count == 69)
                    {//언젠간… 갚겠지?
                        count += 30;
                    }
                    if (count == 89)
                    {//정리하느라 땀 좀 뺄 것 같다..
                        count += 10;
                    }
                    if (count == 114)
                    {//말보루 블랙민트 하나요.
                        count += 19;
                    }
                    if (count == 127)
                    {//말보루 블랙민트 하나요.(뭐드릴까요 다음)
                        count += 6;
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
