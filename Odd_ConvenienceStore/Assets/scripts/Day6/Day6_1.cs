using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Day6_1 : MonoBehaviour 
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
    public static int facenum2 = 0;
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
        if(count == 0)
        {
            SoundManager.instance.SFXPlay("Ring", bell);
        }
        count++;
        FaceChange();
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
    private void day6_1_HC()
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
        if (count == 19)
        {
            SoundManager.instance.SFXPlay("Plus", plus);
            HealthControlScript.GetComponent<HealthControlScript>().health_increase();
        }

        if (count == 27)
        {
            SoundManager.instance.SFXPlay("Plus", plus);

            HealthControlScript.GetComponent<HealthControlScript>().health_increase();
        }
        if (count == 89)
        {
            SoundManager.instance.SFXPlay("Minus", minus);
            SaveData.JSName = " JS7";
            HealthControlScript.GetComponent<HealthControlScript>().health_decrease();
        }
        if (count == 101)
        {
            SoundManager.instance.SFXPlay("Minus", minus);
            SaveData.JSName = " JS7";
            HealthControlScript.GetComponent<HealthControlScript>().health_decrease();
        }
       

    }
    private void day6_1_JD()//ù��° �������� ����� ��� ������ ��ȭ�� �ٺ��� ���� ��ȭ�� �Ѿ�� �Լ�
    {
        if (count < data.Count)
        {
            Nextdialogue();
            
            if (count == 19)
            {
                count += 28 - 19;
            }

            if (count == 79)
            {
                count += 89 - 79;
            }

            if (count == 103)
            {
                count += 112 - 103;
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
    private void FaceChange()
    {
        if (data[count]["Face"].ToString().Equals("111"))
        {
            facenum = 1;
        }
        if (data[count]["Face"].ToString().Equals("222"))
        {
            facenum = 2;
        }
        if (data[count]["Face"].ToString().Equals("333"))
        {
            facenum = 3;
        }
        if (data[count]["Face"].ToString().Equals("7_1"))
        {
            facenum = 4;
        }
        if (data[count]["Face"].ToString().Equals("7_2"))
        {
            facenum = 5;
        }
        if (data[count]["Face"].ToString().Equals("0"))
        {
            facenum = 6;
        }
        if (data[count]["Face2"].ToString().Equals("9_1_1"))// �մ� �׷��� �߰� �׽�Ʈ �ڵ�
        {
            facenum2 = 1;
        }
        if (data[count]["Face2"].ToString().Equals("9_1_2"))// �մ� �׷��� �߰� �׽�Ʈ �ڵ�
        {
            facenum2 = 2;
        }
        if (data[count]["Face2"].ToString().Equals("9_1_3"))// �մ� �׷��� �߰� �׽�Ʈ �ڵ�
        {
            facenum2 = 3;
        }
        if (data[count]["Face2"].ToString().Equals("9_1_4"))// �մ� �׷��� �߰� �׽�Ʈ �ڵ�
        {
            facenum2 = 4;
        }
       


    }
    public void Awake()
    {
        SaveData.DoLoadData = true;
        SaveData.TempScene = "Day6-1";
        count = SaveData.TempCount;
        SaveData.Saves();
    }
    private void Start()
    {
        data = CSVReader.Read("Day6-1");
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
                    day6_1_JD();
                    day6_1_HC();
                    SaveData.TempCount = count - 1;
                    SaveData.Saves();
                }
            }
        }
        else
            Hidedialogue();
    }
}
