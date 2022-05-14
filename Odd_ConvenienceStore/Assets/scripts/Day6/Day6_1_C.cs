using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

[System.Serializable]
public class day6_1choice
{
    [TextArea]
    public string _choice;
    public string _choice2;
}
public class Day6_1_C : MonoBehaviour
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
        SaveData.reGame = Day6_1.count;
        SaveData.reGameStart = "Day6-1";
        SaveData.reGameChoice = count;
        SaveData.Saves();
    }
    public void NextChoice1()
    {
        count++;
        day6_1_1();
        ChoiceOff();
    }
    public void NextChoice2()
    {
        count++;
        day6_1_2();
        ChoiceOff();

    }
    public void ChoiceOn()
    {
        Day6_1.isDialogue = false;
        choicebtn1.gameObject.SetActive(true);
        choicebtn2.gameObject.SetActive(true);
        txt_choice1.gameObject.SetActive(true);
        txt_choice2.gameObject.SetActive(true);
    }
    public void ChoiceOff()
    {
        Day6_1.isDialogue = true;
        choicebtn1.gameObject.SetActive(false);
        choicebtn2.gameObject.SetActive(false);
        txt_choice1.gameObject.SetActive(false);
        txt_choice2.gameObject.SetActive(false);
    }
    private void day6_1()
    {
        if (Day6_1.count == 10)
        {
            ShowChoice();
        }

        if (Day6_1.count == 68)
        {
            ShowChoice();
        }

        if (Day6_1.count == 90)
        {
            ShowChoice();
        }
    }
    private void day6_1_1()
    {
        if (Day6_1.count == 10)
        {
            Day6_1.count++;
        }

        if (Day6_1.count == 68)
        {
            Day6_1.count++;
        }

        if (Day6_1.count == 90)
        {
            Day6_1.count++;
        }
    }
    private void day6_1_2()
    {
        if (Day6_1.count == 10)
        {
            Day6_1.count += 19 - 10;
        }

        if (Day6_1.count == 68)
        {
            Day6_1.count += 79 - 68;
        }

        if (Day6_1.count == 90)
        {
            Day6_1.count += 103 - 90;
        }
    }

    public void CallChoice()
    {
        day6_1();
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
