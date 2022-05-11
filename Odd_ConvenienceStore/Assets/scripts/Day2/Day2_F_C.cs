using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

[System.Serializable]
public class day2_Fchoice
{
    [TextArea]
    public string _choice;
    public string _choice2;
}
public class Day2_F_C : MonoBehaviour
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
        SaveData.reGame = Day2_F.count;
        SaveData.reGameStart = "Day2-F";
        SaveData.reGameChoice = count;
        SaveData.Saves();
    }
    public void NextChoice1()
    {
        count++;
        day2_F_1();
        ChoiceOff();
    }
    public void NextChoice2()
    {
        count++;
        day2_F_2();
        ChoiceOff();

    }
    public void ChoiceOn()
    {
        Day2_F.isDialogue = false;
        choicebtn1.gameObject.SetActive(true);
        choicebtn2.gameObject.SetActive(true);
        txt_choice1.gameObject.SetActive(true);
        txt_choice2.gameObject.SetActive(true);
    }
    public void ChoiceOff()
    {
        Day2_F.isDialogue = true;
        choicebtn1.gameObject.SetActive(false);
        choicebtn2.gameObject.SetActive(false);
        txt_choice1.gameObject.SetActive(false);
        txt_choice2.gameObject.SetActive(false);
    }
    private void day2_F()
    {
        if (Day2_F.count == 7)
        {
            ShowChoice();
        }


       
    }
    private void day2_F_1()
    {
        if (Day2_F.count == 7)
        {
            Day2_F.count++;
        }

        
    }
    private void day2_F_2()
    {
        if (Day2_F.count == 7)
        {
            Day2_F.count += 4;
        }

    }

    public void CallChoice()
    {
        day2_F();
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
