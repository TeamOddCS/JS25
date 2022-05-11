using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

[System.Serializable]
public class day2_1choice
{
    [TextArea]
    public string _choice;
    public string _choice2;
}
public class Day2_1_C : MonoBehaviour
{
    [SerializeField] private Button choicebtn1;
    [SerializeField] private Button choicebtn2;
    [SerializeField] private Text txt_choice1;
    [SerializeField] private Text txt_choice2;

    public static int count = 0;
    [SerializeField] private js4choice[] choice;
    public void ShowChoice()
    {
        ChoiceOn();
        txt_choice1.text = choice[count]._choice;
        txt_choice2.text = choice[count]._choice2;

        SaveData.Loads();
        SaveData.reGame = Day2_1.count;
        SaveData.reGameStart = "Day2-1";
        SaveData.reGameChoice = count;
        SaveData.Saves();
    }
    public void NextChoice1()
    {
        count++;
        day2_1_1();
        ChoiceOff();
    }
    public void NextChoice2()
    {
        count++;
        day2_1_2();
        ChoiceOff();

    }
    public void ChoiceOn()
    {
        Day2_1.isDialogue = false;
        choicebtn1.gameObject.SetActive(true);
        choicebtn2.gameObject.SetActive(true);
        txt_choice1.gameObject.SetActive(true);
        txt_choice2.gameObject.SetActive(true);
    }
    public void ChoiceOff()
    {
        Day2_1.isDialogue = true;
        choicebtn1.gameObject.SetActive(false);
        choicebtn2.gameObject.SetActive(false);
        txt_choice1.gameObject.SetActive(false);
        txt_choice2.gameObject.SetActive(false);
    }
    private void day2_1()
    {
        if (Day2_1.count == 9)
        {
            ShowChoice();
        }
        if (Day2_1.count == 22)
        {
            ShowChoice();
        }
        if (Day2_1.count == 38)
        {
            count = 2;
            ShowChoice();
        }
        if (Day2_1.count == 47)
        {
            count = 3;
            ShowChoice();
        }
        if (Day2_1.count == 79)
        {
            count = 4;
            ShowChoice();
        }
        if (Day2_1.count == 110)
        {
            count = 5;
            ShowChoice();
        }
        if (Day2_1.count == 118)
        {
            count = 6;
            ShowChoice();
        }
        if (Day2_1.count == 136)
        {
            count = 7;
            ShowChoice();
        }
        if (Day2_1.count == 156)
        {
            count = 8;
            ShowChoice();
        }
        if (Day2_1.count == 160)
        {
            count = 9;
            ShowChoice();
        }
        if (Day2_1.count == 174)
        {
            count = 10;
            ShowChoice();
        }
        if (Day2_1.count == 196)
        {
            count = 11;
            ShowChoice();
        }
        if (Day2_1.count == 205)
        {
            count = 12;
            ShowChoice();
        }


    }
    private void day2_1_1()
    {

        if (Day2_1.count == 9)
        {
            Day2_1.count++;
        }
        if (Day2_1.count == 22)
        {
            Day2_1.count++;
        }
        if (Day2_1.count == 38)
        {
            Day2_1.count++;
        }
        if (Day2_1.count == 47)
        {
            Day2_1.count++;
        }
        if (Day2_1.count == 79)
        {
            Day2_1.count++;
        }
        if (Day2_1.count == 110)
        {
            Day2_1.count++;
        }
        if (Day2_1.count == 118)
        {
            Day2_1.count += 111 - 118;
        }
        if (Day2_1.count == 136)
        {
            Day2_1.count++;
        }
        if (Day2_1.count == 156)
        {
            Day2_1.count++;
        }
        if (Day2_1.count == 160)
        {
            Day2_1.count++;
        }
        if (Day2_1.count == 174)
        {
            Day2_1.count++;
        }
        if (Day2_1.count == 196)
        {
            Day2_1.count++;
        }
        if (Day2_1.count == 205)
        {
            Day2_1.count++;
        }


    }
    private void day2_1_2()
    {
        if (Day2_1.count == 9)
        {
            
            Day2_1.count += 14 - 9;
        }
        if (Day2_1.count == 22)
        {
            Day2_1.count += 27 - 22;
        }
        if (Day2_1.count == 38)
        {
            Day2_1.count += 72 - 38;
        }
        if (Day2_1.count == 47)
        {
            Day2_1.count += 56 - 47;
        }
        if (Day2_1.count == 79)
        {
            Day2_1.count += 92 - 79;
        }
        if (Day2_1.count == 110)
        {
            Day2_1.count += 127 - 110;
        }
        if (Day2_1.count == 118)
        {
            Day2_1.count++;
        }
        if (Day2_1.count == 136)
        {
            Day2_1.count += 143 - 136;
        }
        if (Day2_1.count == 156)
        {
            Day2_1.count += 171 - 156;
        }
        if (Day2_1.count == 160)
        {
            Day2_1.count += 166 - 160;
        }
        if (Day2_1.count == 174)
        {
            Day2_1.count += 178 - 174;
        }
        if (Day2_1.count == 196)
        {
            Day2_1.count += 201 - 196;
        }
        if (Day2_1.count == 205)
        {
            Day2_1.count += 210 - 205;
        }


    }

    public void CallChoice()
    {
        day2_1();
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
