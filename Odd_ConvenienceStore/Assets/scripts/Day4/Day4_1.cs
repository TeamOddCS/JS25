using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Day4_1 : MonoBehaviour 
{ 
    [SerializeField] private Text txt_name;// �̸� ��� ��ü 
    [SerializeField] private Text txt_dialogue; //��ȭ���� ��� ��ü
    public static bool isDialogue = false;
    public static int count = 0;
    private List<Dictionary<string, object>> data;
    public FadeInOut fade;
    public AudioClip touchclip;
    public AudioClip bell;
    public GameObject HealthControlScript;
    public AudioClip minus;
  

    public static int facenum = 0;

    public GameObject GameController;
    Camera Camera;

    public void Showdialogue()// ó�������Ҷ� �� �ʱ�ȭ�ϰ� ��ȭ������ �����ִ� �Լ�
    {
        txt_dialogue.gameObject.SetActive(true);
        txt_name.gameObject.SetActive(true);
        //count = 0;
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
        FaceChange();
        txt_dialogue.text = data[count]["Script"].ToString();
        if (count > 0)
        {
            SoundManager.instance.SFXPlay("Touch", touchclip);
        }
        if(count == 0 )
        {
            SoundManager.instance.SFXPlay("Bell", bell);
        }
        if(count == 9)
        {
            SoundManager.instance.SFXPlay("Bell", bell);
        }
   
        count++;
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
        if (data[count]["Face"].ToString().Equals("1111"))
        {
            facenum = 7;
        }
        if (data[count]["Face"].ToString().Equals("2222"))
        {
            facenum = 8;
        }
        if (data[count]["Face"].ToString().Equals("3333"))
        {
            facenum = 9;
        }



    }
    public void TextColorChange()
    {
        data[count]["Script"] = data[count]["Script"].ToString().Replace("��", "<color=#2782cc>");//�Ķ��� "�߿��Ѻκ�"
        data[count]["Script"] = data[count]["Script"].ToString().Replace("��", "<color=#a83a22>");//������ (������ -)
        data[count]["Script"] = data[count]["Script"].ToString().Replace("��", "<color=#13c216>");//�ʷϻ� (������ +) 
        data[count]["Script"] = data[count]["Script"].ToString().Replace("��", "</color>");// �ٲ� ������ �������� ���� ��ȣ
        data[count]["Script"] = data[count]["Script"].ToString().Replace("��", "<color=#a8a3a2>");//���ΰ� ���� 
    }
    
    private void Hidedialogue()//��ȭ�� �������� ��ȭ���� ����� �Լ�
    {
        txt_name.gameObject.SetActive(false);
        txt_dialogue.gameObject.SetActive(false);
        isDialogue = false;
    }
    private void day4_1_JD()//ù��° �������� ����� ��� ������ ��ȭ�� �ٺ��� ���� ��ȭ�� �Ѿ�� �Լ�
    {
        if (count < data.Count)
        {
            Nextdialogue();
            
            if (count == 23)
            {
                count += 34 - 23;
            }

            if (count == 27)
            {
                count += 34 - 27;
            }

            if (count == 50)
            {
                count += 64 - 50;
            }

            if (count == 74)
            {
                count += 79 - 74;
            }

            if (count == 91)
            {
                count += 99 - 91;
            }
            if (count == 106)
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
            GameController.GetComponent<JSChoice>().D4_JSChoice();
        }
    }
    private void day4_1_HC()
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

        if (count == 23)
        {
            SoundManager.instance.SFXPlay("Minus", minus);
            SaveData.JSName = " JS1";
            HealthControlScript.GetComponent<HealthControlScript>().health_decrease();
        }
        if (count == 28)
        {
            SoundManager.instance.SFXPlay("Minus", minus);
            SaveData.JSName = " JS1";
            HealthControlScript.GetComponent<HealthControlScript>().health_decrease();
        }
        if (count == 32)
        {
            SoundManager.instance.SFXPlay("Minus", minus);
            SaveData.JSName = " JS1";
            HealthControlScript.GetComponent<HealthControlScript>().health_decrease();
        }
        if (count == 48)
        {
            SoundManager.instance.SFXPlay("Minus", minus);
            SaveData.JSName = " JS1";
            HealthControlScript.GetComponent<HealthControlScript>().health_decrease();
        }

    }
    public void Awake()
    {
        SaveData.DoLoadData = true;
        SaveData.TempScene = "Day4-1";
        count = SaveData.TempCount;
        SaveData.Saves();
    }

    private void Start()
    {
        data = CSVReader.Read("Day4-1");
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
                if (EventSystem.current.IsPointerOverGameObject() == false && mousePos.y < 0) {
                    day4_1_JD();
                    day4_1_HC();
                    SaveData.TempCount = count - 1;
                    SaveData.Saves();
                }
            }
        }
        else
            Hidedialogue();
    }
}
