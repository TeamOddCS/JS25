using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[System.Serializable]
public class day1_3_c
{
    [TextArea]
    public string _choice;
    public string _choice2;
}
public class Day1_3_C : MonoBehaviour
{
    [SerializeField] private Button choicebtn1;
    [SerializeField] private Button choicebtn2;
    [SerializeField] private Text txt_choice1;
    [SerializeField] private Text txt_choice2;

    public static int count = 0;
    [SerializeField] private day1_3_c[] choice;
    public void ShowChoice()
    {
        ChoiceOn();
        txt_choice1.text = choice[count]._choice;
        txt_choice2.text = choice[count]._choice2;

        SaveData.Loads();
        SaveData.reGame = Day1_3.count;
        SaveData.reGameStart = "Day1-3";
        SaveData.reGameChoice = count;
        SaveData.Saves();
    }
    public void NextChoice1()
    {
        count++;
        day1_3_1();
        ChoiceOff();
    }
    public void NextChoice2()
    {
        count++;
        day1_3_2();
        ChoiceOff();

    }
    public void ChoiceOn()
    {
        Day1_3.isDialogue = false;
        choicebtn1.gameObject.SetActive(true);
        choicebtn2.gameObject.SetActive(true);
        txt_choice1.gameObject.SetActive(true);
        txt_choice2.gameObject.SetActive(true);
    }
    public void ChoiceOff()
    {
        Day1_3.isDialogue = true;
        choicebtn1.gameObject.SetActive(false);
        choicebtn2.gameObject.SetActive(false);
        txt_choice1.gameObject.SetActive(false);
        txt_choice2.gameObject.SetActive(false);
    }
    private void day1_3()
    {
        if (Day1_3.count == 7)//�Ϲ�4 ù��° AB������
        {
            ShowChoice();
        }
        if (Day1_3.count == 32)//�Ϲ�7 ù��° AB������
        {
            ShowChoice();
        }
        if (Day1_3.count == 48)//�Ϲ�7 �ι�° AB������
        {
            ShowChoice();
        }
        if (Day1_3.count == 64)//�Ϲ�7 ����° AB������
        {
            ShowChoice();
        }
        if (Day1_3.count == 71)//�Ϲ�7 ����° AB������
        {
            ShowChoice();
        }

    }
    private void day1_3_1()
    {
        if (Day1_3.count == 7)//�Ϲ�4 AB������
        {
            Day1_3.count++;
        }
        if (Day1_3.count == 32)//�Ϲ�7 ù��° A������
        {
            Day1_3.count++;
        }
        if (Day1_3.count == 48)//�Ϲ�7 �ι�° A������
        {
            Day1_3.count++;
        }
        if (Day1_3.count == 64)//�Ϲ�7 ����° A������
        {
            Day1_3.count++;
        }
        if (Day1_3.count == 71)//�Ϲ�7 ����° A������
        {
            Day1_3.count++;
        }


    }
    private void day1_3_2()
    {
        if (Day1_3.count == 7)//�Ϲ�4 AB������
        {
            Day1_3.count += 7;
        }
        if (Day1_3.count == 32)//�Ϲ�7 ù��° B������
        {
            Day1_3.count += 4;
        }
        if (Day1_3.count == 48)//�Ϲ�7 �ι�° B������
        {
            Day1_3.count += 3;
        }
        if (Day1_3.count == 64)//�Ϲ�7 ����° B������
        {
            Day1_3.count += 3;
        }
        if (Day1_3.count == 71)//�Ϲ�7 ����° B������
        {
            Day1_3.count += 5;
        }

    }




    public void CallChoice()
    {
        day1_3();

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
