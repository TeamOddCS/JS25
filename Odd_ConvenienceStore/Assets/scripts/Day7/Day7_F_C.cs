using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

[System.Serializable]
public class day7_Fchoice
{
    [TextArea]
    public string _choice;
    public string _choice2;
}
public class Day7_F_C : MonoBehaviour
{
    [SerializeField] private Button choicebtn1;
    [SerializeField] private Button choicebtn2;
    [SerializeField] private Text txt_choice1;
    [SerializeField] private Text txt_choice2;

    public static int count = 0;
    [SerializeField] private js4choice[] choice;
    public void ShowChoice()
    {
        ChoiceOn();
        txt_choice1.text = choice[count]._choice;
        txt_choice2.text = choice[count]._choice2;
    }
    public void NextChoice1()
    {
        count++;
        day7_F_1();
        ChoiceOff();
    }
    public void NextChoice2()
    {
        count++;
        day7_F_2();
        ChoiceOff();

    }
    public void ChoiceOn()
    {
        Day7_F.isDialogue = false;
        choicebtn1.gameObject.SetActive(true);
        choicebtn2.gameObject.SetActive(true);
        txt_choice1.gameObject.SetActive(true);
        txt_choice2.gameObject.SetActive(true);
    }
    public void ChoiceOff()
    {
        Day7_F.isDialogue = true;
        choicebtn1.gameObject.SetActive(false);
        choicebtn2.gameObject.SetActive(false);
        txt_choice1.gameObject.SetActive(false);
        txt_choice2.gameObject.SetActive(false);
    }
    private void day7_F()
    {
        if (Day7_F.count == 13)
        {
            ShowChoice();
        }
    }
    private void day7_F_1()
    {
        if (Day7_F.count == 13)
        {
            Day7_F.count++;
        }
    }
    private void day7_F_2()
    {
        if (Day7_F.count == 13)
        {

            Day7_F.count += 23 - 13;
        }
    }

    public void CallChoice()
    {
        day7_F();
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
