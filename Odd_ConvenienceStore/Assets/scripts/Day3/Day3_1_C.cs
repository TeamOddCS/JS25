using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[System.Serializable]
public class day3_1_c
{
    [TextArea]
    public string _choice;
    public string _choice2;
}
public class Day3_1_C : MonoBehaviour
{
    [SerializeField] private Button choicebtn1;
    [SerializeField] private Button choicebtn2;
    [SerializeField] private Text txt_choice1;
    [SerializeField] private Text txt_choice2;


    public static int count = 0;
    [SerializeField] private day3_1_c[] choice;
    public void ShowChoice()
    {
        ChoiceOn();
        txt_choice1.text = choice[count]._choice;
        txt_choice2.text = choice[count]._choice2;
    }

    public void NextChoice1()
    {
        count++;
        if (Day3_1.count == 23)
        {
            Day3_1.count++;
        }
        if (Day3_1.count == 33)
        {
            Day3_1.count++;
        }
        if (Day3_1.count == 38)
        {
            Day3_1.count++;
        }
        if (Day3_1.count == 52)
        {
            Day3_1.count++;
        }
        if (Day3_1.count == 61)
        {
            Day3_1.count++;
        }
        if (Day3_1.count == 79)
        {
            Day3_1.count++;
        }
        if (Day3_1.count == 108)
        {
            Day3_1.count++;
        }
        if (Day3_1.count == 122)
        {
            Day3_1.count++;
        }
        if (Day3_1.count == 134)
        {
            Day3_1.count++;
        }
        if (Day3_1.count == 142)
        {
            Day3_1.count++;
        }
        if (Day3_1.count == 152)
        {
            Day3_1.count++;
        }
        ChoiceOff();
    }

    public void NextChoice2()
    {
        count++;
        if (Day3_1.count == 23)
        {//뜸 들이지 마세요.
            Day3_1.count += 4;
        }
        if (Day3_1.count == 33)
        {//돈을 버세요
            Day3_1.count += 13;
        }
        if (Day3_1.count == 38)
        {//갚으실 능력은?
            Day3_1.count += 4;
        }
        if (Day3_1.count == 52)
        {//갚는다는 보장있어요?
            Day3_1.count += 4;
        }
        if (Day3_1.count == 61)
        {//나가주세요
            Day3_1.count += 8;
        }
        if (Day3_1.count == 79)
        {//왜 이러세요
            Day3_1.count += 10;
        }
        if (Day3_1.count == 108)
        {//일단 기다린다.
            Day3_1.count += ;
        }
        if (Day3_1.count == 122)
        {//걸었는데요
            Day3_1.count += ;
        }
        if (Day3_1.count == 134)
        {//담배를 준다.
            Day3_1.count += ;
        }
        if (Day3_1.count == 142)
        {//예 알겠습니다.
            Day3_1.count += ;
        }
        if (Day3_1.count == 152)
        {//4500원입니다.
            Day3_1.count += ;
        }

        ChoiceOff();
    }

    public void ChoiceOn()
    {
        Day3_1.isDialogue = false;
        choicebtn1.gameObject.SetActive(true);
        choicebtn2.gameObject.SetActive(true);
        txt_choice1.gameObject.SetActive(true);
        txt_choice2.gameObject.SetActive(true);
    }

    public void ChoiceOff()
    {
        Day3_1.isDialogue = true;
        choicebtn1.gameObject.SetActive(false);
        choicebtn2.gameObject.SetActive(false);
        txt_choice1.gameObject.SetActive(false);
        txt_choice2.gameObject.SetActive(false);
    }

    public void CallChoice()
    {
        if (Day3_1.count == 7)
        {
            ShowChoice();
        }
    }

    private void Start()
    {
        ChoiceOff();
    }
    private void Update()
    {
        CallChoice();
    }
}
