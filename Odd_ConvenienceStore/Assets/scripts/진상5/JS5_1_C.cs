using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

[System.Serializable]
public class day5_1choice
{
    [TextArea]
    public string _choice;
    public string _choice2;
}
public class JS5_1_C : MonoBehaviour
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
        day5_1_1();
        ChoiceOff();
    }
    public void NextChoice2()
    {
        count++;
        day5_1_2();
        ChoiceOff();

    }
    public void ChoiceOn()
    {
        JinSang5_1.isDialogue = false;
        choicebtn1.gameObject.SetActive(true);
        choicebtn2.gameObject.SetActive(true);
        txt_choice1.gameObject.SetActive(true);
        txt_choice2.gameObject.SetActive(true);
    }
    public void ChoiceOff()
    {
        JinSang5_1.isDialogue = true;
        choicebtn1.gameObject.SetActive(false);
        choicebtn2.gameObject.SetActive(false);
        txt_choice1.gameObject.SetActive(false);
        txt_choice2.gameObject.SetActive(false);
    }
    private void day5_1()
    {
        if (JinSang5_1.count == 15)
        {
            ShowChoice();
        }
        if (JinSang5_1.count == 22)
        {
            ShowChoice();
        }
        if (JinSang5_1.count == 44)
        {
            count = 2;
            ShowChoice();
        }
       
      

    }
    private void day5_1_1()
    {

        if (JinSang5_1.count == 15)
        {
            JinSang5_1.count++;
        }
        if (JinSang5_1.count == 22)
        {
            JinSang5_1.count++;
        }
        if (JinSang5_1.count == 44)
        {
            JinSang5_1.count++;
        }
        

    }
    private void day5_1_2()
    {
        if (JinSang5_1.count == 15)
        {
            JinSang5_1.count += 38 - 15;
        }
        if (JinSang5_1.count == 22)
        {
            JinSang5_1.count += 28 - 22;
        }
        if (JinSang5_1.count == 44)
        {
            JinSang5_1.count += 54 - 44;
        }
       


    }

    public void CallChoice()
    {
        day5_1();
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
