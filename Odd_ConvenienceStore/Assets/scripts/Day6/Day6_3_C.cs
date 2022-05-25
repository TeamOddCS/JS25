using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

[System.Serializable]
public class day6_3choice
{
    [TextArea]
    public string _choice;
    public string _choice2;
}
public class Day6_3_C : MonoBehaviour
{
    [SerializeField] private Button choicebtn1;
    [SerializeField] private Button choicebtn2;
    [SerializeField] private Text txt_choice1;
    [SerializeField] private Text txt_choice2;
    public static bool isChoice = false;
    public static int count = 0;
    [SerializeField] private js4choice[] choice;
    public void ShowChoice()
    {
        ChoiceOn();
        txt_choice1.text = choice[count]._choice;
        txt_choice2.text = choice[count]._choice2;

        SaveData.Loads();
        SaveData.reGame = Day6_3.count;
        SaveData.reGameStart = "Day6-3";
        SaveData.reGameChoice = count;
        SaveData.Saves();
    }
    public void NextChoice1()
    {
        count++;
        day6_3_1();
        ChoiceOff();
    }
    public void NextChoice2()
    {
        count++;
        day6_3_2();
        ChoiceOff();

    }
    public void ChoiceOn()
    {
        Day6_3.isDialogue = false;
        choicebtn1.gameObject.SetActive(true);
        choicebtn2.gameObject.SetActive(true);
        txt_choice1.gameObject.SetActive(true);
        txt_choice2.gameObject.SetActive(true);
    }
    public void ChoiceOff()
    {
        Day6_3.isDialogue = true;
        choicebtn1.gameObject.SetActive(false);
        choicebtn2.gameObject.SetActive(false);
        txt_choice1.gameObject.SetActive(false);
        txt_choice2.gameObject.SetActive(false);
    }
    private void day6_3_1()
    {
        if (Day6_3.count == 5)
        {
            Day6_3.count += 8 - 5;
           
        }
        if (Day6_3.count == 7)
        {
            Day6_3.count += 14 - 7;
        }
        if (Day6_3.count == 35)
        {
            Day6_3.count++;
        }
        if (Day6_3.count == 47)
        {
            Day6_3.count++;
        }
        if (Day6_3.count == 76)
        {
            Day6_3.count++;
        }
        if (Day6_3.count == 87)
        {
            Day6_3.count++;
        }
        if (Day6_3.count == 97)
        {
            Day6_3.count++;
        }
        if (Day6_3.count == 124)
        {
            Day6_3.count++;
        }
        if (Day6_3.count == 150)
        {
            Day6_3.count++;
        }
        if (Day6_3.count == 175)
        {
            Day6_3.count++;
        }
        if (Day6_3.count == 192)
        {
            Day6_3.count++;
        }


    }
    private void day6_3()
    {
        if (Day6_3.count == 5)
        {
            count = 0;
            ShowChoice();
        }
        if (Day6_3.count == 7)
        {
            count = 1;
            ShowChoice();
        }
        if (Day6_3.count == 35)
        {
            count = 2;
            ShowChoice();
        }
        if (Day6_3.count == 47)
        {
            count = 3;
            ShowChoice();
        }
        if (Day6_3.count == 76)
        {
            count = 4;
            ShowChoice();
        }
        if (Day6_3.count == 87)
        {
            count = 5;
            ShowChoice();
        }
        if (Day6_3.count == 97)
        {
            count = 6;
            ShowChoice();
        }
        if (Day6_3.count == 124)
        {
            count = 7;
            ShowChoice();
        }
        if (Day6_3.count == 150)
        {
            count = 8;
            ShowChoice();
        }
        if (Day6_3.count == 175)
        {
            count = 9;
            ShowChoice();
        }
        if (Day6_3.count == 192)
        {
            count = 10;
            ShowChoice();
        }

    }
    private void day6_3_2()
    {
       
        if (Day6_3.count == 5)
        {
            Day6_3.count++; 

        }
        if (Day6_3.count == 7)
        {
            Day6_3.count += 20 - 7;
        }
        if (Day6_3.count == 35)
        {
            Day6_3.count += 42 - 35;
        }
        if (Day6_3.count == 47)
        {
            Day6_3.count += 51 - 47;
        }
        if (Day6_3.count == 76)
        {
            Day6_3.count += 82 - 76;
        }
        if (Day6_3.count == 87)
        {
            Day6_3.count += 92 - 87;
        }
        if (Day6_3.count == 97)
        {
            Day6_3.count += 108 - 97;
        }
        if (Day6_3.count == 124)
        {
            Day6_3.count += 134 - 124;
        }
        if (Day6_3.count == 150)
        {
            Day6_3.count += 157 - 150;
        }
        if (Day6_3.count == 175)
        {
            Day6_3.count += 187 - 175;
        }
        if (Day6_3.count == 192)
        {
            Day6_3.count += 197 - 192;
        }
    }

    public void CallChoice()
    {
        day6_3();
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
