using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Day4_3 : MonoBehaviour 
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
    private void day4_3_JD()//ù��° �������� ����� ��� ������ ��ȭ�� �ٺ��� ���� ��ȭ�� �Ѿ�� �Լ�
    {
        if (count < data.Count)
        {
            Nextdialogue();
            
            if (count == 11)
            {
                count += 6;
            }
            if (count == 30)
            {
                count += 8;
            }
            if (count == 67)
            {
                count += 4;
            }
            if (count == 86)
            {
                count += 4;
            }
            if (count == 97)
            {
                count += 7;
            }
            if (count == 126)
            {
                count += 11;
            }
            if (count == 158)
            {
                count += 6;
            }
            if (count == 187)
            {
                count += 38;
            }
            if (count == 194)
            {
                count += 31;
            }
            if (count == 213)
            {
                count +=12;
            }
            if (count == 227)
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
        data = CSVReader.Read("Day4-3");
        Showdialogue();
    }
    // Update is called once per frame
    void Update()
    {
        if (isDialogue)
        {
            if (Input.GetMouseButtonUp(0))
            {
                day4_3_JD();
                
            }
        }
        else
            Hidedialogue();
    }
}
