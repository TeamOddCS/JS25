using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[System.Serializable]
public class zweiChoice
{
    [TextArea]
    public string _choice;
    public string _choice2;
}

public class ZweiChoice : MonoBehaviour
{
   

    [SerializeField] private Button choicebtn1;
    [SerializeField] private Button choicebtn2;
    [SerializeField] private Text txt_choice1;
    [SerializeField] private Text txt_choice2;


    public static int count = 0;
    [SerializeField] private zweiChoice[] choice;
    public void ShowChoice()
    {
        ChoiceOn();
        txt_choice1.text = choice[count]._choice;
        txt_choice2.text = choice[count]._choice2;
    }
    public void NextChoice1()
    {
        count++;
        if (ZweiDialogue.count == 23)
        {
            ZweiDialogue.count++;
        }
        if (ZweiDialogue.count == 28)
        {
            ZweiDialogue.count++;
        }
        if (ZweiDialogue.count == 65)
        {
            ZweiDialogue.count++;
        }
        if (ZweiDialogue.count == 74)
        {
            ZweiDialogue.count++;
        }
        if (ZweiDialogue.count == 79)
        {
            ZweiDialogue.count++;
        }
        ChoiceOff();
    }
    public void NextChoice2()
    {
        count++;
        if (ZweiDialogue.count == 23)
        {
            ZweiDialogue.count += 4;
        }
        if (ZweiDialogue.count == 28)
        {
            ZweiDialogue.count++;
        }
        if (ZweiDialogue.count == 65)
        {
            ZweiDialogue.count += 4;
        }
        if (ZweiDialogue.count == 74)
        {
            ZweiDialogue.count += 2;
        }
        if (ZweiDialogue.count == 79)
        {
            ZweiDialogue.count += 2;
        }
        ChoiceOff();

    }
    public void ChoiceOn()
    {

        ZweiDialogue.isDialogue = false;
        choicebtn1.gameObject.SetActive(true);
        choicebtn2.gameObject.SetActive(true);
        txt_choice1.gameObject.SetActive(true);
        txt_choice2.gameObject.SetActive(true);
    }
    public void ChoiceOff()
    {

        ZweiDialogue.isDialogue = true;
        choicebtn1.gameObject.SetActive(false);
        choicebtn2.gameObject.SetActive(false);
        txt_choice1.gameObject.SetActive(false);
        txt_choice2.gameObject.SetActive(false);
    }
    public void CallChoice()
    {

        if (ZweiDialogue.count == 23)
        {
            ShowChoice();
        }
        if (ZweiDialogue.count == 28)
        {
            ShowChoice();
        }
        if (ZweiDialogue.count == 65)
        {
            ShowChoice();
        }
        if (ZweiDialogue.count == 74)
        {
            ShowChoice();
        }
        if (ZweiDialogue.count == 79)
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