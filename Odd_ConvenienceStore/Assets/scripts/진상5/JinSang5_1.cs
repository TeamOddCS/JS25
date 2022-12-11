using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class JinSang5_1 : MonoBehaviour
{
    [SerializeField] private Text txt_dialogue; //��ȭ���� ��� ��ü
    [SerializeField] private Text txt_name;// �̸� ��� ��ü 
    public static bool isDialogue = false;
    public static int count = 0;
    private List<Dictionary<string, object>> data;
    public FadeInOut fade;
    public AudioClip touchclip;
    public AudioClip bell;
    public GameObject GameController;
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
        txt_dialogue.text = data[count]["Script"].ToString();
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
        FaceChange();
    }

    private void FaceChange()
    {
        if (data[count]["Face"].ToString().Equals("5_1_1"))
        {
            facenum = 1;
        }
        if (data[count]["Face"].ToString().Equals("5_1_2"))
        {
            facenum = 2;
        }
        if (data[count]["Face"].ToString().Equals("5_2_1"))
        {
            facenum = 3;
        }
        if (data[count]["Face"].ToString().Equals("5_2_2"))
        {
            facenum = 4;
        }
        if (data[count]["Face"].ToString().Equals("5_3_1"))
        {
            facenum = 5;
        }
        if (data[count]["Face"].ToString().Equals("5_3_2"))
        {
            facenum = 6;
        }
        if (data[count]["Face"].ToString().Equals("5_4_1"))
        {
            facenum = 7;
        }
        if (data[count]["Face"].ToString().Equals("5_4_2"))
        {
            facenum = 8;
        }
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
    public void Awake()
    {
        SaveData.DoLoadData = true;
        SaveData.TempScene = "JinSang5_1";
        Debug.Log(SaveData.LastScene);
        count = SaveData.TempCount;
        SaveData.Saves();
    }

    private void Start()
    {
        data = CSVReader.Read("진상5-1");
        Camera = GameObject.FindWithTag("MainCamera").GetComponent<Camera>();
        HealthControlScript.GetComponent<HealthControlScript>().Show_Health();
        Showdialogue();
    }

    private void JinSang5_1_HC()
    {
        if (count < data.Count)
        {
            if (count == 30)
            { 
                //SoundManager.instance.SFXPlay("Minus", minus);
                SaveData.JSName = "JS5";
                HealthControlScript.GetComponent<HealthControlScript>().health_decrease();
            }
            if (count == 48)
            { 
                //SoundManager.instance.SFXPlay("Minus", minus);
                SaveData.JSName = "JS5";
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
                    if (count < data.Count)
                    {
                        Nextdialogue();
                        if (count == 27)
                        {
                            
                            Hidedialogue();
                        }
                        if (count == 37)
                        {
                            
                            Hidedialogue();
                        }
                        if (count == 53)
                        {
                            
                            Hidedialogue();
                        }
                        if (count == 59)
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
                    JinSang5_1_HC();
                    SaveData.TempCount = count - 1;
                    SaveData.Saves();
                }
            }
        }
        else
            Hidedialogue();
    }
}
