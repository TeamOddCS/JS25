using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[System.Serializable]
public class day2_JinSangChoice
{
    [TextArea]
    public string _choice;
    public string _choice2;
}
public class Day2_JinSangChoice : MonoBehaviour
    {
    [SerializeField] private Button choicebtn1;
    [SerializeField] private Button choicebtn2;
    [SerializeField] private Text txt_choice1;
    [SerializeField] private Text txt_choice2;


    public static int count = 0;
    [SerializeField] private day1_JinSangChoice[] choice;
    public void ShowChoice()
    {
        ChoiceOn();
        txt_choice1.text = choice[count]._choice;
        txt_choice2.text = choice[count]._choice2;
    }

    public void NextChoice1()
    {
        count++;
        if (Day2_JinSangDialog.count == 19)
        {
            Day2_JinSangDialog.count++;
        }

        ChoiceOff();
    }

    public void NextChoice2()
    {
        count++;
        if (Day2_JinSangDialog.count == 19)
        {
            Day2_JinSangDialog.count += 7;
        }
        ChoiceOff();
    }

    public void ChoiceOn()
    {
        Day2_JinSangDialog.isDialogue = false;
        choicebtn1.gameObject.SetActive(true);
        choicebtn2.gameObject.SetActive(true);
        txt_choice1.gameObject.SetActive(true);
        txt_choice2.gameObject.SetActive(true);
    }

    public void ChoiceOff()
    {
        Day2_JinSangDialog.isDialogue = true;
        choicebtn1.gameObject.SetActive(false);
        choicebtn2.gameObject.SetActive(false);
        txt_choice1.gameObject.SetActive(false);
        txt_choice2.gameObject.SetActive(false);
    }

    public void CallChoice()
    {

        if (Day2_JinSangDialog.count == 19)
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
