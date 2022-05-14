using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

[System.Serializable]
public class day4_1choice
{
    [TextArea]
    public string _choice;
    public string _choice2;
}
public class Day4_1_C : MonoBehaviour
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
        SaveData.reGame = Day4_1.count;
        SaveData.reGameStart = "Day4-1";
        SaveData.reGameChoice = count;
        SaveData.Saves();
    }
    public void NextChoice1()
    {
        count++;
        day4_1_1();
        ChoiceOff();
    }
    public void NextChoice2()
    {
        count++;
        day4_1_2();
        ChoiceOff();

    }
    public void ChoiceOn()
    {
        Day4_1.isDialogue = false;
        choicebtn1.gameObject.SetActive(true);
        choicebtn2.gameObject.SetActive(true);
        txt_choice1.gameObject.SetActive(true);
        txt_choice2.gameObject.SetActive(true);
    }
    public void ChoiceOff()
    {
        Day4_1.isDialogue = true;
        choicebtn1.gameObject.SetActive(false);
        choicebtn2.gameObject.SetActive(false);
        txt_choice1.gameObject.SetActive(false);
        txt_choice2.gameObject.SetActive(false);
    }
    private void day4_1()
    {
        if (Day4_1.count == 13)
        {
            ShowChoice();
        }

        if (Day4_1.count == 18)
        {
            ShowChoice();
        }

        if (Day4_1.count == 29)
        {
            count = 2;
            ShowChoice();
        }

        if (Day4_1.count == 40)
        {
            count = 3;
            ShowChoice();
        }

        if (Day4_1.count == 53)
        {
            count = 4;
            ShowChoice();
        }

        if (Day4_1.count == 70)
        {
            count = 5;
            ShowChoice();
        }

        if (Day4_1.count == 79)
        {
            count = 6;
            ShowChoice();
        }
    }
    private void day4_1_1()
    {
        if (Day4_1.count == 13)
        {
            Day4_1.count++;
        }

        if (Day4_1.count == 18)
        {
            Day4_1.count++;
        }

        if (Day4_1.count == 29)
        {
            Day4_1.count += 34 - 29;
        }

        if (Day4_1.count == 40)
        {
            Day4_1.count++;
        }

        if (Day4_1.count == 53)
        {
            Day4_1.count++;
        }

        if (Day4_1.count == 70)
        {
            Day4_1.count++;
        }

        if (Day4_1.count == 79)
        {
            Day4_1.count++;
        }
    }
    private void day4_1_2()
    {
        if (Day4_1.count == 13)
        {
            Day4_1.count += 28 - 13;
        }

        if (Day4_1.count == 18)
        {
            Day4_1.count += 23 - 18;
        }

        if (Day4_1.count == 29)
        {
            Day4_1.count ++;
        }

        if (Day4_1.count == 40)
        {
            Day4_1.count += 50 - 40;
        }

        if (Day4_1.count == 53)
        {
            Day4_1.count = 41;
        }

        if (Day4_1.count == 70)
        {
            Day4_1.count += 74 - 70;
        }

        if (Day4_1.count == 79)
        {
            Day4_1.count += 91 - 79;
        }
    }

    public void CallChoice()
    {
        day4_1();
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
