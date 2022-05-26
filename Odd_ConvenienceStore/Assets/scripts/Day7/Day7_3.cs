using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;

public class Day7_3 : MonoBehaviour
{
    [SerializeField] private Text txt_name;// �̸� ��� ��ü 
    [SerializeField] private Text txt_dialogue; //��ȭ���� ��� ��ü
    public static bool isDialogue = false;
    public static int count = 0;
    private List<Dictionary<string, object>> data;
    public FadeInOut fade;
    public AudioClip touchclip;
    public AudioClip kbdclip;
    public AudioClip bell;
    public static int facenum = 0;
    public GameObject HealthControlScript;
    public AudioClip minus;
    public GameObject GameController;


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
        FaceChange();
        if (count > 0)
        {
            SoundManager.instance.SFXPlay("Touch", touchclip);
            //SoundManager.instance.SFXPlay("Keyboard", kbdclip);
        }
        if(count == 0)
        {
            SoundManager.instance.SFXPlay("Bell", bell);
        }
        if (count == 47)
        {
            SoundManager.instance.SFXPlay("Bell", bell);
        }
        if (count == 74)
        {
            SoundManager.instance.SFXPlay("Bell", bell);
        }
        if (count == 101)
        {
            SoundManager.instance.SFXPlay("Bell", bell);
        }
        if (count == 157)
        {
            SoundManager.instance.SFXPlay("Bell", bell);
        }
        count++;
    }
    public void TextColorChange()
    {
        data[count]["Script"] = data[count]["Script"].ToString().Replace("��", "<color=#2782cc>");//�Ķ��� "�߿��Ѻκ�"
        data[count]["Script"] = data[count]["Script"].ToString().Replace("��", "<color=#a83a22>");//������ (����� -)
        data[count]["Script"] = data[count]["Script"].ToString().Replace("��", "<color=#13c216>");//�ʷϻ� (����� +) 
        data[count]["Script"] = data[count]["Script"].ToString().Replace("��", "</color>");// �ٲ� ������ �������� ���� ��ȣ
        data[count]["Script"] = data[count]["Script"].ToString().Replace("��", "<color=#a8a3a2>");//���ΰ� ���� 
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
        SaveData.TempScene = "Day7-3";
        count = SaveData.TempCount;
        SaveData.Saves();
    }
    private void FaceChange()
    {
        if (data[count]["Face"].ToString().Equals("7_1_1"))
        {
            facenum = 1;
        }
        if (data[count]["Face"].ToString().Equals("7_1_2"))
        {
            facenum = 2;
        }
        if (data[count]["Face"].ToString().Equals("7_1_3"))
        {
            facenum = 3;
        }
        if (data[count]["Face"].ToString().Equals("7_1_4"))
        {
            facenum = 4;
        }
        if (data[count]["Face"].ToString().Equals("7_2_1"))
        {
            facenum = 5;
        }
        if (data[count]["Face"].ToString().Equals("7_2_2"))
        {
            facenum = 6;
        }
        if (data[count]["Face"].ToString().Equals("7_2_3"))
        {
            facenum = 7;
        }
        if (data[count]["Face"].ToString().Equals("7_2_4"))
        {
            facenum = 8;
        }
    }
    private void day7_3_JD()//ù��° �������� ����� ��� ������ ��ȭ�� �ٺ��� ���� ��ȭ�� �Ѿ�� �Լ�
    {
        if (count < data.Count)
        {
            Nextdialogue();

            if (count == 15)
            {
                count += 29 - 15;
            }

            if (count == 24)
            {
                count += 29 - 24;
            }
            if (count == 39)
            {
                count += 47 - 39;
            }



            if (count == 58)
            {
                count += 64 - 58;
            }
            if (count == 85)
            {
                count += 91 - 85;
            }
            if (count == 95)
            {
                count += 101 - 95;
            }

            if (count == 114)
            {
                count += 124 - 114;
            }
            if (count == 131)
            {
                count += 139 - 131;
            }


            if (count == 144)
            {
                count += 157 - 144;
            }
            if (count == 197)
            {
                count += 218 - 197;
            }
            if (count == 208)
            {
                count += 218 - 208;
            }
            
            if (count == 221)
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
            GameController.GetComponent<JSChoice>().D2_JSChoice();
        }
    }

    private void day7_3_HC()
    {
       
        if (count == 100)
        {
            SoundManager.instance.SFXPlay("Minus", minus);
            SaveData.JSName = " JS9";
            HealthControlScript.GetComponent<HealthControlScript>().health_decrease();
        }
        if (count == 155)
        {
            SoundManager.instance.SFXPlay("Minus", minus);
            SaveData.JSName = " JS4";
            HealthControlScript.GetComponent<HealthControlScript>().health_decrease();
        }
        if (count == 202)
        {
            SoundManager.instance.SFXPlay("Minus", minus);
            SaveData.JSName = " JS3";
            HealthControlScript.GetComponent<HealthControlScript>().health_decrease();
        }
        if (count == 212)
        {
            SoundManager.instance.SFXPlay("Minus", minus);
            SaveData.JSName = " JS3";
            HealthControlScript.GetComponent<HealthControlScript>().health_decrease();
        }
     
    }
    private void Start()
    {
        data = CSVReader.Read("Day7-3");
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
                if (EventSystem.current.IsPointerOverGameObject() == false)
                {
                    day7_3_JD();
                    day7_3_HC();
                    SaveData.TempCount = count - 1;
                    SaveData.Saves();
                }
            }
        }
        else
            Hidedialogue();
    }
}
