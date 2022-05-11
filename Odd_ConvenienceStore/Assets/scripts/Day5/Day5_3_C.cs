using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[System.Serializable]
public class day5choice
{
    [TextArea]
    public string _choice;
    public string _choice2;
}

public class Day5_3_C : MonoBehaviour
{
    [SerializeField] private Button choicebtn1;
    [SerializeField] private Button choicebtn2;
    [SerializeField] private Text txt_choice1;
    [SerializeField] private Text txt_choice2;

    public static int count = 0;
    [SerializeField] private day5choice[] choice;
    public void ShowChoice()
    {
        ChoiceOn();
        txt_choice1.text = choice[count]._choice;
        txt_choice2.text = choice[count]._choice2;

        SaveData.Loads();
        SaveData.reGame = Day5_3.count;
        SaveData.reGameStart = "Day5-3";
        SaveData.reGameChoice = count;
        SaveData.Saves();
    }
    public void NextChoice1()
    {
        count++;
        day5_3_1();
        ChoiceOff();
    }
    public void NextChoice2()
    {
        count++;
        day5_3_2();     
        ChoiceOff();

    }
    public void ChoiceOn()
    {
        Day5_3.isDialogue = false;
        Day5_F.isDialogue = false;
        choicebtn1.gameObject.SetActive(true);
        choicebtn2.gameObject.SetActive(true);
        txt_choice1.gameObject.SetActive(true);
        txt_choice2.gameObject.SetActive(true);
    }
    public void ChoiceOff()
    {
        Day5_3.isDialogue = true;
        Day5_F.isDialogue = true;
        choicebtn1.gameObject.SetActive(false);
        choicebtn2.gameObject.SetActive(false);
        txt_choice1.gameObject.SetActive(false);
        txt_choice2.gameObject.SetActive(false);
    }
    private void day5_3()
    {
        if (Day5_3.count == 10)//�Ϲ�4 ù��° AB������
        {
            ShowChoice();
        }
        if (Day5_3.count == 33)//�Ϲ�7 ù��° AB������
        {
            ShowChoice();
        }
        if (Day5_3.count == 57)//�Ϲ�7 �ι�° AB������
        {
            ShowChoice();
        }
        if (Day5_3.count == 81)//�Ϲ�7 ����° AB������
        {
            ShowChoice();
        }
        
    }
    private void day5_3_1()
    {
        if (Day5_3.count == 10)//�Ϲ�4 AB������
        {
            Day5_3.count++;
        }
        if (Day5_3.count == 33)//�Ϲ�7 ù��° A������
        {
            Day5_3.count++;
        }
        if (Day5_3.count == 57)//�Ϲ�7 �ι�° A������
        {
            Day5_3.count++;
        }
        if (Day5_3.count == 81)//�Ϲ�7 ����° A������
        {
            Day5_3.count++;
        }
        

    }
    private void day5_3_2()
    {
        if (Day5_3.count == 10)//�Ϲ�4 AB������
        {
            Day5_3.count += 6;
        }
        if (Day5_3.count == 33)//�Ϲ�7 ù��° B������
        {
            Day5_3.count += 12;
        }
        if (Day5_3.count == 57)//�Ϲ�7 �ι�° B������
        {
            Day5_3.count += 9;
        }
        if (Day5_3.count == 81)//�Ϲ�7 ����° B������
        {
            Day5_3.count += 4;
        }
        
    }

   
    
    
    public void CallChoice()
    {
        day5_3();
      
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
