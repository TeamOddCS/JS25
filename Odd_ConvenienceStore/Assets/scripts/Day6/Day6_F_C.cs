using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

[System.Serializable]
public class day6_Fchoice
{
    [TextArea]
    public string _choice;
    public string _choice2;
}
public class Day6_F_C : MonoBehaviour
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
        day6_F_1();
        ChoiceOff();
    }
    public void NextChoice2()
    {
        count++;
        day6_F_2();
        ChoiceOff();

    }
    public void ChoiceOn()
    {
        Day6_F.isDialogue = false;
        choicebtn1.gameObject.SetActive(true);
        choicebtn2.gameObject.SetActive(true);
        txt_choice1.gameObject.SetActive(true);
        txt_choice2.gameObject.SetActive(true);
    }
    public void ChoiceOff()
    {
        Day6_F.isDialogue = true;
        choicebtn1.gameObject.SetActive(false);
        choicebtn2.gameObject.SetActive(false);
        txt_choice1.gameObject.SetActive(false);
        txt_choice2.gameObject.SetActive(false);
    }
    private void day6_F()
    {
        if (Day6_F.count == 10)
        {
            ShowChoice();
        }
        if (Day6_F.count == 15)
        {
            ShowChoice();
        }
        if (Day6_F.count == 35)
        {
            count = 2;
            ShowChoice();
        }


    }
    private void day6_F_1()
    {

        if (Day6_F.count == 10)
        {
            Day6_F.count++;
        }
        if (Day6_F.count == 15)
        {
            Day6_F.count++;
        }
        if (Day6_F.count == 35)
        {
            Day6_F.count++;
        }
    }
    private void day6_F_2()
    {
        if (Day6_F.count == 10)
        {

            Day6_F.count += 29 - 10;
        }
        if (Day6_F.count == 15)
        {

            Day6_F.count += 21 - 15;
        }
        if (Day6_F.count == 35)
        {

            Day6_F.count += 43 - 35;
        }



    }

    public void CallChoice()
    {
        day6_F();
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
