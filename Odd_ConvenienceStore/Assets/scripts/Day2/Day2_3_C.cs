using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

[System.Serializable]
public class day2_3choice
{
    [TextArea]
    public string _choice;
    public string _choice2;
}
public class Day2_3_C : MonoBehaviour
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
        SaveData.reGame = Day2_3.count;
        SaveData.reGameStart = "Day2-3";
        SaveData.reGameChoice = count;
        SaveData.Saves();
    }
    public void NextChoice1()
    {
        count++;
        day2_3_1();
        ChoiceOff();
    }
    public void NextChoice2()
    {
        count++;
        day2_3_2();
        ChoiceOff();

    }
    public void ChoiceOn()
    {
        Day2_3.isDialogue = false;
        choicebtn1.gameObject.SetActive(true);
        choicebtn2.gameObject.SetActive(true);
        txt_choice1.gameObject.SetActive(true);
        txt_choice2.gameObject.SetActive(true);
    }
    public void ChoiceOff()
    {
        Day2_3.isDialogue = true;
        choicebtn1.gameObject.SetActive(false);
        choicebtn2.gameObject.SetActive(false);
        txt_choice1.gameObject.SetActive(false);
        txt_choice2.gameObject.SetActive(false);
    }
    private void day2_3()
    {
        if (Day2_3.count == 10)
        {
            ShowChoice();
        }
        if (Day2_3.count == 34)
        {
            count = 1;
            ShowChoice();
        }
        if (Day2_3.count == 53)
        {
            count = 2;
            ShowChoice();
        }
        if (Day2_3.count == 58)
        {
            count = 3;
            ShowChoice();
        }
        if (Day2_3.count == 71)
        {
            count = 4;
            ShowChoice();
        }


    }
    private void day2_3_1()
    {


        if (Day2_3.count == 10)
        {
            Day2_3.count++;
        }
        if (Day2_3.count == 34)
        {
            Day2_3.count++;
        }
        if (Day2_3.count == 53)
        {
            Day2_3.count++;
        }
        if (Day2_3.count == 58)
        {
            Day2_3.count++;
        }
        if (Day2_3.count == 71)
        {
            Day2_3.count++;
        }

    }
    private void day2_3_2()
    {
        if (Day2_3.count == 10)
        {
            Day2_3.count += 15 - 10;
        }
        if (Day2_3.count == 34)
        {
            Day2_3.count += 43 - 34;
        }
        if (Day2_3.count == 53)
        {
            Day2_3.count += 62 - 53;
        }
        if (Day2_3.count == 58)
        {
            Day2_3.count += 65 - 58;
        }
        if (Day2_3.count == 71)
        {
            Day2_3.count += 62 - 71;
        }



    }

    public void CallChoice()
    {
        day2_3();
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
