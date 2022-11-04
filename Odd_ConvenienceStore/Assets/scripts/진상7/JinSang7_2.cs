using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class JinSang7_2 : MonoBehaviour
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
    public AudioClip minus;
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
    private void FaceChange()
    {
        if (data[count]["Face"].ToString().Equals("2_1_1"))
        {
            facenum = 1;
        }
        if (data[count]["Face"].ToString().Equals("2_1_3"))
        {
            facenum = 2;
        }
        if (data[count]["Face"].ToString().Equals("2_1_4"))
        {
            facenum = 3;
        }
        if (data[count]["Face2"].ToString().Equals("7_1"))// �մ� �׷��� �߰� �׽�Ʈ �ڵ�
        {
            facenum2 = 1;
        }
        if (data[count]["Face2"].ToString().Equals("7_3"))// �մ� �׷��� �߰� �׽�Ʈ �ڵ�
        {
            facenum2 = 2;
        }
        if (data[count]["Face2"].ToString().Equals("0"))// �մ� �׷��� �߰� �׽�Ʈ �ڵ�
        {
            facenum2 = 3;
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
        if (count > 0)
        {
            SoundManager.instance.SFXPlay("Touch", touchclip);
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
    private void JinSang7_2_HC()
    {
        if (count == 51)
        {
            SoundManager.instance.SFXPlay("Minus", minus);
            SaveData.JSName = " JS7";
            HealthControlScript.GetComponent<HealthControlScript>().health_decrease();

        }
        if (count == 26)
        {
            SoundManager.instance.SFXPlay("Minus", minus);
            SaveData.JSName = " JS7";
            HealthControlScript.GetComponent<HealthControlScript>().health_decrease();

        }

    }
    public void Awake()
    {
        SaveData.DoLoadData = true;
        SaveData.TempScene = "JinSang7_2";
        count = SaveData.TempCount;
        SaveData.Saves();
    }
    private void Start()
    {
        SaveData.Loads();
        data = CSVReader.Read("����7-2");
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
                        if (count == 30)
                        {
                            count += 52 - 30;
                        }
                        if (count == 47)
                        {
                            count += 51 - 47;
                        }
                    }
                    else
                    {
                        
                        Hidedialogue();
                        count = 1;
                        GameController.GetComponent<JSChoice>().Check_Day();
                    }
                    JinSang7_2_HC();
                    SaveData.TempCount = count - 1;
                    SaveData.Saves();
                }
            }
        }
        else
            Hidedialogue();
    }
}
