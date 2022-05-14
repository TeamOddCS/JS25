using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

[System.Serializable]
public class day4choice
{
    [TextArea]
    public string _choice;
    public string _choice2;
}
public class Day4_C : MonoBehaviour
{
    [SerializeField] private Button choicebtn1;
    [SerializeField] private Button choicebtn2;
    [SerializeField] private Text txt_choice1;
    [SerializeField] private Text txt_choice2;
    public static bool isChoice = false;
    public static int count = 0;
    private int chk;
    [SerializeField] private js4choice[] choice;
    public void ShowChoice()
    {   
        ChoiceOn();
        txt_choice1.text = choice[count]._choice;
        txt_choice2.text = choice[count]._choice2;

        if(chk == 0)
        {
            SaveData.Loads();
            SaveData.reGame = Day4_3.count;
            SaveData.reGameStart = "Day4-3";
            SaveData.reGameChoice = count;
            SaveData.Saves();
        }
        
        else if(chk == 1)
        {
            SaveData.Loads();
            SaveData.reGame = Day4_F.count;
            SaveData.reGameStart = "Day4-F";
            SaveData.reGameChoice = count;
            SaveData.Saves();
        }
    }
    public void NextChoice1()
    {
        count++;
        day4_3_1();
        day4_f_1();
        ChoiceOff();
    }
    public void NextChoice2()
    {
        count++;
        day4_3_2();
        day4_f_2();
        ChoiceOff();

    }
    public void ChoiceOn()
    {
        Day4_3.isDialogue = false;
        Day4_F.isDialogue = false;
        choicebtn1.gameObject.SetActive(true);
        choicebtn2.gameObject.SetActive(true);
        txt_choice1.gameObject.SetActive(true);
        txt_choice2.gameObject.SetActive(true);
    }
    public void ChoiceOff()
    {
        Day4_3.isDialogue = true;
        Day4_F.isDialogue = true;
        choicebtn1.gameObject.SetActive(false);
        choicebtn2.gameObject.SetActive(false);
        txt_choice1.gameObject.SetActive(false);
        txt_choice2.gameObject.SetActive(false);
    }
    private void day4_3()
    {
        if (Day4_3.count == 5)//일반3 첫번째 AB선택지
        {
            chk = 0;
            ShowChoice();
        }
        if (Day4_3.count == 19)//일반3 두번째 AB선택지
        {
            chk = 0;
            ShowChoice();
        }
        if (Day4_3.count == 51)//일반5 첫번째 AB선택지
        {
            chk = 0;
            ShowChoice();
        }
        if (Day4_3.count == 81)//진상2 첫번째 AB선택지
        {
            chk = 0;
            ShowChoice();
        }
        if (Day4_3.count == 91)//진상2 두번째 AB선택지
        {
            chk = 0;
            ShowChoice();
        }
        if (Day4_3.count == 107)//진상2 세번째 AB선택지
        {
            chk = 0;
            ShowChoice();
        }
        if (Day4_3.count == 152)//진상8 첫번째 AB선택지
        {
            chk = 0;
            ShowChoice();
        }
       
        if (Day4_3.count == 167)//진상8 두번째 AB선택지
        {
            chk = 0;
            ShowChoice();
        }
        if (Day4_3.count == 174)//진상8 첫번째 CD선택지
        {
            chk = 0;
            ShowChoice();
        }
        if (Day4_3.count == 203)//진상8 첫번째 EF선택지
        {
            chk = 0;
            ShowChoice();
        }
    }
    private void day4_3_1()
    {
        if (Day4_3.count == 5)//일반3 AB선택지
        {
            Day4_3.count++;
        }
        if (Day4_3.count == 19)//일반3 두번째 A선택지
        {
            Day4_3.count++;
        }
        if (Day4_3.count == 51)//일반5 첫번째 A선택지
        {
            Day4_3.count++;
        }
        if (Day4_3.count == 81)//진상2 첫번째 A선택지
        {
            Day4_3.count++;
        }
        if (Day4_3.count == 91)//진상2 두번째 A선택지
        {
            Day4_3.count++;
        }
        if (Day4_3.count == 107)//진상2 세번째 A선택지
        {
            Day4_3.count++;
        }
        if (Day4_3.count == 152)//진상8 첫번째 A선택지
        {
            Day4_3.count++;
        }
        if (Day4_3.count == 167)//진상8 두번째 A선택지
        {
            Day4_3.count++;
        }
        if (Day4_3.count == 174)//진상8 첫번째 C선택지
        {
            Day4_3.count++;
        }
        if (Day4_3.count == 203)//진상8 첫번째 E선택지
        {
            Day4_3.count++;
        }
        
    }
    private void day4_3_2()
    {
        if (Day4_3.count == 5)//일반3 AB선택지
        {
            Day4_3.count += 6;
        }
        if (Day4_3.count == 19)//일반3 두번째 B선택지
        {
            Day4_3.count += 11;
        }
        if (Day4_3.count == 51)//일반5 첫번째 B선택지
        {
            Day4_3.count += 16;
        }
        if (Day4_3.count == 81)//진상2 첫번째 B선택지
        {
            Day4_3.count += 5;
        }
        if (Day4_3.count == 91)//진상2 두번째 B선택지
        {
            Day4_3.count+=6;
        }
        if (Day4_3.count == 107)//진상2 세번째 B선택지
        {
            Day4_3.count+=19;
        }
        if (Day4_3.count == 152)//진상8 첫번째 B선택지
        {
            Day4_3.count+=6;
        }
        if (Day4_3.count == 167)//진상8 두번째 B선택지
        {
            Day4_3.count+=28;
            count++;
        }
        if (Day4_3.count == 174)//진상8 첫번째 D선택지
        {
            Day4_3.count+=13;
        }
        if (Day4_3.count == 203)//진상8 첫번째 F선택지
        {
            Day4_3.count+=10;
        }
    }

    private void day4_f()
    {
        if (Day4_F.count == 6)
        {
            chk = 1;
            ShowChoice();
        }
        if (Day4_F.count ==12)
        {
            chk = 1;
            ShowChoice();
        }
        
    }
    private void day4_f_1()
    {
        if(Day4_F.count == 6)
        {
            Day4_F.count++;
        }
        if (Day4_F.count == 12)
        {
            Day4_F.count++;
        }
    }
    private void day4_f_2()
    {
        if (Day4_F.count == 6)
        {
            Day4_F.count+=21;
        }
        if (Day4_F.count == 12)
        {
            Day4_F.count+=6;
        }
    }
    public void CallChoice()
    {
        day4_3();
        day4_f();
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
