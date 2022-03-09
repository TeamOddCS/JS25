using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[System.Serializable]
public class day3_JinSangChoice
{
    [TextArea]
    public string _choice;
    public string _choice2;
}
public class JS2_3_C : MonoBehaviour
{
    [SerializeField] private Button choicebtn1;
    [SerializeField] private Button choicebtn2;
    [SerializeField] private Text txt_choice1;
    [SerializeField] private Text txt_choice2;


    public static int count = 0;
    [SerializeField] private day3_JinSangChoice[] choice;
    public void ShowChoice()
    {
        ChoiceOn();
        txt_choice1.text = choice[count]._choice;
        txt_choice2.text = choice[count]._choice2;
    }

    public void NextChoice1()
    {
        count++;
        if (JinSang2_3.count == 7)
        {
            JinSang2_3.count++;
        }

        if(JinSang2_3.count == 14)
        {
            JinSang2_3.count++;
        }

        if (JinSang2_3.count == 33)
        {
            JinSang2_3.count++;
        }
        ChoiceOff();
    }

    public void NextChoice2()
    {
        count++;
        if (JinSang2_3.count == 7)
        {
            count++;
            JinSang2_3.count += 21;
        }

        if (JinSang2_3.count == 14)
        {
            JinSang2_3.count += 9;
        }

        if (JinSang2_3.count == 33)
        {
            JinSang2_3.count += 7;
        }
        ChoiceOff();
    }

    public void ChoiceOn()
    {
        JinSang2_3.isDialogue = false;
        choicebtn1.gameObject.SetActive(true);
        choicebtn2.gameObject.SetActive(true);
        txt_choice1.gameObject.SetActive(true);
        txt_choice2.gameObject.SetActive(true);
    }

    public void ChoiceOff()
    {
        JinSang2_3.isDialogue = true;
        choicebtn1.gameObject.SetActive(false);
        choicebtn2.gameObject.SetActive(false);
        txt_choice1.gameObject.SetActive(false);
        txt_choice2.gameObject.SetActive(false);
    }

    public void CallChoice()
    {
        if (JinSang2_3.count == 7)
        {
            ShowChoice();
        }

        if (JinSang2_3.count == 14)
        {
            ShowChoice();
        }

        if (JinSang2_3.count == 33)
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
