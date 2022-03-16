using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Day3_3 : MonoBehaviour
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
        data = CSVReader.Read("Day3-3");
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
                    {//����.. �׷�����?
                        count += 3;
                    }
                    if (count == 29)
                    {//�ȳ��� �輼��
                        count += 9;
                    }
                    if (count == 55)
                    {//������ ��� �ϸ� ���� ���Ұ�
                        count += 7;
                    }
                    if (count == 71)
                    {//�� ���׸� �� �ϳ� �ֱ� ��Ƴ�?
                        count += 6;
                    }
                    if (count == 96)
                    {//�۱⵵ �ȴ�.. 
                        count += 23;
                    }
                    if (count == 107)
                    {//���ȳ��� ������.
                        count += 11;
                    }
                    if (count == 134)
                    {//����, �� �� ��������.
                        count += 7;
                    }
                    if (count == 149)
                    {//�̰��� �ͼ��� ���ݴٴ�.
                        count += 6;
                    }
                    if (count == 160)
                    {//���ʸ� ���߱���
                        count += 5;
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
