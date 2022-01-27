using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[System.Serializable]
public class eineChoice
{
    [TextArea]
    public string _choice;
    public string _choice2;
}

public class EineChoice : MonoBehaviour
{

    [SerializeField] private Button choicebtn1;
    [SerializeField] private Button choicebtn2;
    [SerializeField] private Text txt_choice1;
    [SerializeField] private Text txt_choice2;


    public static int count = 0;
    [SerializeField] private eineChoice[] choice;
    public void ShowChoice()
    {
        ChoiceOn();
        txt_choice1.text = choice[count]._choice;
        txt_choice2.text = choice[count]._choice2;
    }
    public void NextChoice1()
    {
        count++;
        if (EineDialogue.count == 23)
        {
            EineDialogue.count++;
        }
        if (EineDialogue.count == 28)
        {
            EineDialogue.count++;
        }
        if (EineDialogue.count == 65)
        {
            EineDialogue.count++;
        }
        
        if (EineDialogue.count == 79)
        {
            EineDialogue.count++;
        }
        ChoiceOff();
    }
    public void NextChoice2()
    {
        count++;
        if (EineDialogue.count == 23)
        {
            EineDialogue.count += 4;
        }
        if (EineDialogue.count == 28)
        {
            EineDialogue.count++;
        }
        if (EineDialogue.count == 65)
        {
            EineDialogue.count += 4;
        }
        if (EineDialogue.count == 74)
        {
            EineDialogue.count += 2;
        }
        if (EineDialogue.count == 79)
        {
            EineDialogue.count += 2;
        }
        ChoiceOff();

    }
    public void ChoiceOn()
    {

        EineDialogue.isDialogue = false;
        choicebtn1.gameObject.SetActive(true);
        choicebtn2.gameObject.SetActive(true);
        txt_choice1.gameObject.SetActive(true);
        txt_choice2.gameObject.SetActive(true);
    }
    public void ChoiceOff()
    {

        EineDialogue.isDialogue = true;
        choicebtn1.gameObject.SetActive(false);
        choicebtn2.gameObject.SetActive(false);
        txt_choice1.gameObject.SetActive(false);
        txt_choice2.gameObject.SetActive(false);
    }
    public void CallChoice()
    {

        if (EineDialogue.count == 23)
        {
            ShowChoice();
        }
        if (EineDialogue.count == 28)
        {
            ShowChoice();
        }
        if (EineDialogue.count == 65)
        {
            ShowChoice();
        }
        if (EineDialogue.count == 74)
        {
            ShowChoice();
        }
        if (EineDialogue.count == 79)
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