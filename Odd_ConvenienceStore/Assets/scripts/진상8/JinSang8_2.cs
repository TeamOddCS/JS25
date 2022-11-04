using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class JinSang8_2 : MonoBehaviour
{
    [SerializeField] private Text txt_dialogue; //��ȭ���� ��� ��ü
    [SerializeField] private Text txt_name;// �̸� ��� ��ü 
    public static bool isDialogue = false;
    public static int count = 0;
    private List<Dictionary<string, object>> data;
    public FadeInOut fade;
    public AudioClip touchclip;
    //public AudioClip kbdclip;
    public static int facenum = 0;
    public static int facenum2 = 0;// �մ� �׷��� �߰� �׽�Ʈ �ڵ�
    public GameObject HealthControlScript;
    public AudioClip bell;
    public AudioClip minus;
    public GameObject GameController;
    Camera Camera;


    public void Showdialogue()// ó�������Ҷ� �� �ʱ�ȭ�ϰ� ��ȭ������ �����ִ� �Լ�
    {
        txt_dialogue.gameObject.SetActive(true);
        txt_name.gameObject.SetActive(true);
        //count = 0;
        isDialogue = true;
        if (count == 0) //������
        { 
            Nextdialogue();
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
        FaceChange();
        if (count > 0)
        {
            SoundManager.instance.SFXPlay("Touch", touchclip);
            //SoundManager.instance.SFXPlay("Keyboard", kbdclip);
        }
        if (count == 0)
        {
            SoundManager.instance.SFXPlay("Bell", bell);
            fade.Fade();
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
    private void FaceChange()
    {
        if (data[count]["Face"].ToString().Equals("8_1_1"))
        {
            facenum = 0;
        }
        if (data[count]["Face"].ToString().Equals("8_2_1"))
        {
            facenum = 1;
        }
        if (data[count]["Face"].ToString().Equals("8_2_2"))
        {
            facenum = 2;
        }
        if (data[count]["Face"].ToString().Equals("8_2_2_a"))
        {
            facenum = 3;
        }
        if (data[count]["Face"].ToString().Equals("8_2_3"))
        {
            facenum = 4;
        }
       


    }
    private void JinSang8_2_HC()
    {
        if (count == 48)
        {
            SoundManager.instance.SFXPlay("Minus", minus);
            SaveData.JSName = " JS8";
            HealthControlScript.GetComponent<HealthControlScript>().health_decrease();
        }
    }

    public void Awake()
    {
        SaveData.DoLoadData = true;
        SaveData.TempScene = "JinSang8_2";
        Debug.Log(SaveData.LastScene);
        count = SaveData.TempCount;
        SaveData.Saves();
    }

    private void Start()
    {
        data = CSVReader.Read("����8-2");
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
                        if (count == 39)
                        {
                            count += 5;
                        }
                        if (count == 52)
                        {
                            count += 6;
                        }
                        /*if (count == 58)
                        {
                            fade.Fade();
                            Hidedialogue();
                        }*/
                        JinSang8_2_HC();
                    }
                    else
                    {
                        
                        Hidedialogue();
                        count = 1;
                        GameController.GetComponent<JSChoice>().Check_Day();
                    }
                    SaveData.TempCount = count - 1;
                    SaveData.Saves();
                }
            }
          
        }
        else
            Hidedialogue();
    }
}
