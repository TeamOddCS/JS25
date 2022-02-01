using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[System.Serializable]
public class JinSang7choice2
{
    [TextArea]
    public string _choice;
    public string _choice2;
}

public class JinSang7Choice2 : MonoBehaviour
{
    [SerializeField] private Button choicebtn1;
    [SerializeField] private Button choicebtn2;
    [SerializeField] private Text txt_choice1;
    [SerializeField] private Text txt_choice2;

    public static int count = 0;
    [SerializeField] private JinSang7choice2[] choice;
    public void ShowChoice()
    {
        ChoiceOn();
        txt_choice1.text = choice[count]._choice;
        txt_choice2.text = choice[count]._choice2;
    }
    public void NextChoice1()
    {
        count++;
        if (JinSang7Day2.count == 12)
        {
            JinSang7Day2.count++;
        }
        if (JinSang7Day2.count == 37)
        {
            JinSang7Day2.count++;
        }
        ChoiceOff();
    }
    public void NextChoice2()
    {
        count++;
        if (JinSang7Day2.count == 12)
        {
            JinSang7Day2.count += 25 - 12;
        }
        if (JinSang7Day2.count == 37)
        {
            JinSang7Day2.count += 40 - 37;
        }
        ChoiceOff();
    }
    public void ChoiceOn()
    {
        JinSang7Day2.isDialogue = false;
        choicebtn1.gameObject.SetActive(true);
        choicebtn2.gameObject.SetActive(true);
        txt_choice1.gameObject.SetActive(true);
        txt_choice2.gameObject.SetActive(true);
    }
    public void ChoiceOff()
    {
        JinSang7Day2.isDialogue = true;
        choicebtn1.gameObject.SetActive(false);
        choicebtn2.gameObject.SetActive(false);
        txt_choice1.gameObject.SetActive(false);
        txt_choice2.gameObject.SetActive(false);
    }
    public void CallChoice()
    {
        if (JinSang7Day2.count == 12)
        {
            ShowChoice();
        }

        if (JinSang7Day2.count == 37)
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