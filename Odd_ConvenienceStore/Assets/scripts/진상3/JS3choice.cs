using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[System.Serializable]
public class js3choice
{
    [TextArea]
    public string _choice;  
    public string _choice2;
}

public class JS3choice : MonoBehaviour
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
        js3_1_1();
        js3_2_1();
        js3_3_1();
        ChoiceOff();
    }
    public void NextChoice2()
    {
        count++;
        js3_1_2();
        js3_2_2();
        js3_3_2();
        ChoiceOff();

    }
    public void ChoiceOn()
    {
        JinSang3_1.isDialogue = false;
        JinSang3_2.isDialogue = false;
        JinSang3_3.isDialogue = false;
        
        choicebtn1.gameObject.SetActive(true);
        choicebtn2.gameObject.SetActive(true);
        txt_choice1.gameObject.SetActive(true);
        txt_choice2.gameObject.SetActive(true);
    }
    public void ChoiceOff()
    {
        JinSang3_1.isDialogue = true;
        JinSang3_2.isDialogue = true;
        JinSang3_3.isDialogue = true;
        
        choicebtn1.gameObject.SetActive(false);
        choicebtn2.gameObject.SetActive(false);
        txt_choice1.gameObject.SetActive(false);
        txt_choice2.gameObject.SetActive(false);
    }
    public void CallChoice()
    {
        js3_1();
        js3_2();
        js3_3();
    }
    private void js3_1()
    {
        if (JinSang3_1.count == 10)//AB������
        {
            ShowChoice();
        }
        if (JinSang3_1.count == 16)//CD������
        {
            ShowChoice();
        }
        if (JinSang3_1.count == 34)//EF������
        {
            ShowChoice();
        }
    }
    private void js3_1_1()
    {
        if (JinSang3_1.count == 10)//AB������
        {
            JinSang3_1.count++;
        }
        if (JinSang3_1.count == 16)//CD������
        {
            JinSang3_1.count++;
        }
        if (JinSang3_1.count == 34)//EF������
        {
            JinSang3_1.count++;
        }
    }
    private void js3_1_2()
    {
        if (JinSang3_1.count == 10)//AB������
        {
            JinSang3_1.count+=18;
            count++;
        }
        if (JinSang3_1.count == 16)//CD������
        {
            JinSang3_1.count+=6;
        }
        if (JinSang3_1.count == 34)//EF������
        {
            JinSang3_1.count+=8;
        }
    }

    private void js3_2()
    {
        if (JinSang3_2.count == 10)//AB������
        {
            ShowChoice();
        }
        if (JinSang3_2.count == 16)//CD������
        {
            ShowChoice();
        }
    }
    private void js3_2_1()
    {
        if (JinSang3_2.count == 10)//AB������
        {
            JinSang3_2.count++;
        }
        if (JinSang3_2.count == 16)//CD������
        {
            JinSang3_2.count++;
        }
    }
    private void js3_2_2()
    {
        if (JinSang3_2.count == 10)//AB������
        {
            JinSang3_2.count += 18;
        }
        if (JinSang3_2.count == 16)//CD������
        {
            JinSang3_2.count += 6;
        }
    }

    private void js3_3()
    {
        if (JinSang3_3.count == 9)//AB������
        {
            ShowChoice();
        }
        if (JinSang3_3.count == 19)//CD������
        {
            ShowChoice();
        }
    }
    private void js3_3_1()
    {
        if (JinSang3_3.count == 9)//AB������
        {
            JinSang3_3.count++;
        }
        if (JinSang3_3.count == 19)//CD������
        {
            JinSang3_3.count++;
        }
    }
    private void js3_3_2()
    {
        if (JinSang3_3.count == 9)//AB������
        {
            JinSang3_3.count+=6;
        }
        if (JinSang3_3.count == 19)//CD������
        {
            JinSang3_3.count+=5;
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
