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

    public GameObject HealthControlScript;

    public void Showdialogue()// ó�������Ҷ� �� �ʱ�ȭ�ϰ� ��ȭ������ �����ִ� �Լ�
    {
        txt_dialogue.gameObject.SetActive(true);
        txt_name.gameObject.SetActive(true);
        count = 0;
        isDialogue = true;
        //Nextdialogue();
    }
    public void TextColorChange()
    {
        data[count]["Script"] = data[count]["Script"].ToString().Replace("��", "<color=#2782cc>");//�Ķ��� "�߿��Ѻκ�"
        data[count]["Script"] = data[count]["Script"].ToString().Replace("��", "<color=#a83a22>");//������ (����� -)
        data[count]["Script"] = data[count]["Script"].ToString().Replace("��", "<color=#13c216>");//�ʷϻ� (����� +) 
        data[count]["Script"] = data[count]["Script"].ToString().Replace("��", "</color>");// �ٲ� ������ �������� ���� ��ȣ
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
        data = CSVReader.Read("Day3-1");
        Debug.Log("showhealth");
        HealthControlScript.GetComponent<HealthControlScript>().Show_Health();
        Showdialogue();
    }

    private void day3_1_JD()
    {
        if (count < data.Count)
        {
            Nextdialogue();
            if (count == 29)
            {//������ ���� ���� �� ���Դϴ�.
                count += 3;
            }
            if (count == 44)
            {//3��° ���� �ֽ��ϴ�.
                count += 18;
            }
            if (count == 48)
            {//������ ����� �ٷ� ���ڽ��ϴ�.
                count += 14;
            }
            if (count == 58)
            {//�����̶�� �� �� ������, ���� �� �� �ִ� �� �װ͹ۿ� �����.
                count += 4;
            }
            
            if (count == 71)
            {//�������� ������?
                count += 30;
            }

            if (count == 91)
            {//�����ϴ��� �� �� �� �� ����..
                count += 10;
            }
            if (count == 116)
            {//������ ����Ʈ �ϳ���.
                count += 19;
            }
            if (count == 129)
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

    private void day3_1_HC()
    {
        if (count < data.Count)
        {
            if (count == 65)
            { //�ܻ��ص帱�Կ�.
                HealthControlScript.GetComponent<HealthControlScript>().health_decrease();
            }
            if (count == 70)
            {//����3�� ������ �߰������� ������.
                HealthControlScript.GetComponent<HealthControlScript>().health_decrease();
            }

            if (count == 87)
            {//���� 3�� �Ŵ뿡�� ���� �ѿ�ŭ ���� �ٴڿ� ��Ѹ���.
                HealthControlScript.GetComponent<HealthControlScript>().health_decrease();
            }

            if (count == 134)
            {//�� ������ �ɷ� ����..���� ����
                HealthControlScript.GetComponent<HealthControlScript>().health_decrease();
            }

            if (count == 158)
            {//����. �������� ������ ���������ݾ�
                HealthControlScript.GetComponent<HealthControlScript>().health_decrease();
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (isDialogue)
        {
            if (Input.GetMouseButtonUp(0))
            {
                day3_1_JD();
                day3_1_HC();
            } 
        }
        else
            Hidedialogue();
    }
}
