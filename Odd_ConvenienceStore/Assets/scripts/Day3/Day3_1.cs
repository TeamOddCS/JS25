using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Day3_1 : MonoBehaviour
{
    [SerializeField] private Text txt_dialogue; //��ȭ���� ��� ��ü
    [SerializeField] private Text txt_name;// �̸� ��� ��ü 
    public static bool isDialogue = false;
    public static int count = 0;
    private List<Dictionary<string, object>> data;
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
        data = CSVReader.Read("Day3-1");
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
                    if (count == 27)
                    {//������ ���� ���� �� ���Դϴ�.
                        count += 3;
                    }
                    if(count == 42)
                    {//3��° ���� �ֽ��ϴ�.
                        count += 18;
                    }
                    if (count == 46)
                    {//������ ����� �ٷ� ���ڽ��ϴ�.
                        count += 14;
                    }
                    if (count == 56)
                    {//�����̶�� �� �� ������, ���� �� �� �ִ� �� �װ͹ۿ� �����.
                        count += 4;
                    }
                    if (count == 69)
                    {//�������� ������?
                        count += 30;
                    }
                    if (count == 89)
                    {//�����ϴ��� �� �� �� �� ����..
                        count += 10;
                    }
                    if (count == 114)
                    {//������ ����Ʈ �ϳ���.
                        count += 19;
                    }
                    if (count == 127)
                    {//������ ����Ʈ �ϳ���.(���帱��� ����)
                        count += 6;
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
