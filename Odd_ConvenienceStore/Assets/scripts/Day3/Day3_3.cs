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

    public GameObject HealthControlScript;
    public void TextColorChange()
    {
        data[count]["Script"] = data[count]["Script"].ToString().Replace("��", "<color=#2782cc>");//�Ķ��� "�߿��Ѻκ�"
        data[count]["Script"] = data[count]["Script"].ToString().Replace("��", "<color=#a83a22>");//������ (����� -)
        data[count]["Script"] = data[count]["Script"].ToString().Replace("��", "<color=#13c216>");//�ʷϻ� (����� +) 
        data[count]["Script"] = data[count]["Script"].ToString().Replace("��", "</color>");// �ٲ� ������ �������� ���� ��ȣ
    }
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
        TextColorChange();
        txt_dialogue.text = data[count]["Script"].ToString();
        count++;
    }

    private void Hidedialogue()//��ȭ�� �������� ��ȭ���� ����� �Լ�
    {
        txt_name.gameObject.SetActive(false);
        txt_dialogue.gameObject.SetActive(false);
        isDialogue = false;
    }

    public void Awake()
    {
        SaveData.DoLoadData = true;
    }
    private void Start()
    {
        data = CSVReader.Read("Day3-3");
        HealthControlScript.GetComponent<HealthControlScript>().Show_Health();
        Showdialogue();
    }

    private void day3_3_JD()
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

    private void day3_3_HC()
    {
        if (count == 25)
        {//�Ű���ֽ� �� �ʹ� �����ؼ���
            HealthControlScript.GetComponent<HealthControlScript>().health_increase();
        }
        if (count == 95)
        {//���� 5(��)�� �ٴڿ� ����ħ�� ���
            SaveData.JSName = "JS5";
            HealthControlScript.GetComponent<HealthControlScript>().health_decrease();
        }
        if(count == 109)
        {//���� �� ������ ��°ſ���..
            SaveData.JSName = "JS5";
            HealthControlScript.GetComponent<HealthControlScript>().health_decrease();
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (isDialogue)
        {
            if (Input.GetMouseButtonUp(0))
            {
                day3_3_JD();
                day3_3_HC();
            }
        }
        else
            Hidedialogue();
    }
}
