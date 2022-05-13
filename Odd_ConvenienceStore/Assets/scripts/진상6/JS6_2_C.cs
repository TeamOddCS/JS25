using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[System.Serializable]
public class JinSang6choice2
{
    [TextArea]
    public string _choice;
    public string _choice2;
}

public class JS6_2_C : MonoBehaviour
{
    [SerializeField] private Button choicebtn1;
    [SerializeField] private Button choicebtn2;
    [SerializeField] private Text txt_choice1;
    [SerializeField] private Text txt_choice2;

    public static int count = 0;
    [SerializeField] private JinSang6choice2[] choice;
    public void ShowChoice()
    {
        ChoiceOn();
        txt_choice1.text = choice[count]._choice;
        txt_choice2.text = choice[count]._choice2;

        SaveData.Loads();
        SaveData.reGame = JinSang6_2.count;
        SaveData.reGameStart = "JinSang6_2";
        SaveData.reGameChoice = count;
        SaveData.Saves();
    }
    public void NextChoice1()
    {
        count++;
        if (JinSang6_2.count == 6)
        {
            JinSang6_2.count++;
        }
        if (JinSang6_2.count == 20)
        {
            JinSang6_2.count++;
        }
        if (JinSang6_2.count == 26)
        {
            JinSang6_2.count++;
        }
        ChoiceOff();
    }
    public void NextChoice2()
    {
        count++;
        if (JinSang6_2.count == 6)
        {
            JinSang6_2.count += 11 - 6;
        }
        if (JinSang6_2.count == 20)
        {
            JinSang6_2.count += 44 - 20;
        }
        if (JinSang6_2.count == 26)
        {
            JinSang6_2.count += 37 - 26;
        }
        ChoiceOff();
    }
    public void ChoiceOn()
    {
        JinSang6_2.isDialogue = false;
        choicebtn1.gameObject.SetActive(true);
        choicebtn2.gameObject.SetActive(true);
        txt_choice1.gameObject.SetActive(true);
        txt_choice2.gameObject.SetActive(true);
    }
    public void ChoiceOff()
    {
        JinSang6_2.isDialogue = true;
        choicebtn1.gameObject.SetActive(false);
        choicebtn2.gameObject.SetActive(false);
        txt_choice1.gameObject.SetActive(false);
        txt_choice2.gameObject.SetActive(false);
    }
    public void CallChoice()
    {
        if (JinSang6_2.count == 6 || JinSang6_2.count == 20 || JinSang6_2.count == 26)
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