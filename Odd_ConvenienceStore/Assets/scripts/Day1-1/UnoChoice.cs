using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[System.Serializable]
public class UNoChoice
{
    [TextArea]
    public string _choice;
    public string _choice2;
}

public class UnoChoice : MonoBehaviour
{

    [SerializeField] private Button choicebtn1;
    [SerializeField] private Button choicebtn2;
    [SerializeField] private Text txt_choice1;
    [SerializeField] private Text txt_choice2;


    public static int count = 0;
    [SerializeField] private UNoChoice[] choice;
    public void ShowChoice()
    {
        ChoiceOn();
        txt_choice1.text = choice[count]._choice;
        txt_choice2.text = choice[count]._choice2;
    }
    public void NextChoice1()
    {
        count++;
        if (UnoDialogue.count == 23)
        {
            UnoDialogue.count++;
        }
        if (UnoDialogue.count == 28)
        {
            UnoDialogue.count++;
        }
        if (UnoDialogue.count == 65)
        {
            UnoDialogue.count++;
        }
        if (UnoDialogue.count == 74)
        {
            UnoDialogue.count++;
        }
        if (UnoDialogue.count == 79)
        {
            UnoDialogue.count++;
        }
        ChoiceOff();
    }
    public void NextChoice2()
    {
        count++;
        if (UnoDialogue.count == 23)
        {
            UnoDialogue.count += 4;
        }
        if (UnoDialogue.count == 28)
        {
            UnoDialogue.count++;
        }
        if (UnoDialogue.count == 65)
        {
            UnoDialogue.count += 4;
        }
        if (UnoDialogue.count == 74)
        {
            UnoDialogue.count += 2;
        }
        if (UnoDialogue.count == 79)
        {
            UnoDialogue.count += 2;
        }
        ChoiceOff();

    }
    public void ChoiceOn()
    {

        UnoDialogue.isDialogue = false;
        choicebtn1.gameObject.SetActive(true);
        choicebtn2.gameObject.SetActive(true);
        txt_choice1.gameObject.SetActive(true);
        txt_choice2.gameObject.SetActive(true);
    }
    public void ChoiceOff()
    {

        UnoDialogue.isDialogue = true;
        choicebtn1.gameObject.SetActive(false);
        choicebtn2.gameObject.SetActive(false);
        txt_choice1.gameObject.SetActive(false);
        txt_choice2.gameObject.SetActive(false);
    }
    public void CallChoice()
    {

        if (UnoDialogue.count == 23)
        {
            ShowChoice();
        }
        if (UnoDialogue.count == 28)
        {
            ShowChoice();
        }
        if (UnoDialogue.count == 65)
        {
            ShowChoice();
        }
        if (UnoDialogue.count == 74)
        {
            ShowChoice();
        }
        if (UnoDialogue.count == 79)
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