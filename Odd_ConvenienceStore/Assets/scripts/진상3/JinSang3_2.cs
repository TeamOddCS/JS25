using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class JinSang3_2 : MonoBehaviour
{
    [SerializeField] private Text txt_dialogue; //��ȭ���� ��� ��ü
    [SerializeField] private Text txt_name;// �̸� ��� ��ü 
    public static bool isDialogue = false;
    public static int count = 0;
    private List<Dictionary<string, object>> data;
    public FadeInOut fade;
    public static int facenum = 0;
    public AudioClip touchclip;
    public GameObject HealthControlScript;
    public GameObject GameController;
    public AudioClip bell;
    public AudioClip minus;
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
        FaceChange();
        if (count > 0)
        {
            SoundManager.instance.SFXPlay("Touch", touchclip);
        }
        if (count == 0)
        {
            SoundManager.instance.SFXPlay("Bell", bell);
            fade.Fade();
        }
        count++;

    }
    private void JinSang3_2_HC()
    {
        if (count == 32)
        {
            SoundManager.instance.SFXPlay("Minus", minus);
            SaveData.JSName = " JS3";
            HealthControlScript.GetComponent<HealthControlScript>().health_decrease();

        }
        if (count == 34)
        {
            SoundManager.instance.SFXPlay("Minus", minus);
            SaveData.JSName = " JS3";
            HealthControlScript.GetComponent<HealthControlScript>().health_decrease();
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
    }
    public void Awake()
    {
        SaveData.DoLoadData = true;
        SaveData.TempScene = "JinSang3_2";
        Debug.Log(SaveData.LastScene);
        count = SaveData.TempCount;
        SaveData.Saves();
    }

    private void Start()
    {
        data = CSVReader.Read("����3-2");
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
                        if (count == 26)
                        {
                            
                            Hidedialogue();
                        }
                        if (count == 33)
                        {
                            
                            Hidedialogue();
                        }
                    }
                    else
                    {
                        
                        Hidedialogue();
                        count = 1;
                        GameController.GetComponent<JSChoice>().Check_Day();
                    }
                    JinSang3_2_HC();
                    SaveData.TempCount = count - 1;
                    SaveData.Saves();
                }
            }
        }
        else
            Hidedialogue();
    }
}