using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Day3_1 : MonoBehaviour
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
    public static int facenum = 0;
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
        data[count]["Script"] = data[count]["Script"].ToString().Replace("ⓑ", "<color=#2782cc>");//�Ķ��� "�߿��Ѻκ�"
        data[count]["Script"] = data[count]["Script"].ToString().Replace("ⓡ", "<color=#a83a22>");//������ (������ -)
        data[count]["Script"] = data[count]["Script"].ToString().Replace("ⓖ", "<color=#13c216>");//�ʷϻ� (������ +) 
        data[count]["Script"] = data[count]["Script"].ToString().Replace("ⓔ", "</color>");// �ٲ� ������ �������� ���� ��ȣ
        data[count]["Script"] = data[count]["Script"].ToString().Replace("ⓐ", "<color=#a8a3a2>");//���ΰ� ���� 
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
        if(count == 0)
        {
            SoundManager.instance.SFXPlay("Bell", bell);
            fade.Fade();
        }
        if (count == 14)
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
        if (data[count]["Face"].ToString().Equals("3_1_1"))
        {
            facenum = 1;
        }
        if (data[count]["Face"].ToString().Equals("3_1_2"))
        {
            facenum = 2;
        }
        if (data[count]["Face"].ToString().Equals("3_2_1"))
        {
            facenum = 3;
        }
        if (data[count]["Face"].ToString().Equals("3_2_2"))
        {
            facenum = 4;
        }
        if (data[count]["Face"].ToString().Equals("3_3_1"))
        {
            facenum = 5;
        }
        if (data[count]["Face"].ToString().Equals("3_3_2"))
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
        if (data[count]["Face"].ToString().Equals("7_1_1"))
        {
            facenum = 10;
        }
        if (data[count]["Face"].ToString().Equals("7_1_2"))
        {
            facenum = 11;
        }
        if (data[count]["Face"].ToString().Equals("7_2_1"))
        {
            facenum = 12;
        }
        if (data[count]["Face"].ToString().Equals("7_2_2"))
        {
            facenum = 13;
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
        SaveData.TempScene = "Day3-1";
        count = SaveData.TempCount;
        SaveData.Saves();
    }

    private void Start()
    {
        data = CSVReader.Read("Day3-1");
        Camera = GameObject.FindWithTag("MainCamera").GetComponent<Camera>();
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
            {//������ ������Ʈ �ϳ���.
                count += 19;
            }
            if (count == 129)
            {//������ ������Ʈ �ϳ���.(���帱��� ����)
                count += 6;
            }
        }
        else
        {
            
            Hidedialogue();
            count = 1;
            GameController.GetComponent<JSChoice>().D3_JSChoice();
        }
    }

    private void day3_1_HC()
    {
        if (count < data.Count)
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

            if (count == 65)
            { //�ܻ��ص帱�Կ�.
                SoundManager.instance.SFXPlay("Minus", minus);
                SaveData.JSName = "JS3";
                HealthControlScript.GetComponent<HealthControlScript>().health_decrease();
            }
            if (count == 70)
            {//����3�� ������ �߰������� ������.
                SoundManager.instance.SFXPlay("Minus", minus);
                SaveData.JSName = "JS3";
                HealthControlScript.GetComponent<HealthControlScript>().health_decrease();

            }

            if (count == 87)
            {//���� 3�� �Ŵ뿡�� ���� �ѿ�ŭ ���� �ٴڿ� ��Ѹ���.
                SoundManager.instance.SFXPlay("Minus", minus);
                SaveData.JSName = "JS3";
                HealthControlScript.GetComponent<HealthControlScript>().health_decrease();
            }

            if (count == 134)
            {//�� ������ �ɷ� ����..���� ����
                SoundManager.instance.SFXPlay("Minus", minus);
                SaveData.JSName = "JS7";
                HealthControlScript.GetComponent<HealthControlScript>().health_decrease();
            }

            if (count == 158)
            {//����. �������� ������ ���������ݾ�
                SoundManager.instance.SFXPlay("Minus", minus);
                SaveData.JSName = "JS7";
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
                Vector2 mousePos = Input.mousePosition;
                mousePos = Camera.ScreenToWorldPoint(mousePos);
                if (EventSystem.current.IsPointerOverGameObject() == false && mousePos.y < 0)
                {
                    day3_1_JD();
                    day3_1_HC();
                    SaveData.TempCount = count - 1;
                    SaveData.Saves();
                }
            } 
        }
        else
            Hidedialogue();
    }
}
