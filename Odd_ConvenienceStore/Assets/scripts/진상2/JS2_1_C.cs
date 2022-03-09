using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[System.Serializable]
public class day1_JinSangChoice
{
    [TextArea]
    public string _choice;
    public string _choice2;
}

public class JS2_1_C : MonoBehaviour
{
    [SerializeField] private Button choicebtn1;
    [SerializeField] private Button choicebtn2;
    [SerializeField] private Text txt_choice1;
    [SerializeField] private Text txt_choice2;

    public static int count = 0;
    [SerializeField] private day1_JinSangChoice[] choice;
    public void ShowChoice()
    {
        ChoiceOn();
        txt_choice1.text = choice[count]._choice;
        txt_choice2.text = choice[count]._choice2;
    }

    public void NextChoice1()
    {
        count++;
        if (JinSang2_1.count == 10)
        {//�����ٵд�.
            JinSang2_1.count ++;
        }
        if (JinSang2_1.count == 18)
        {//��������
            count++;
            JinSang2_1.count ++;
        }
        if (JinSang2_1.count == 39)
        {//�˼��մϴ�. ������..
            JinSang2_1.count ++;
        }
        if (JinSang2_1.count == 56)
        {//�˼��մϴ�.
            JinSang2_1.count++;
        }
        ChoiceOff();
    }

    public void NextChoice2()
    {
        count++;
        if (JinSang2_1.count == 10)
        {
            //�����Ѵ�.
            count ++;
            JinSang2_1.count += 22;
        }
        if (JinSang2_1.count == 18)
        {
            //�����Դϴ�.
            count++;
            JinSang2_1.count += 7;
        }
        if (JinSang2_1.count == 39)
        {
            //�Ϻη� �׷����ݾƿ�
            JinSang2_1.count += 7;
        }
        if (JinSang2_1.count == 56)
        {
            //������� �ϼ���.
            JinSang2_1.count += 4;
        }
        ChoiceOff();      
    }

    public void ChoiceOn()
    {
        JinSang2_1.isDialogue = false;
        choicebtn1.gameObject.SetActive(true);
        choicebtn2.gameObject.SetActive(true);
        txt_choice1.gameObject.SetActive(true);
        txt_choice2.gameObject.SetActive(true);
    }

    public void ChoiceOff()
    {
        JinSang2_1.isDialogue = true;
        choicebtn1.gameObject.SetActive(false);
        choicebtn2.gameObject.SetActive(false);
        txt_choice1.gameObject.SetActive(false);
        txt_choice2.gameObject.SetActive(false);
    }

    public void CallChoice()
    {
        if (JinSang2_1.count == 10)
        {
            ShowChoice();
        }
        if (JinSang2_1.count == 18)
        {
            ShowChoice();
        }
        if (JinSang2_1.count == 39)
        {
            ShowChoice();
        }
        if (JinSang2_1.count == 56)
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
