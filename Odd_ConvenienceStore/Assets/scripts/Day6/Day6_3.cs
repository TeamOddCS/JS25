using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Day6_3 : MonoBehaviour
{
    [SerializeField] private Text txt_name;// �̸� ��� ��ü 
    [SerializeField] private Text txt_dialogue; //��ȭ���� ��� ��ü
    public static bool isDialogue = false;
    public static int count = 0;
    private List<Dictionary<string, object>> data;
    public FadeInOut fade;
    public AudioClip touchclip;
    public AudioClip bell;
    public GameObject GameController;
    public GameObject HealthControlScript;
    public AudioClip minus;
    public AudioClip plus;
    public static int facenum = 0;
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
    private void FaceChange()
    {
        if (data[count]["Face"].ToString().Equals("a5_1_1"))
        {
            facenum = 1;
        }
        if (data[count]["Face"].ToString().Equals("a5_1_5"))
        {
            facenum = 2;
        }
        if (data[count]["Face"].ToString().Equals("a3_1_1"))
        {
            facenum = 3;
        }
        if (data[count]["Face"].ToString().Equals("a3_1_2"))
        {
            facenum = 4;
        }
        if (data[count]["Face"].ToString().Equals("a3_1_3"))
        {
            facenum = 5;
        }
        if (data[count]["Face"].ToString().Equals("a3_1_4"))
        {
            facenum = 6;
        }
        if (data[count]["Face"].ToString().Equals("a4_1_1"))
        {
            facenum = 7;
        }
        if (data[count]["Face"].ToString().Equals("a4_1_2"))
        {
            facenum = 8;
        }
        if (data[count]["Face"].ToString().Equals("a4_1_3"))
        {
            facenum = 9;
        }
        if (data[count]["Face"].ToString().Equals("a7_1_1"))
        {
            facenum = 10;
        }
        if (data[count]["Face"].ToString().Equals("a7_1_2"))
        {
            facenum = 11;
        }
        if (data[count]["Face"].ToString().Equals("a7_1_3"))
        {
            facenum = 12;
        }
        if (data[count]["Face"].ToString().Equals("a7_1_4"))
        {
            facenum = 13;
        }
        if (data[count]["Face"].ToString().Equals("a7_1_5"))
        {
            facenum = 14;
        }

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
        if (count > 0)
        {
            SoundManager.instance.SFXPlay("Touch", touchclip);
        }
        if (count == 0)
        {
            SoundManager.instance.SFXPlay("Ring", bell);
            fade.Fade();
        }
        if (count == 25)
        {
            SoundManager.instance.SFXPlay("Ring", bell);
            fade.Fade();
        }
        if (count == 168)
        {
            SoundManager.instance.SFXPlay("Ring", bell);
            fade.Fade();
        }
        count++;
        FaceChange();
    }

    public void TextColorChange()
    {
        data[count]["Script"] = data[count]["Script"].ToString().Replace("ⓑ", "<color=#2782cc>");//�Ķ��� "�߿��Ѻκ�"
        data[count]["Script"] = data[count]["Script"].ToString().Replace("ⓡ", "<color=#a83a22>");//������ (������ -)
        data[count]["Script"] = data[count]["Script"].ToString().Replace("ⓖ", "<color=#13c216>");//�ʷϻ� (������ +) 
        data[count]["Script"] = data[count]["Script"].ToString().Replace("ⓔ", "</color>");// �ٲ� ������ �������� ���� ��ȣ
        data[count]["Script"] = data[count]["Script"].ToString().Replace("ⓐ", "<color=#a8a3a2>");//���ΰ� ���� 
    }

    private void Hidedialogue()//��ȭ�� �������� ��ȭ���� ����� �Լ�
    {
        txt_name.gameObject.SetActive(false);
        txt_dialogue.gameObject.SetActive(false);
        isDialogue = false;
    }
    private void day6_3_HC()

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
        if (count == 207)
        {
            SoundManager.instance.SFXPlay("Minus", minus);

            HealthControlScript.GetComponent<HealthControlScript>().health_decrease();
        }

    }
    private void day6_3_JD()//ù��° �������� ����� ��� ������ ��ȭ�� �ٺ��� ���� ��ȭ�� �Ѿ�� �Լ�
    {
        if (count < data.Count)
        {
            Nextdialogue();

            if (count == 12)
            {
                count += 23 - 12;
            }
            if (count == 18)
            {
                count += 23 - 18;
            }
            if (count == 21)
            {
                count += 23 - 21;
            }
            if (count == 40)
            {
                count += 46 - 40;
            }
            if (count == 49)
            {
                count += 54 - 49;
            }


            if (count == 81)
            {
                count += 86 - 81;
            }

            if (count == 91)
            {
                count += 96 - 91;
            }
            if (count == 107)
            {
                count += 123 - 107;
            }
            if (count == 133)
            {
                count += 145- 133;
            }
            if (count == 156)
            {
                count += 165 - 156;
            }
            if (count == 186)
            {
                count += 191 - 186;
            }
        }
        else
        {
            fade.Fade();
            Hidedialogue();
            count = 1;
            GameController.GetComponent<JSChoice>().D6_JSChoice();
        }
    }
    public void Awake()
    {
        SaveData.DoLoadData = true;
        SaveData.TempScene = "Day6-3";
        count = SaveData.TempCount;
        SaveData.Saves();
    }
    private void Start()
    {
        data = CSVReader.Read("Day6-3");
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
                    day6_3_JD();
                    day6_3_HC();
                    SaveData.TempCount = count - 1;
                    SaveData.Saves();
                }
                if (count == 196)
                {
                    Hidedialogue();

                }
            }
        }
        else
            Hidedialogue();
    }
}
