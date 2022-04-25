using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class JinSang4_4 : MonoBehaviour
{
    [SerializeField] private Text txt_dialogue; //��ȭ���� ��� ��ü
    [SerializeField] private Text txt_name;// �̸� ��� ��ü 
    public static bool isDialogue = false;
    public static int count = 0;
    private List<Dictionary<string, object>> data;
    public FadeInOut fade;
    public static int facenum = 0;
    public GameObject HealthControlScript;
    public AudioClip touchclip;



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
        TextColorChange();
        txt_dialogue.text = data[count]["Script"].ToString();
        FaceChange();
        if (count > 0)
        {
            SoundManager.instance.SFXPlay("Touch", touchclip);
        }
        count++;

    }
    public void TextColorChange()
    {
        data[count]["Script"] = data[count]["Script"].ToString().Replace("��", "<color=#2782cc>");//�Ķ��� "�߿��Ѻκ�"
        data[count]["Script"] = data[count]["Script"].ToString().Replace("��", "<color=#a83a22>");//������ (����� -)
        data[count]["Script"] = data[count]["Script"].ToString().Replace("��", "<color=#13c216>");//�ʷϻ� (����� +) 
        data[count]["Script"] = data[count]["Script"].ToString().Replace("��", "</color>");// �ٲ� ������ �������� ���� ��ȣ
    }


    private void Hidedialogue()//��ȭ�� �������� ��ȭ���� ����� �Լ�
    {
        txt_name.gameObject.SetActive(false);
        txt_dialogue.gameObject.SetActive(false);
        isDialogue = false;
    }
    private void FaceChange()
    {
        if (data[count]["Face"].ToString().Equals("4_1_1"))
        {
            facenum = 1;
        }
        if (data[count]["Face"].ToString().Equals("4_1_2"))
        {
            facenum = 2;
        }
        if (data[count]["Face"].ToString().Equals("4_2_1"))
        {
            facenum = 3;
        }
        if (data[count]["Face"].ToString().Equals("4_2_2"))
        {
            facenum = 4;
        }
        if (data[count]["Face"].ToString().Equals("4_3_1"))
        {
            facenum = 5;
        }
        if (data[count]["Face"].ToString().Equals("4_3_2"))
        {
            facenum = 6;
        }
    }
    private void Start()
    {
        data = CSVReader.Read("����4-4");
        HealthControlScript.GetComponent<HealthControlScript>().Show_Health();
        Showdialogue();
    }
    private void JinSang4_4_HC()
    {
        if(count == 60)
        {
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
                if (count < data.Count)
                {
                    Nextdialogue();
                    if (count == 50)
                    {
                        count += 12;
                    }
                    if (count == 64)
                    {
                        count += 11;
                    }
                    JinSang4_4_HC();



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
