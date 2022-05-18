using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[System.Serializable]
public class JinSang8choice3
{
    [TextArea]
    public string _choice;
    public string _choice2;
}
public class JS8_3_C : MonoBehaviour
{
    [SerializeField] private Button choicebtn1;
    [SerializeField] private Button choicebtn2;
    [SerializeField] private Text txt_choice1;
    [SerializeField] private Text txt_choice2;
    public static bool isChoice = false;
    public static int count = 0;
    [SerializeField] private JinSang8choice3[] choice;
    public void ShowChoice()
    {
        ChoiceOn();
        txt_choice1.text = choice[count]._choice;
        txt_choice2.text = choice[count]._choice2;

        SaveData.Loads();
        SaveData.reGame = JinSang8_3.count;
        SaveData.reGameStart = "JinSang8_3";
        SaveData.reGameChoice = count;
        SaveData.Saves();
    }
    public void NextChoice1()
    {
        count++;
        if (JinSang8_3.count == 24)
        {
            JinSang8_3.count++;
        }

        if (JinSang8_3.count == 37)
        {
            JinSang8_3.count++;
        }

        if (JinSang8_3.count == 44)
        {
            JinSang8_3.count++;
        }
        ChoiceOff();
    }
    public void NextChoice2()
    {
        count++;
        if (JinSang8_3.count == 24)
        {
            JinSang8_3.count += 29 - 24;
        }

        if (JinSang8_3.count == 37)
        {
            JinSang8_3.count += 41 - 37;
        }

        if (JinSang8_3.count == 44)
        {
            JinSang8_3.count += 50 - 44;
        }
        ChoiceOff();
    }
    public void ChoiceOn()
    {
        JinSang8_3.isDialogue = false;
        choicebtn1.gameObject.SetActive(true);
        choicebtn2.gameObject.SetActive(true);
        txt_choice1.gameObject.SetActive(true);
        txt_choice2.gameObject.SetActive(true);
    }
    public void ChoiceOff()
    {
        JinSang8_3.isDialogue = true;
        choicebtn1.gameObject.SetActive(false);
        choicebtn2.gameObject.SetActive(false);
        txt_choice1.gameObject.SetActive(false);
        txt_choice2.gameObject.SetActive(false);
    }
    public void CallChoice()
    {
        if (JinSang8_3.count == 24)
        {
            ShowChoice();
        }
        if (JinSang8_3.count == 37)
        {
            ShowChoice();
        }
        if (JinSang8_3.count == 44)
        {
            ShowChoice();
        }
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
