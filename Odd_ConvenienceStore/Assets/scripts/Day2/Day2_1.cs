using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Day2_1 : MonoBehaviour
{
    [SerializeField] private Text txt_name;// �̸� ��� ��ü 
    [SerializeField] private Text txt_dialogue; //��ȭ���� ��� ��ü
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
        Nextdialogue();
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
    private void day2_1_JD()//ù��° �������� ����� ��� ������ ��ȭ�� �ٺ��� ���� ��ȭ�� �Ѿ�� �Լ�
    {
        if (count < data.Count)
        {
            Nextdialogue();

            if (count == 14)
            {
                count += 18 - 14;
            }

            if (count == 27)
            {
                count += 30 - 27;
            }
            if (count == 55)
            {
                count +=  66 - 55;
            }
            if (count == 64)
            {
                count += 66 - 64;
            }
            if (count == 91)
            {
                count += 106 - 91;
            }
            if (count == 104)
            {
                count += 106 - 104;
            }
           
            if (count == 108)
            {
                count += 110 - 108;
            }
            if (count == 70)
            {
                count += 110 - 70;
            }
            

            if (count == 125)
            {
                count += 151 - 125;
            }
            if (count == 143)
            {
                count += 151 - 143;
            }
            if (count == 150)
            {
                count += 151 - 150;
            }
            if (count == 165)
            {
                count += 183 - 165;
            }
            if (count == 169)
            {
                count += 183 - 169;
            }
            if (count == 177)
            {
                count += 181 - 177;
            }
            if (count == 182)
            {
                count += 160 - 182;
            }
            if (count == 201)
            {
                count += 205 - 201;
            }
            if (count == 210)
            {
                count += 217 - 210;
            }
            if (count == 217)
            {
                count += 217 - 217;
            }
            if (count == 221)
            {
                fade.Fade();
                Hidedialogue();
            }
        }
        else
        {
            fade.Fade();
            Hidedialogue();
        }
    }
    private void Start()
    {
        data = CSVReader.Read("Day2-1");
        Showdialogue();
    }
    // Update is called once per frame
    void Update()
    {
        if (isDialogue)
        {
            if (Input.GetMouseButtonUp(0))
            {
                day2_1_JD();
            }
        }
        else
            Hidedialogue();
    }
}
