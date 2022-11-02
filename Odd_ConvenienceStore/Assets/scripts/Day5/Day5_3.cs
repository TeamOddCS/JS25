using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class Day5_3 : MonoBehaviour
{
    [SerializeField] private Text txt_dialogue; //��ȭ���� ��� ��ü
    [SerializeField] private Text txt_name;// �̸� ��� ��ü 
    public static bool isDialogue = false;
    public static int count = 0;
    private List<Dictionary<string, object>> data;
    public FadeInOut fade;
    public AudioClip bell;
    public AudioClip touchclip;
    public AudioClip plus;
    public GameObject HealthControlScript;
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
        if( count == 0 )
        {
            SoundManager.instance.SFXPlay("Bell", bell);
        }
        if (count == 26)
        {
            SoundManager.instance.SFXPlay("Bell", bell);
        }
        count++;
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
    public void Awake()
    {
        SaveData.DoLoadData = true;
        SaveData.TempScene = "Day5-3";
        count = SaveData.TempCount;
        SaveData.Saves();
    }
    private void Start()
    {
        data = CSVReader.Read("Day5-3");
        Camera = GameObject.FindWithTag("MainCamera").GetComponent<Camera>();
        HealthControlScript.GetComponent<HealthControlScript>().Show_Health();
        Showdialogue();
    }
    private void FaceChange()
    {
        if (data[count]["Face"].ToString().Equals("a4_1_1"))
        {
            facenum = 1;
        }
        if (data[count]["Face"].ToString().Equals("a4_2"))
        {
            facenum = 2;
        }
        if (data[count]["Face"].ToString().Equals("a4_3"))
        {
            facenum = 3;
        }
        if (data[count]["Face"].ToString().Equals("a4_4"))
        {
            facenum = 4;
        }
        if (data[count]["Face"].ToString().Equals("a4_5"))
        {
            facenum = 5;
        }
        if (data[count]["Face"].ToString().Equals("a4_6"))
        {
            facenum = 6;
        }
        if (data[count]["Face"].ToString().Equals("a4_7"))
        {
            facenum = 7;
        }
        if (data[count]["Face"].ToString().Equals("a4_1_1b"))
        {
            facenum = 8;
        }
        if (data[count]["Face"].ToString().Equals("a4_2b"))
        {
            facenum = 9;
        }
        if (data[count]["Face"].ToString().Equals("a4_3b"))
        {
            facenum = 10;
        }
        if (data[count]["Face"].ToString().Equals("a4_4b"))
        {
            facenum = 11;
        }
        if (data[count]["Face"].ToString().Equals("a4_5b"))
        {
            facenum = 12;
        }
        if (data[count]["Face"].ToString().Equals("a4_6b"))
        {
            facenum = 13;
        }
        if (data[count]["Face"].ToString().Equals("a4_7b"))
        {
            facenum = 14;
        }
        if (data[count]["Face"].ToString().Equals("a7_1"))
        {
            facenum = 15;
        }
        if (data[count]["Face"].ToString().Equals("a7_2"))
        {
            facenum = 16;
        }
        if (data[count]["Face"].ToString().Equals("a7_3"))
        {
            facenum = 17;
        }
        if (data[count]["Face"].ToString().Equals("a7_4"))
        {
            facenum = 18;
        }
        if (data[count]["Face"].ToString().Equals("a7_5"))
        {
            facenum = 19;
        }
    }

        private void day5_3_HC()
    {
        if (count == 5)
        {
            SoundManager.instance.SFXPlay("Plus", plus);
            SaveData.JSName = " JS9";
            HealthControlScript.GetComponent<HealthControlScript>().health_increase();
        }
        if (count == 6)
        {
            SoundManager.instance.SFXPlay("Plus", plus);
            SaveData.JSName = " JS9";
            HealthControlScript.GetComponent<HealthControlScript>().health_increase();
        }
        if (count == 7)
        {
            SoundManager.instance.SFXPlay("Plus", plus);
            SaveData.JSName = " JS9";
            HealthControlScript.GetComponent<HealthControlScript>().health_increase();
        }
        if (count == 25)
        {
            SoundManager.instance.SFXPlay("Plus", plus);

            HealthControlScript.GetComponent<HealthControlScript>().health_increase();
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
                    if (count < data.Count)
                    {
                        Nextdialogue();
                        if (count == 16)
                        {
                            count += 9;
                        }
                        if (count == 45)
                        {
                            count += 11;
                        }
                        if (count == 66)
                        {
                            count += 7;
                        }
                        if (count == 85)
                        {
                            count += 3;
                        }
                    }
                    else
                    {
                        fade.Fade();
                        Hidedialogue();
                        count = 1;
                        SceneManager.LoadScene("Day5-F");
                    }
                    day5_3_HC();
                    SaveData.TempCount = count - 1;
                    SaveData.Saves();
                }
            }
        }
        else
            Hidedialogue();
    }
}