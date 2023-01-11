using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[System.Serializable]
public class day0_c
{
    [TextArea]
    public string _choice;
    public string _choice2;
}
public class Day0_C : MonoBehaviour
{
    [SerializeField] private Button choicebtn1;
    [SerializeField] private Button choicebtn2;
    [SerializeField] private Text txt_choice1;
    [SerializeField] private Text txt_choice2;
    public static bool isChoice = false;
    public static int count = 0;
    [SerializeField] private day1_3_c[] choice;
    public void ShowChoice()
    {
        ChoiceOn();
        txt_choice1.text = choice[count]._choice;
        txt_choice2.text = choice[count]._choice2;

        SaveData.Loads();
        SaveData.reGame = Day0.count;
        SaveData.reGameStart = "Day0";
        SaveData.reGameChoice = count;
        SaveData.Saves();
    }
    public void NextChoice1()
    {
        count++;
        day0_1();
        ChoiceOff();
    }
    public void NextChoice2()
    {
        count++;
        day0_2();
        ChoiceOff();

    }
    public void ChoiceOn()
    {
        Day0.isDialogue = false;
        choicebtn1.gameObject.SetActive(true);
        choicebtn2.gameObject.SetActive(true);
        txt_choice1.gameObject.SetActive(true);
        txt_choice2.gameObject.SetActive(true);
    }
    public void ChoiceOff()
    {
        Day0.isDialogue = true;
        choicebtn1.gameObject.SetActive(false);
        choicebtn2.gameObject.SetActive(false);
        txt_choice1.gameObject.SetActive(false);
        txt_choice2.gameObject.SetActive(false);
    }
    private void day0()
    {
        if (Day0.count == 9)//일반4 첫번째 AB선택지
        {
            ShowChoice();
        }

    }
    private void day0_1()
    {
        if (Day0.count == 9)//일반4 AB선택지
        {
            Day0.count++;
        }
    }
    private void day0_2()
    {
        if (Day0.count == 9)//일반4 AB선택지
        {
            Day0.count += 5;
        }  
    }

    public void CallChoice()
    {
        day0();

    }
    private void Start()
    {
        count = 0;
        ChoiceOff();
    }
    private void Update()
    {
        CallChoice();
    }
}