using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
[System.Serializable]
public class day7_1_c
{
    [TextArea]
    public string _choice;
    public string _choice2;
}

public class Day7_1_C : MonoBehaviour
{
    [SerializeField] private Button choicebtn1;
    [SerializeField] private Button choicebtn2;
    [SerializeField] private Text txt_choice1;
    [SerializeField] private Text txt_choice2;

    public static int count = 0;
    [SerializeField] private day7_1_c[] choice;
    public void ShowChoice()
    {
        ChoiceOn();
        txt_choice1.text = choice[count]._choice;
        txt_choice2.text = choice[count]._choice2;

        SaveData.Loads();
        SaveData.reGame = Day7_1.count;
        SaveData.reGameStart = "Day7-1";
        SaveData.reGameChoice = count;
        SaveData.Saves();
    }
    public void NextChoice1()
    {
        count++;
        day7_1_1();
        ChoiceOff();
    }
    public void NextChoice2()
    {
        count++;
        day7_1_2();
        ChoiceOff();

    }
    public void ChoiceOn()
    {
        Day7_1.isDialogue = false;      
        choicebtn1.gameObject.SetActive(true);
        choicebtn2.gameObject.SetActive(true);
        txt_choice1.gameObject.SetActive(true);
        txt_choice2.gameObject.SetActive(true);
    }
    public void ChoiceOff()
    {
        Day7_1.isDialogue = true;    
        choicebtn1.gameObject.SetActive(false);
        choicebtn2.gameObject.SetActive(false);
        txt_choice1.gameObject.SetActive(false);
        txt_choice2.gameObject.SetActive(false);
    }
    private void day7_1()
    {
        if (Day7_1.count == 14)//일반4 첫번째 AB선택지
        {
            ShowChoice();
        }
        if (Day7_1.count == 23)//일반7 첫번째 AB선택지
        {
            ShowChoice();
        }
        if (Day7_1.count == 66)//일반7 두번째 AB선택지
        {
            ShowChoice();
        }
        if (Day7_1.count == 79)//일반7 세번째 AB선택지
        {
            ShowChoice();
        }

    }
    private void day7_1_1()
    {
        if (Day7_1.count == 14)//일반4 AB선택지
        {
            Day7_1.count++;
        }
        if (Day7_1.count == 23)//일반7 첫번째 A선택지
        {
            Day7_1.count++;
        }
        if (Day7_1.count == 66)//일반7 두번째 A선택지
        {
            Day7_1.count++;
        }
        if (Day7_1.count == 79)//일반7 세번째 A선택지
        {
            Day7_1.count++;
        }


    }
    private void day7_1_2()
    {
        if (Day7_1.count == 14)//일반4 AB선택지
        {
            Day7_1.count += 4;
        }
        if (Day7_1.count == 23)//일반7 첫번째 B선택지
        {
            Day7_1.count += 17;
        }
        if (Day7_1.count == 66)//일반7 두번째 B선택지
        {
            Day7_1.count += 8;
        }
        if (Day7_1.count == 79)//일반7 세번째 B선택지
        {
            Day7_1.count += 10;
        }

    }




    public void CallChoice()
    {
        day7_1();

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
