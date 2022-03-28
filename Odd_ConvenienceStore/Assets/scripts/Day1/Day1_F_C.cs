using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[System.Serializable]
public class day0_f_c
{
    [TextArea]
    public string _choice;
    public string _choice2;
}
public class Day1_F_C : MonoBehaviour
{
    [SerializeField] private Button choicebtn1;
    [SerializeField] private Button choicebtn2;
    [SerializeField] private Text txt_choice1;
    [SerializeField] private Text txt_choice2;

    public static int count = 0;
    [SerializeField] private day1_3_c[] choice;
    public void ShowChoice()
    {
        ChoiceOn();
        txt_choice1.text = choice[count]._choice;
        txt_choice2.text = choice[count]._choice2;
    }
    public void NextChoice1()
    {
        count++;
        day1_f_1();
        ChoiceOff();
    }
    public void NextChoice2()
    {
        count++;
        day1_f_2();
        ChoiceOff();

    }
    public void ChoiceOn()
    {
        Day1_F.isDialogue = false;
        choicebtn1.gameObject.SetActive(true);
        choicebtn2.gameObject.SetActive(true);
        txt_choice1.gameObject.SetActive(true);
        txt_choice2.gameObject.SetActive(true);
    }
    public void ChoiceOff()
    {
        Day1_F.isDialogue = true;
        choicebtn1.gameObject.SetActive(false);
        choicebtn2.gameObject.SetActive(false);
        txt_choice1.gameObject.SetActive(false);
        txt_choice2.gameObject.SetActive(false);
    }
    private void day1_f()
    {
        if (Day1_F.count == 5)//일반4 첫번째 AB선택지
        {
            ShowChoice();
        }

    }
    private void day1_f_1()
    {
        if (Day1_F.count == 5)//일반4 AB선택지
        {
            Day1_F.count++;
        }
    }
    private void day1_f_2()
    {
        if (Day1_F.count == 5)//일반4 AB선택지
        {
            Day1_F.count += 3;
        }
    }

    public void CallChoice()
    {
        day1_f();

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
