using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[System.Serializable]
public class choice
{
    [TextArea]
    public string _choice;
    public string _choice2;
}

public class Choice : MonoBehaviour
{
    [SerializeField] private Button choicebtn1;
    [SerializeField] private Button choicebtn2;
    [SerializeField] private Text txt_choice1;
    [SerializeField] private Text txt_choice2;

    public static int count = 0;
    [SerializeField] private choice[] choice;
    public void ShowChoice()
    {
        ChoiceOn();
        txt_choice1.text = choice[count]._choice;
        txt_choice2.text = choice[count]._choice2;
    }
    public void NextChoice1()
    {
        count++;
        if (Dialogue.count == 9)
        {
            Dialogue.count ++;
        }
        if (CSDialogue.count == 6)
        {
            CSDialogue.count ++;
        }
        if (CSDialogue.count == 30)
        {
            CSDialogue.count++;
        }
        if (CSDialogue.count == 45)
        {
            CSDialogue.count++;
        }
        if (CSDialogue.count == 60)
        {
            CSDialogue.count++;
        }
        if (CSDialogue.count == 66)
        {
            CSDialogue.count++;
        }

        ChoiceOff();
    }
    public void NextChoice2()
    {
        count++;
        if (Dialogue.count == 9)
        {
            Dialogue.count += 4;
        }
        if (CSDialogue.count == 6)
        {
            CSDialogue.count += 6;
        }
        if (CSDialogue.count == 30)
        {
            CSDialogue.count += 3;
        }
        if (CSDialogue.count == 45)
        {
            CSDialogue.count += 2;
        }
        if (CSDialogue.count == 60)
        {
            CSDialogue.count += 2;
        }
        if (CSDialogue.count == 66)
        {
            CSDialogue.count += 4;
        }
        ChoiceOff();

    }
    public void ChoiceOn()
    {
        Dialogue.isDialogue = false;
        CSDialogue.isDialogue = false;
        choicebtn1.gameObject.SetActive(true);
        choicebtn2.gameObject.SetActive(true);
        txt_choice1.gameObject.SetActive(true);
        txt_choice2.gameObject.SetActive(true);
    }
    public void ChoiceOff()
    {
        Dialogue.isDialogue = true;
        CSDialogue.isDialogue = true;
        choicebtn1.gameObject.SetActive(false);
        choicebtn2.gameObject.SetActive(false);
        txt_choice1.gameObject.SetActive(false);
        txt_choice2.gameObject.SetActive(false);
    }
    public void CallChoice()
    {
        if (Dialogue.count == 9)
        {
            ShowChoice();
        }
        if (CSDialogue.count == 6)
        {
            ShowChoice();
        }
        if (CSDialogue.count == 30)
        {
            ShowChoice();
        }
        if (CSDialogue.count == 45)
        {
            ShowChoice();
        }
        if (CSDialogue.count == 60)
        {
            ShowChoice();
        }
        if (CSDialogue.count == 66)
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