using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[System.Serializable]
public class day1_JinSangChoice
{
    [TextArea]
    public string _choice;
    public string _choice2;
    public string _choice3;
    public string _choice4;
}

public class JS2_1choice : MonoBehaviour
{
    [SerializeField] private Button choicebtn1;
    [SerializeField] private Button choicebtn2;
    [SerializeField] private Button choicebtn3;
    [SerializeField] private Button choicebtn4;
    [SerializeField] private Text txt_choice1;
    [SerializeField] private Text txt_choice2;
    [SerializeField] private Text txt_choice3;
    [SerializeField] private Text txt_choice4;


    public static int count = 0;
    [SerializeField] private day1_JinSangChoice[] choice;
    public void ShowChoice()
    {
        ChoiceOn();
        txt_choice1.text = choice[count]._choice;
        txt_choice2.text = choice[count]._choice2;
    }

    public void ShowChoiceFour()
    {
        ChoiceOnFour();
        txt_choice1.text = choice[count]._choice;
        txt_choice2.text = choice[count]._choice2;
        txt_choice3.text = choice[count]._choice3;
        txt_choice4.text = choice[count]._choice4;
    }
    public void NextChoice1()
    {
        count++;
        if (JinSang2_1.count == 10)
        {
            JinSang2_1.count ++;
        }
        if (JinSang2_1.count == 22)
        {
            JinSang2_1.count ++;
        }
        if (JinSang2_1.count == 49)
        {
            JinSang2_1.count ++;
        }

        ChoiceOff();
        ChoiceOffFour();
    }

    public void NextChoice2()
    {
        count++;
        if (JinSang2_1.count == 10)
        {
            JinSang2_1.count += 5;
        }
        if (JinSang2_1.count == 22)
        {
            JinSang2_1.count += 7;
        }
        if (JinSang2_1.count == 49)
        {
            JinSang2_1.count += 4;
        }

        ChoiceOff();
        ChoiceOffFour();
    }

    public void NextChoice3()
    {
        count++;
        if (JinSang2_1.count == 22)
        {
            JinSang2_1.count += 11;
        }
        ChoiceOff();
        ChoiceOffFour();
    }

    public void NextChoice4()
    {
        count++;
        if (JinSang2_1.count == 22)
        {
            JinSang2_1.count += 17;
        }
        ChoiceOff();
        ChoiceOffFour();
    }

    public void ChoiceOn()
    {
        JinSang2_1.isDialogue = false;
        choicebtn1.gameObject.SetActive(true);
        choicebtn2.gameObject.SetActive(true);
        txt_choice1.gameObject.SetActive(true);
        txt_choice2.gameObject.SetActive(true);
    }

    public void ChoiceOnFour()
    {
        JinSang2_1.isDialogue = false;
        choicebtn1.gameObject.SetActive(true);
        choicebtn2.gameObject.SetActive(true);
        choicebtn3.gameObject.SetActive(true);
        choicebtn4.gameObject.SetActive(true);

        txt_choice1.gameObject.SetActive(true);
        txt_choice2.gameObject.SetActive(true);
        txt_choice3.gameObject.SetActive(true);
        txt_choice4.gameObject.SetActive(true);
    }

    public void ChoiceOff()
    {
        JinSang2_1.isDialogue = true;
        choicebtn1.gameObject.SetActive(false);
        choicebtn2.gameObject.SetActive(false);
        txt_choice1.gameObject.SetActive(false);
        txt_choice2.gameObject.SetActive(false);
    }

    public void ChoiceOffFour()
    {
        JinSang2_1.isDialogue = true;
        choicebtn1.gameObject.SetActive(false);
        choicebtn2.gameObject.SetActive(false);
        choicebtn3.gameObject.SetActive(false);
        choicebtn4.gameObject.SetActive(false);

        txt_choice1.gameObject.SetActive(false);
        txt_choice2.gameObject.SetActive(false);
        txt_choice3.gameObject.SetActive(false);
        txt_choice4.gameObject.SetActive(false);
    }

    public void CallChoice()
    {

        if (JinSang2_1.count == 10)
        {
            ShowChoice();
        }
        if (JinSang2_1.count == 22)
        {
            ShowChoiceFour();
        }
        if (JinSang2_1.count == 49)
        {
            ShowChoice();
        }
    }

    private void Start()
    {
        ChoiceOff();
        ChoiceOffFour();
    }
    private void Update()
    {
        CallChoice();
    }
}
