using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class JinSang6Day2 : MonoBehaviour
{
    [SerializeField] private Text txt_dialogue; //��ȭ���� ��� ��ü
    [SerializeField] private Text txt_name;// �̸� ��� ��ü 
    public static bool isDialogue = false;
    public static int count = 0;
    private List<Dictionary<string, object>> data;
    public static bool choiceF = false;
    public FadeInOut fade;

    public void Showdialogue()// ó�������Ҷ� �� �ʱ�ȭ�ϰ� ��ȭ������ �����ִ� �Լ�
    {
        txt_dialogue.gameObject.SetActive(true);
        txt_name.gameObject.SetActive(true);
        count = 0;
        isDialogue = true;
        //Nextdialogue();
    }
    public void Nextdialogue()//��ȭ���� �ѱ�� �Լ�
    {
        Debug.Log(count);
        txt_dialogue.gameObject.SetActive(true);
        txt_name.gameObject.SetActive(true);
        txt_name.text = data[count]["Name"].ToString();
        data[count]["Script"] = data[count]["Script"].ToString().Replace("#", ",");
        data[count]["Script"] = data[count]["Script"].ToString().Replace("  ", "\n");
        txt_dialogue.text = data[count]["Script"].ToString();
        count++;
    }

    private void Hidedialogue()//��ȭ�� �������� ��ȭ���� ����� �Լ�
    {
        txt_name.gameObject.SetActive(false);
        txt_dialogue.gameObject.SetActive(false);
        isDialogue = false;
    }

    private void Start()
    {
        SaveData.Loads();
        data = CSVReader.Read("JinSang6-2");
        Showdialogue();
    }

    // Update is called once per frame
    void Update()
    {
        if (isDialogue)
        {
            if (Input.GetMouseButtonUp(0))
            {
                if (count < data.Count)
                {
                    Nextdialogue();
                    if (count == 9)
                    {
                        count += 52 - 9;
                    }
                    if (count == 10)
                    {
                        if (SaveData.JinSang6Day1 == 1)
                        {
                            Debug.Log("Data : 1");
                        }
                        else if (SaveData.JinSang6Day1 == 2)
                        {
                            Debug.Log("Data : 2");
                            count += 44 - 10;
                        }
                    }
                    if (count == 33)
                    {
                        count += 52 - 33;
                    }
                    if (count == 40)
                    {
                        count += 52 - 40;
                    }
                    if (count == 42)
                    {
                        choiceF = true;
                    }
                    if (count == 44 && choiceF)
                    {
                        count += 52 - 44;
                    }
                }
                else
                {
                    fade.Fade();
                    Hidedialogue();
                }
            }
        }
        else
            Hidedialogue();
    }
}
