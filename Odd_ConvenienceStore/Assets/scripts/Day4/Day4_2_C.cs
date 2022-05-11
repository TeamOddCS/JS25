using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

[System.Serializable]
public class day4_2choice
{
    [TextArea]
    public string _choice;
    public string _choice2;
}
public class Day4_2_C : MonoBehaviour
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
        SaveData.reGame = Day4_2.count;
        SaveData.reGameStart = "Day4-2";
        SaveData.reGameChoice = count;
        SaveData.Saves();
    }
    public void NextChoice1()
    {
        count++;
        day4_2_1();
        ChoiceOff();
    }
    public void NextChoice2()
    {
        count++;
        day4_2_2();
        ChoiceOff();

    }
    public void ChoiceOn()
    {
        Day4_2.isDialogue = false;
        choicebtn1.gameObject.SetActive(true);
        choicebtn2.gameObject.SetActive(true);
        txt_choice1.gameObject.SetActive(true);
        txt_choice2.gameObject.SetActive(true);
    }
    public void ChoiceOff()
    {
        Day4_2.isDialogue = true;
        choicebtn1.gameObject.SetActive(false);
        choicebtn2.gameObject.SetActive(false);
        txt_choice1.gameObject.SetActive(false);
        txt_choice2.gameObject.SetActive(false);
    }
    private void day4_2()
    {
        if (Day4_2.count == 7)
        {
            ShowChoice();
        }

        if (Day4_2.count == 16)
        {
            ShowChoice();
        }
    }
    private void day4_2_1()
    {
        if (Day4_2.count == 7)
        {
            Day4_2.count++;
        }

        if (Day4_2.count == 16)
        {
            Day4_2.count++;
        }
    }
    private void day4_2_2()
    {
        if (Day4_2.count == 7)
        {
            Day4_2.count += 11 - 7;
        }

        if (Day4_2.count == 16)
        {
            Day4_2.count += 28 - 16;
        }
    }

    public void CallChoice()
    {
        day4_2();
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
