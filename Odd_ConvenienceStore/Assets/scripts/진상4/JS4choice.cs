using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[System.Serializable]
public class js4choice
{
    [TextArea]
    public string _choice;
    public string _choice2;
}
public class JS4choice : MonoBehaviour
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
        js4_1_1();
        js4_2_1();
        js4_3_1();
        js4_4_1();
        ChoiceOff();
    }
    public void NextChoice2()
    {
        count++;
        js4_1_2();
        js4_2_2();
        js4_3_2();
        js4_4_2();
        ChoiceOff();

    }
    private void js4_1_1()//진상4 1일차 첫번째 선택지
    {
        if (JinSang4_1.count == 7)
        {
            JinSang4_1.count++;
            count++;
        }
        if (JinSang4_1.count == 16)
        {
            JinSang4_1.count++;
        }
        if (JinSang4_1.count == 31)
        {
            JinSang4_1.count++;
        }
    }
    private void js4_1_2()//진상4 1일차 두번째 선택지
    {
        if (JinSang4_1.count == 7)
        {
            JinSang4_1.count += 5;
        }
        if (JinSang4_1.count == 16)
        {
            JinSang4_1.count += 4;
        }
        if (JinSang4_1.count == 31)
        {
            JinSang4_1.count += 4;
        }
    }
    private void js4_1()
    {
        if (JinSang4_1.count == 7)
        {
            ShowChoice();
        }
        if (JinSang4_1.count == 16)
        {
            ShowChoice();
        }
        if (JinSang4_1.count == 31)
        {
            ShowChoice();
        }
    }
    private void js4_2()
    {
        if (JinSang4_2.count == 6)
        {
            ShowChoice();
        }
        if (JinSang4_2.count == 21)
        {
            ShowChoice();
        }
        if (JinSang4_2.count == 38)
        {
            ShowChoice();
        }
    }
    private void js4_2_1()
    {
        
        if (JinSang4_2.count == 6)
        {
            JinSang4_2.count++;
        }
        if (JinSang4_2.count == 21)
        {
            JinSang4_2.count++;
        }
        if (JinSang4_2.count == 38)
        {
            JinSang4_2.count++;
        }

    }
    private void js4_2_2()
    {
       
        if (JinSang4_2.count == 6)
        {
            JinSang4_2.count += 7;
            count++;
        }
        if (JinSang4_2.count == 21)
        {
            JinSang4_2.count += 11;
        }
        if (JinSang4_2.count == 38)
        {
            JinSang4_2.count += 10;
        }

    }
    private void js4_3()
    {
        if (JinSang4_3.count == 26)
        {
            ShowChoice();
        }
        if (JinSang4_3.count == 36)
        {
            ShowChoice();
        }
       
    }
    private void js4_3_1()
    {
        
        if (JinSang4_3.count == 26)
        {
            JinSang4_3.count++;
        }
        if (JinSang4_3.count == 36)
        {
            JinSang4_3.count++;
        }
        
    }
    private void js4_3_2()
    {
       
        if (JinSang4_3.count == 26)
        {
            JinSang4_3.count += 4;
            
        }
        if (JinSang4_3.count == 36)
        {
            JinSang4_3.count += 7;
        }
    }
    private void js4_4()
    {
        if (JinSang4_4.count == 15)
        {
            ShowChoice();
        }
        if (JinSang4_4.count == 27)
        {
            ShowChoice();
        }
        if (JinSang4_4.count == 37)
        {
            ShowChoice();
        }

    }
    private void js4_4_1()
    {

        if (JinSang4_4.count == 15)
        {
            JinSang4_4.count+=3;
        }
        if (JinSang4_4.count == 27)
        {
            JinSang4_4.count++;
        }
        if (JinSang4_4.count == 37)
        {
            JinSang4_4.count++;
        }

    }
    private void js4_4_2()
    {

        if (JinSang4_4.count == 15)
        {
            JinSang4_4.count++;
        }
        if (JinSang4_4.count == 27)
        {
            JinSang4_4.count+=28;
        }
        if (JinSang4_4.count == 37)
        {
            JinSang4_4.count+=5;
        }
    }
    public void ChoiceOn()
    {
        JinSang4_1.isDialogue= false;
        JinSang4_2.isDialogue = false;
        JinSang4_3.isDialogue = false;
        JinSang4_4.isDialogue = false;
        choicebtn1.gameObject.SetActive(true);
        choicebtn2.gameObject.SetActive(true);
        txt_choice1.gameObject.SetActive(true);
        txt_choice2.gameObject.SetActive(true);
    }
    public void ChoiceOff()
    {
        JinSang4_1.isDialogue = true;
        JinSang4_2.isDialogue = true;
        JinSang4_3.isDialogue = true;
        JinSang4_4.isDialogue = true;
        choicebtn1.gameObject.SetActive(false);
        choicebtn2.gameObject.SetActive(false);
        txt_choice1.gameObject.SetActive(false);
        txt_choice2.gameObject.SetActive(false);
    }
    public void CallChoice()
    {
        js4_1();
        js4_2();
        js4_3();
        js4_4();

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
