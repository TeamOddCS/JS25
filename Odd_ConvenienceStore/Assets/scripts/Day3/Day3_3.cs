using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;

public class Day3_3 : MonoBehaviour
{
    [SerializeField] private Text txt_dialogue; //��ȭ���� ��� ��ü
    [SerializeField] private Text txt_name;// �̸� ��� ��ü 
    public static bool isDialogue = false;
    public static int count = 0;
    private List<Dictionary<string, object>> data;
    public FadeInOut fade;
    public AudioClip touchclip;
    public AudioClip bell;
    public GameObject HealthControlScript;
    public AudioClip minus;
    public AudioClip plus;
    public static int facenum = 0;
    Camera Camera;
    
    public void TextColorChange()
    {
        data[count]["Script"] = data[count]["Script"].ToString().Replace("��", "<color=#2782cc>");//�Ķ��� "�߿��Ѻκ�"
        data[count]["Script"] = data[count]["Script"].ToString().Replace("��", "<color=#a83a22>");//������ (������ -)
        data[count]["Script"] = data[count]["Script"].ToString().Replace("��", "<color=#13c216>");//�ʷϻ� (������ +) 
        data[count]["Script"] = data[count]["Script"].ToString().Replace("��", "</color>");// �ٲ� ������ �������� ���� ��ȣ
        data[count]["Script"] = data[count]["Script"].ToString().Replace("��", "<color=#a8a3a2>");//���ΰ� ���� 
    }
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
        FaceChange();
        {
            SoundManager.instance.SFXPlay("Touch", touchclip);
        }
        if(count == 0)
        {
            SoundManager.instance.SFXPlay("Bell", bell);
            fade.Fade();

        }
        if(count == 40)
        {
            SoundManager.instance.SFXPlay("Bell", bell);
            fade.Fade();
        }
        if (count == 119)
        {
            SoundManager.instance.SFXPlay("Bell", bell);
            fade.Fade();
        }
       
        count++;
    }
    private void FaceChange()
    {
        if (data[count]["Face"].ToString().Equals("a2_1_1"))
        {
            facenum = 1;
        }
        if (data[count]["Face"].ToString().Equals("a2_1_2"))
        {
            facenum = 2;
        }
        if (data[count]["Face"].ToString().Equals("a2_1_3"))
        {
            facenum = 3;
        }
        if (data[count]["Face"].ToString().Equals("a2_1_4"))
        {
            facenum = 4;
        }
        if (data[count]["Face"].ToString().Equals("5_1_1"))
        {
            facenum = 5;
        }
        if (data[count]["Face"].ToString().Equals("5_1_2"))
        {
            facenum = 6;
        }
        if (data[count]["Face"].ToString().Equals("5_2_1"))
        {
            facenum = 7;
        }
        if (data[count]["Face"].ToString().Equals("5_2_2"))
        {
            facenum = 8;
        }
        if (data[count]["Face"].ToString().Equals("5_3_1"))
        {
            facenum = 9;
        }
        if (data[count]["Face"].ToString().Equals("5_3_2"))
        {
            facenum = 10;
        }
        if (data[count]["Face"].ToString().Equals("5_4_1"))
        {
            facenum = 11;
        }
        if (data[count]["Face"].ToString().Equals("5_4_2"))
        {
            facenum = 12;
        }
        if (data[count]["Face"].ToString().Equals("a7_1_1"))
        {
            facenum = 13;
        }
        if (data[count]["Face"].ToString().Equals("a7_1_2"))
        {
            facenum = 14;
        }
        if (data[count]["Face"].ToString().Equals("a7_1_4"))
        {
            facenum = 15;
        }
        if (data[count]["Face"].ToString().Equals("a7_1_5"))
        {
            facenum = 16;
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
        SaveData.TempScene = "Day3-3";
        count = SaveData.TempCount;
        SaveData.Saves();
    }
    private void Start()
    {
        data = CSVReader.Read("Day3-3");
        Camera = GameObject.FindWithTag("MainCamera").GetComponent<Camera>();
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
            count = 1;
            SceneManager.LoadScene("Day3-F");
        }
    }

    private void day3_3_HC()
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
        if (count == 25)
        {//�Ű���ֽ� �� �ʹ� �����ؼ���
            SoundManager.instance.SFXPlay("Plus", plus);
            HealthControlScript.GetComponent<HealthControlScript>().health_increase();
        }
        if (count == 95)
        {//���� 5(��)�� �ٴڿ� ����ħ�� �����
            SoundManager.instance.SFXPlay("Minus", minus);
            SaveData.JSName = "JS5";
            HealthControlScript.GetComponent<HealthControlScript>().health_decrease();
        }
        if(count == 109)
        {//���� �� ������ ��°ſ���..
            SoundManager.instance.SFXPlay("Minus", minus);
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
                Vector2 mousePos = Input.mousePosition;
                mousePos = Camera.ScreenToWorldPoint(mousePos);
                if (EventSystem.current.IsPointerOverGameObject() == false && mousePos.y < 0)
                {
                    day3_3_JD();
                    day3_3_HC();
                    SaveData.TempCount = count - 1;
                    SaveData.Saves();
                }
            }

        }
        else
            Hidedialogue();
       
    }
}
