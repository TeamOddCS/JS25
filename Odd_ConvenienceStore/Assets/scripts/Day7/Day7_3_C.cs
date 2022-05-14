using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

[System.Serializable]
public class day7_1choice
{
    [TextArea]
    public string _choice;
    public string _choice2;
}
public class Day7_3_C : MonoBehaviour
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
        SaveData.reGame = Day7_3.count;
        SaveData.reGameStart = "Day7-3";
        SaveData.reGameChoice = count;
        SaveData.Saves();
    }
    public void NextChoice1()
    {
        count++;
        day7_3_1();
        ChoiceOff();
    }
    public void NextChoice2()
    {
        count++;
        day7_3_2();
        ChoiceOff();

    }
    public void ChoiceOn()
    {
        Day7_3.isDialogue = false;
        choicebtn1.gameObject.SetActive(true);
        choicebtn2.gameObject.SetActive(true);
        txt_choice1.gameObject.SetActive(true);
        txt_choice2.gameObject.SetActive(true);
    }
    public void ChoiceOff()
    {
        Day7_3.isDialogue = true;
        choicebtn1.gameObject.SetActive(false);
        choicebtn2.gameObject.SetActive(false);
        txt_choice1.gameObject.SetActive(false);
        txt_choice2.gameObject.SetActive(false);
    }
    private void day7_3()
    {
        if (Day7_3.count == 12)
        {
            ShowChoice();
        }
        if (Day7_3.count == 21)
        {
            ShowChoice();
        }
        if (Day7_3.count == 34)
        {
            count = 2;
            ShowChoice();
        }
        if (Day7_3.count == 55)
        {
            count = 3;
            ShowChoice();
        }
        if (Day7_3.count == 79)
        {
            count = 4;
            ShowChoice();
        }
        if (Day7_3.count == 92)
        {
            count = 5;
            ShowChoice();
        }
        if (Day7_3.count == 106)
        {
            count = 6;
            ShowChoice();
        }
        if (Day7_3.count == 126)
        {
            count = 7;
            ShowChoice();
        }
        if (Day7_3.count == 140)
        {
            count = 8;
            ShowChoice();
        }
        if (Day7_3.count == 177)
        {
            count = 9;
            ShowChoice();
        }
        if (Day7_3.count == 186)
        {
            count = 10;
            ShowChoice();
        }




    }
    private void day7_3_1()
    {

        if (Day7_3.count == 12)
        {
            Day7_3.count++;
            

        }
        if (Day7_3.count == 21)
        {
            Day7_3.count++;
        }
        if (Day7_3.count == 34)
        {
            Day7_3.count++;
        }
        if (Day7_3.count == 55)
        {
            Day7_3.count++;
        }
        if (Day7_3.count == 79)
        {
            Day7_3.count++;
        }
        if (Day7_3.count == 92)
        {
            Day7_3.count++;
        }
        if (Day7_3.count == 106)
        {
            Day7_3.count++;
        }
        if (Day7_3.count == 126)
        {
            Day7_3.count++;
        }
        if (Day7_3.count == 140)
        {
            Day7_3.count++;
        }
        if (Day7_3.count == 177)
        {
            Day7_3.count++;
        }
        if (Day7_3.count == 186)
        {
            Day7_3.count++;
        }



    }
    private void day7_3_2()
    {
        if (Day7_3.count == 12)
        {
          
            Day7_3.count += 17 - 12;

        }
        if (Day7_3.count == 21)
        {
            Day7_3.count += 26 - 21;
        }
        if (Day7_3.count == 34)
        {
            Day7_3.count += 41 - 34;
        }
        if (Day7_3.count == 55)
        {
            Day7_3.count += 60 - 55;
        }
        if (Day7_3.count == 79)
        {
            Day7_3.count += 86 - 79;
        }
        if (Day7_3.count == 92)
        {
            Day7_3.count += 96 - 92;
        }
        if (Day7_3.count == 106)
        {
            Day7_3.count += 115 - 106;
        }
        if (Day7_3.count == 126)
        {
            Day7_3.count += 132 - 126 ;
        }
        if (Day7_3.count == 140)
        {
            Day7_3.count += 146 - 140 ;
        }
        if (Day7_3.count == 177)
        {
            Day7_3.count += 211 - 177;
        }
        if (Day7_3.count == 186)
        {
            Day7_3.count += 198 - 186;
        }



    }

    public void CallChoice()
    {
        day7_3();
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
