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

    public static bool isChoice = false;
    public static int count = 0;
    [SerializeField] private day3_1_c[] choice;
    public void ShowChoice()
    {
        ChoiceOn();
        txt_choice1.text = choice[count]._choice;
        txt_choice2.text = choice[count]._choice2;

        SaveData.Loads();
        SaveData.reGame = Day3_1.count;
        SaveData.reGameStart = "Day3-1";
        SaveData.reGameChoice = count;
        SaveData.Saves();
    }

    public void NextChoice1()
    {
        count++;
        if (Day3_1.count == 25)
        {
            Day3_1.count++;
        }
        if (Day3_1.count == 35)
        {
            Day3_1.count++;
        }
        if (Day3_1.count == 40)
        {
            count++;
            Day3_1.count++;
        }
        if (Day3_1.count == 54)
        {
            Day3_1.count++;
        }
        if (Day3_1.count == 63)
        {
            count++;
            Day3_1.count++;
        }
        if (Day3_1.count == 81)
        {
            Day3_1.count++;
        }
        if (Day3_1.count == 110)
        {
            count++;
            Day3_1.count++;
        }
        if (Day3_1.count == 124)
        {
            Day3_1.count++;
        }
        if (Day3_1.count == 136)
        {
            Day3_1.count++;
        }
        if (Day3_1.count == 144)
        {
            Day3_1.count++;
        }
        if (Day3_1.count == 154)
        {
            Day3_1.count++;
        }
        ChoiceOff();
    }

    public void NextChoice2()
    {
        count++;
        if (Day3_1.count == 25)
        {//뜸 들이지 마세요.
            Day3_1.count += 4;
        }
        if (Day3_1.count == 35)
        {//돈을 버세요
            count++;
            Day3_1.count += 13;
        }
        if (Day3_1.count == 40)
        {//갚으실 능력은?
            count++;
            Day3_1.count += 4;
        }
        if (Day3_1.count == 54)
        {//갚는다는 보장있어요?
            Day3_1.count += 4;
        }
        if (Day3_1.count == 63)
        {//나가주세요
            Day3_1.count += 8;
        }
        if (Day3_1.count == 81)
        {//왜 이러세요
            Day3_1.count += 10;
        }
        if (Day3_1.count == 110)
        {//일단 기다린다.
            Day3_1.count += 6;
        }
        if (Day3_1.count == 124)
        {//걸었는데요
            Day3_1.count += 5;
        }
        if (Day3_1.count == 136)
        {//담배를 준다.
            count++;
            Day3_1.count += 12;
        }
        if (Day3_1.count == 144)
        {//예 알겠습니다.
            Day3_1.count += 4;
        }
        if (Day3_1.count == 154)
        {//4500원입니다.
            Day3_1.count += 5;
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
        if (Day3_1.count == 25)
        {
            ShowChoice();
        }
        if (Day3_1.count == 35)
        {
            ShowChoice();
        }
        if (Day3_1.count == 40)
        {
            ShowChoice();
        }
        if (Day3_1.count == 54)
        {
            ShowChoice();
        }
        if (Day3_1.count == 63)
        {
            ShowChoice();
        }
        if (Day3_1.count == 81)
        {
            ShowChoice();
        }
        if (Day3_1.count == 110)
        {
            ShowChoice();
        }
        if (Day3_1.count == 124)
        {
            ShowChoice();
        }
        if (Day3_1.count == 136)
        {
            ShowChoice();
        }
        if (Day3_1.count == 144)
        {
            ShowChoice();
        }
        if (Day3_1.count == 154)
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
