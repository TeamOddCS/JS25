using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[System.Serializable]
public class day3_3_c
{
    [TextArea]
    public string _choice;
    public string _choice2;
}
public class Day3_3_C : MonoBehaviour
{
    [SerializeField] private Button choicebtn1;
    [SerializeField] private Button choicebtn2;
    [SerializeField] private Text txt_choice1;
    [SerializeField] private Text txt_choice2;
    public static bool isChoice = false;

    public static int count = 0;
    [SerializeField] private day3_3_c[] choice;
    public void ShowChoice()
    {
        ChoiceOn();
        txt_choice1.text = choice[count]._choice;
        txt_choice2.text = choice[count]._choice2;
    }

    public void NextChoice1()
    {
        count++;
        if (Day3_3.count == 6)
        {
            Day3_3.count++;
        }
        if (Day3_3.count == 14)
        {
            Day3_3.count++;
        }
        if (Day3_3.count == 47)
        {
            Day3_3.count++;
        }
        if (Day3_3.count == 64)
        {
            Day3_3.count++;
        }
        if (Day3_3.count == 78)
        {
            Day3_3.count++;
        }
        if (Day3_3.count == 89)
        {
            Day3_3.count++;
        }
        if (Day3_3.count == 125)
        {
            Day3_3.count++;
        }
        if (Day3_3.count == 142)
        {
            Day3_3.count++;
        }
        if (Day3_3.count == 156)
        {
            Day3_3.count++;
        }
        ChoiceOff();
    }

    public void NextChoice2()
    {
        count++;
        if (Day3_3.count == 6)
        {//ã�ƺ��帱�Կ�
            Day3_3.count += 3;
        }
        if (Day3_3.count == 14)
        {//������ ������.
            Day3_3.count += 15;
        }
        if (Day3_3.count == 47)
        {//�ֱ� �ȴ�. �� ô �������
            Day3_3.count += 8;
        }
        if (Day3_3.count == 64)
        {//�������ô���
            Day3_3.count += 7;
        }
        if (Day3_3.count == 78)
        {//�׳� �ͺ� �帱�Կ�
            count++;
            Day3_3.count += 29;
        }
        if (Day3_3.count == 89)
        {//��, ����������.
            Day3_3.count += 7;
        }
        if (Day3_3.count == 125)
        {//�ƾ߼��� ������?
            Day3_3.count += 9;
        }
        if (Day3_3.count == 142)
        {//�װ� ���� �ô���
            Day3_3.count += 7;
        }
        if (Day3_3.count == 156)
        {//����������, ���׳�..
            Day3_3.count += 4;
        }
        ChoiceOff();
    }

    public void ChoiceOn()
    {
        isChoice = true;
        Day3_3.isDialogue = false;
        choicebtn1.gameObject.SetActive(true);
        choicebtn2.gameObject.SetActive(true);
        txt_choice1.gameObject.SetActive(true);
        txt_choice2.gameObject.SetActive(true);
    }

    public void ChoiceOff()
    {
        isChoice = false;
        Day3_3.isDialogue = true;
        choicebtn1.gameObject.SetActive(false);
        choicebtn2.gameObject.SetActive(false);
        txt_choice1.gameObject.SetActive(false);
        txt_choice2.gameObject.SetActive(false);
    }

    public void CallChoice()
    {
        if (Day3_3.count == 6)
        {
            ShowChoice();
        }
        if (Day3_3.count == 14)
        {
            ShowChoice();
        }
        if (Day3_3.count == 47)
        {
            ShowChoice();
        }
        if (Day3_3.count == 64)
        {
            ShowChoice();
        }
        if (Day3_3.count == 78)
        {
            ShowChoice();
        }
        if (Day3_3.count == 89)
        {
            ShowChoice();
        }
        if (Day3_3.count == 125)
        {
            ShowChoice();
        }
        if (Day3_3.count == 142)
        {
            ShowChoice();
        }
        if (Day3_3.count == 156)
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
