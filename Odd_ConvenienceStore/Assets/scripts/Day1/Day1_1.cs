using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;

public class Day1_1 : MonoBehaviour
{
    [SerializeField] private Text txt_name;// �̸� ��� ��ü 
    [SerializeField] private Text txt_dialogue; //��ȭ���� ��� ��ü
    public static bool isDialogue = false;
    public static int count = 0;
    private List<Dictionary<string, object>> data;
    public FadeInOut fade;
    public AudioClip touchclip;
    public AudioClip bell;
    public AudioClip ring;
    public int health = 0;
    public static int facenum = 0;

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
        txt_dialogue.text = data[count]["Script"].ToString();
        FaceChange();
        if (count > 0)
        {
            SoundManager.instance.SFXPlay("Touch", touchclip);
        }
        if(count == 23)
            {
            SoundManager.instance.SFXPlay("bell", bell);
        }
        if (count == 66)
        {
            SoundManager.instance.SFXPlay("ring", ring);
        }
        if (count == 80)
        {
            SoundManager.instance.SFXPlay("bell", bell);
        }
        count++;
    }


    private void Hidedialogue()//��ȭ�� �������� ��ȭ���� ����� �Լ�
    {
        txt_name.gameObject.SetActive(false);
        txt_dialogue.gameObject.SetActive(false);
        isDialogue = false;
    }
    private void day1_1_JD()//ù��° �������� ����� ��� ������ ��ȭ�� �ٺ��� ���� ��ȭ�� �Ѿ�� �Լ�
    {
        if (count < data.Count)
        {
            Nextdialogue();
            
            if (count == 45)
            {
                count += 64 - 45;
            }

            if (count == 48)
            {
                count += 64 - 48;
            }
            if (count == 58)
            {
                count += 64 - 58;
            }
            if (count == 62)
            {
                count += 64 - 62;
            }

            if(count == 76)
            {
                Debug.Log("showhealth");
                GameController.GetComponent<HealthControlScript>().Show_Health();
            }
            if (count == 101)
            {
                count += 105 - 101;
            }
            if (count == 105)
            {
                count += 105 - 105;
            }
            if (count == 111)
            {
                count += 115 - 111;
            }
            if (count == 102)
            {
                //health -= 1;            
            }

            if (count == 125)
            {
                fade.Fade();
                Hidedialogue();
            }
        }
        else
        {
            fade.Fade();
            Hidedialogue();
            count = 1;
            GameController.GetComponent<JSChoice>().D1_JSChoice();
        }
    }

    private void FaceChange()
    {
        if (data[count]["Face"].ToString().Equals("1_1_1"))
        {
            facenum = 1;
        }
        if (data[count]["Face"].ToString().Equals("1_1_2"))
        {
            facenum = 2;
        }
        if (data[count]["Face"].ToString().Equals("1_1_3"))
        {
            facenum = 3;
        }
      
        if (data[count]["Face"].ToString().Equals("1_2_1"))
        {
            facenum = 4;
        }
        if (data[count]["Face"].ToString().Equals("1_2_2"))
        {
            facenum = 5;
        }
        if (data[count]["Face"].ToString().Equals("1_2_3"))
        {
            facenum = 6;
        }
        if (data[count]["Face"].ToString().Equals("1"))
        {
            facenum = 7;
        }
        if (data[count]["Face"].ToString().Equals("2"))
        {
            facenum = 8;
        }
        if (data[count]["Face"].ToString().Equals("3"))
        {
            facenum = 9;
        }
        if (data[count]["Face"].ToString().Equals("4"))
        {
            facenum = 10;
        }
        if (data[count]["Face"].ToString().Equals("0"))
        {
            facenum = 11;
        }


    }
    public void Awake()
    {
        SaveData.DoLoadData = true;
        SaveData.TempScene = "Day1-1";
        count = SaveData.TempCount;
        SaveData.Saves();
    }

    private void Start()
    {
        data = CSVReader.Read("Day1-1");
        Camera = GameObject.FindWithTag("MainCamera").GetComponent<Camera>();
        Showdialogue();
        GameController.GetComponent<HealthControlScript>().hide_healthbar();
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
                    day1_1_JD();
                    SaveData.TempCount = count - 1;
                    SaveData.Saves();
                }
            }
        }
        else
            Hidedialogue();
    }
}
