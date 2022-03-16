using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[System.Serializable]
public class day3_f_c
{
    [TextArea]
    public string _choice;
    public string _choice2;
}
public class Day3_F_C : MonoBehaviour
{
    [SerializeField] private Button choicebtn1;
    [SerializeField] private Button choicebtn2;
    [SerializeField] private Text txt_choice1;
    [SerializeField] private Text txt_choice2;


    public static int count = 0;
    [SerializeField] private day3_f_c[] choice;
    public void ShowChoice()
    {
        ChoiceOn();
        txt_choice1.text = choice[count]._choice;
        txt_choice2.text = choice[count]._choice2;
    }

    public void NextChoice1()
    {
        count++;
        if (Day3_F.count == 6)
        {
            Day3_F.count++;
        }
        ChoiceOff();
    }
    public void NextChoice2()
    {
        count++;
        if (Day3_F.count == 6)
        {//À¢ °ÅÁöX³¢°¡ ¿Í¼­´Â..
            Day3_F.count += 7;
        }
        ChoiceOff();
    }

    public void ChoiceOn()
    {
        Day3_F.isDialogue = false;
        choicebtn1.gameObject.SetActive(true);
        choicebtn2.gameObject.SetActive(true);
        txt_choice1.gameObject.SetActive(true);
        txt_choice2.gameObject.SetActive(true);
    }
    public void ChoiceOff()
    {
        Day3_F.isDialogue = true;
        choicebtn1.gameObject.SetActive(false);
        choicebtn2.gameObject.SetActive(false);
        txt_choice1.gameObject.SetActive(false);
        txt_choice2.gameObject.SetActive(false);
    }

    public void CallChoice()
    {
        if (Day3_F.count == 6)
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
