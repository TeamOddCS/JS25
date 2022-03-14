using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

[System.Serializable]
public class day1_1choice
{
    [TextArea]
    public string _choice;
    public string _choice2;
}
public class Day1_1_C : MonoBehaviour
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
    }
    public void NextChoice1()
    {
        count++;
        day1_1_1();
        ChoiceOff();
    }
    public void NextChoice2()
    {
        count++;
        day1_1_2();
        ChoiceOff();

    }
    public void ChoiceOn()
    {
        Day1_1.isDialogue = false;
        choicebtn1.gameObject.SetActive(true);
        choicebtn2.gameObject.SetActive(true);
        txt_choice1.gameObject.SetActive(true);
        txt_choice2.gameObject.SetActive(true);
    }
    public void ChoiceOff()
    {
        Day1_1.isDialogue = true;
        choicebtn1.gameObject.SetActive(false);
        choicebtn2.gameObject.SetActive(false);
        txt_choice1.gameObject.SetActive(false);
        txt_choice2.gameObject.SetActive(false);
    }
    private void day1_1()
    {
        if (Day1_1.count == 34)
        {
            ShowChoice();
        }
        if (Day1_1.count == 41)
        {
            ShowChoice();
        }
        if (Day1_1.count == 54)
        {
            count = 2;
            ShowChoice();
        }
        if (Day1_1.count == 95)
        {
            count = 3;
            ShowChoice();
        }
        if (Day1_1.count == 107)
        {
            count = 4;
            ShowChoice();
        }
        if (Day1_1.count == 115)
        {
            count = 5;
            ShowChoice();
        }

    }
    private void day1_1_1()
    {
        

        if (Day1_1.count == 34)
        {
            Day1_1.count++;
        }
        if (Day1_1.count == 41)
        {
            Day1_1.count++;
        }
        if (Day1_1.count == 54)
        {
            Day1_1.count++;
        }
        if (Day1_1.count == 95)
        {
            Day1_1.count++;
        }
        if (Day1_1.count == 107)
        {
            Day1_1.count++;
        }
        if (Day1_1.count == 115)
        {
            Day1_1.count++;
        }

    }
    private void day1_1_2()
    {
       
        if (Day1_1.count == 34)
        {
            Day1_1.count += 50 - 34;
        }
        if (Day1_1.count == 41)
        {
            Day1_1.count += 46 - 41;
        }
        if (Day1_1.count == 54)
        {
            Day1_1.count += 59 - 54;
        }
        if (Day1_1.count == 95)
        {
            Day1_1.count += 101 - 95;
        }
        if (Day1_1.count == 107)
        {
            Day1_1.count += 111 - 107;
        }
        if (Day1_1.count == 115)
        {
            Day1_1.count += 118 - 115;
        }


    }

    public void CallChoice()
    {
        day1_1();
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
