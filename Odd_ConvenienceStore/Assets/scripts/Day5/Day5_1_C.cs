using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[System.Serializable]
public class day5_1_c
{
    [TextArea]
    public string _choice;
    public string _choice2;
}
public class Day5_1_C : MonoBehaviour
{
    [SerializeField] private Button choicebtn1;
    [SerializeField] private Button choicebtn2;
    [SerializeField] private Text txt_choice1;
    [SerializeField] private Text txt_choice2;


    public static int count = 0;
    [SerializeField] private day5_1_c[] choice;
    public void ShowChoice()
    {
        ChoiceOn();
        txt_choice1.text = choice[count]._choice;
        txt_choice2.text = choice[count]._choice2;

        SaveData.Loads();
        SaveData.reGame = Day5_1.count;
        SaveData.reGameStart = "Day5-1";
        SaveData.reGameChoice = count;
        SaveData.Saves();
    }

    public void NextChoice1()
    {
        count++;
        if (Day5_1.count == 16)
        {
            Day5_1.count++;
        }

        if (Day5_1.count == 22)
        {
            Day5_1.count++;
        }

        if (Day5_1.count == 42)
        {
            count += 2;
            Day5_1.count++;
        }

        if (Day5_1.count == 62)
        {
            Day5_1.count++;
        }

        if (Day5_1.count == 76)
        {
            Day5_1.count++;
        }

        if (Day5_1.count == 110)
        {
            Day5_1.count++;
        }

        if (Day5_1.count == 120)
        {
            Day5_1.count++;
        }

        if (Day5_1.count == 145)
        {
            Day5_1.count++;
        }

        ChoiceOff();
    }

    public void NextChoice2()
    {
        count++;
   
        if (Day5_1.count == 16)
        {//확인 안해서
            count += 2;
            Day5_1.count += 42;
        }

        if (Day5_1.count == 22)
        {//폐기 없어요
            Day5_1.count += 10;
        }

        if (Day5_1.count == 42)
        {//그렇게까지 저를..
            count += 2;
            Day5_1.count += 10;
        }

        if (Day5_1.count == 62)
        {// 그걸 왜 확인하세요?
            Day5_1.count += 8;
        }

        if (Day5_1.count == 76)
        {// 폐기 드릴게요
            Day5_1.count += 9;
        }

        if (Day5_1.count == 110)
        {// 모니터에 가격 뜹니다.
            count++;
            Day5_1.count += 25;
        }

        if (Day5_1.count == 120)
        {//돈내고 찍으세요
            Day5_1.count += 5;
        }

        if (Day5_1.count == 145)
        {//먼저 저를 의심하셨잖아요
            Day5_1.count += 12;
        }
        ChoiceOff();
    }

    public void ChoiceOn()
    {
        Day5_1.isDialogue = false;
        choicebtn1.gameObject.SetActive(true);
        choicebtn2.gameObject.SetActive(true);
        txt_choice1.gameObject.SetActive(true);
        txt_choice2.gameObject.SetActive(true);
    }

    public void ChoiceOff()
    {
        Day5_1.isDialogue = true;
        choicebtn1.gameObject.SetActive(false);
        choicebtn2.gameObject.SetActive(false);
        txt_choice1.gameObject.SetActive(false);
        txt_choice2.gameObject.SetActive(false);
    }

    public void CallChoice()
    {
        if (Day5_1.count == 16)
        {
            ShowChoice();
        }

        if (Day5_1.count == 22)
        {
            ShowChoice();
        }

        if (Day5_1.count == 42)
        {
            ShowChoice();
        }

        if (Day5_1.count == 62)
        {
            ShowChoice();
        }

        if (Day5_1.count == 76)
        {
            ShowChoice();
        }

        if (Day5_1.count == 110)
        {
            ShowChoice();
        }

        if (Day5_1.count == 120)
        {
            ShowChoice();
        }

        if (Day5_1.count == 145)
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
