using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Day5_1 : MonoBehaviour
{
    [SerializeField] private Text txt_dialogue; //��ȭ���� ��� ��ü
    [SerializeField] private Text txt_name;// �̸� ��� ��ü 
    public static bool isDialogue = false;
    public static int count = 0;
    private List<Dictionary<string, object>> data;
    public FadeInOut fade;
    public AudioClip touchclip;
    public AudioClip ring;
    public static int facenum = 0;
    public GameObject HealthControlScript;
    public AudioClip minus;

    public GameObject GameController;
    Camera Camera;

    public void Showdialogue()// ó�������Ҷ� �� �ʱ�ȭ�ϰ� ��ȭ������ �����ִ� �Լ�
    {
        txt_dialogue.gameObject.SetActive(true);
        txt_name.gameObject.SetActive(true);
        //count = 0;
        isDialogue = true;
        if(count==0)
            Nextdialogue();
    }
    public void TextColorChange()
    {
        data[count]["Script"] = data[count]["Script"].ToString().Replace("��", "<color=#2782cc>");//�Ķ��� "�߿��Ѻκ�"
        data[count]["Script"] = data[count]["Script"].ToString().Replace("��", "<color=#a83a22>");//������ (������ -)
        data[count]["Script"] = data[count]["Script"].ToString().Replace("��", "<color=#13c216>");//�ʷϻ� (������ +) 
        data[count]["Script"] = data[count]["Script"].ToString().Replace("��", "</color>");// �ٲ� ������ �������� ���� ��ȣ
        data[count]["Script"] = data[count]["Script"].ToString().Replace("��", "<color=#a8a3a2>");//���ΰ� ���� 
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
        FaceChange();
        txt_dialogue.text = data[count]["Script"].ToString();
        if (count > 0)
        {
            SoundManager.instance.SFXPlay("Touch", touchclip);
        }
        if (count == 0)
        {
            SoundManager.instance.SFXPlay("Ring", ring);
        }
        if (count == 10)
        {
            SoundManager.instance.SFXPlay("Ring", ring);
        }
        if (count == 92)
        {
            SoundManager.instance.SFXPlay("Ring", ring);
        }

        count++;
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
        if (data[count]["Face"].ToString().Equals("1111"))
        {
            facenum = 5;
        }
        if (data[count]["Face"].ToString().Equals("2222"))
        {
            facenum = 6;
        }
        if (data[count]["Face"].ToString().Equals("3333"))
        {
            facenum = 7;
        }
        if (data[count]["Face"].ToString().Equals("5_1_1"))
        {
            facenum = 8;
        }
        if (data[count]["Face"].ToString().Equals("5_1_2"))
        {
            facenum = 9;
        }
        if (data[count]["Face"].ToString().Equals("5_2_1"))
        {
            facenum = 10;
        }
        if (data[count]["Face"].ToString().Equals("5_2_2"))
        {
            facenum = 11;
        }
        if (data[count]["Face"].ToString().Equals("5_3_1"))
        {
            facenum = 12;
        }
        if (data[count]["Face"].ToString().Equals("5_3_2"))
        {
            facenum = 13;
        }
        if (data[count]["Face"].ToString().Equals("5_4_1"))
        {
            facenum = 14;
        }
        if (data[count]["Face"].ToString().Equals("5_4_2"))
        {
            facenum = 15;
        }

    }
    private void day5_1_HC()
    {
        if (count == 5)
        {
            SoundManager.instance.SFXPlay("Plus", minus);
            SaveData.JSName = " JS9";
            HealthControlScript.GetComponent<HealthControlScript>().health_increase();
        }
        if (count == 6)
        {
            SoundManager.instance.SFXPlay("Plus", minus);
            SaveData.JSName = " JS9";
            HealthControlScript.GetComponent<HealthControlScript>().health_increase();
        }
        if (count == 7)
        {
            SoundManager.instance.SFXPlay("Plus", minus);
            SaveData.JSName = " JS9";
            HealthControlScript.GetComponent<HealthControlScript>().health_increase();
        }
        if (count == 172)
        {
            SoundManager.instance.SFXPlay("Minus", minus);
            SaveData.JSName = " JS5";
            HealthControlScript.GetComponent<HealthControlScript>().health_decrease();
        }
        

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
        SaveData.TempScene = "Day5-1";
        count = SaveData.TempCount;
        SaveData.Saves();
    }
    private void Start()
    {
        data = CSVReader.Read("Day5-1");
        Camera = GameObject.FindWithTag("MainCamera").GetComponent<Camera>();
        HealthControlScript.GetComponent<HealthControlScript>().Show_Health();
        Showdialogue();
    }
    // Update is called once per frame
    void Update()
    {
        if (isDialogue)
        {
            if (Input.GetMouseButtonUp(0))
            {
                Vector2 mousePos = Input.mousePosition;
                mousePos = Camera.ScreenToWorldPoint(mousePos);
                if (EventSystem.current.IsPointerOverGameObject() == false && mousePos.y < 0)
                {
                    if (count < data.Count)
                    {
                        Nextdialogue();
                        if (count == 32)
                        {// �׷��� �� ����ּ��� ������
                            count += 8;
                        }
                        if (count == 52)
                        {//������ ���� ������. ������
                            count += 40;
                        }
                        if (count == 58)
                        {// �׷��Ա��� ����.. ������
                            count += 34;
                        }
                        if (count == 69)
                            count += 6;
                        if (count == 85)
                            count += 7;
                        if (count == 125)
                            count += 5;
                        if (count == 135)
                            count += 34;
                        if (count == 157)
                            count += 15;
                    }
                    else
                    {
                        fade.Fade();
                        Hidedialogue();
                        count = 1;
                        GameController.GetComponent<JSChoice>().D5_JSChoice();
                    }

                    day5_1_HC();
                    SaveData.TempCount = count - 1;
                    SaveData.Saves();
                }
            }
        }
        else
            Hidedialogue();
    }
}
