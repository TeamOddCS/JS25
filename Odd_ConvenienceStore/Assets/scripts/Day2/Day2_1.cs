using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;

public class Day2_1 : MonoBehaviour
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
    Camera Camera;

    public void Showdialogue()// ó�������Ҷ� �� �ʱ�ȭ�ϰ� ��ȭ������ �����ִ� �Լ�
    {
        txt_dialogue.gameObject.SetActive(true);
        txt_name.gameObject.SetActive(true);
        //count = 0;
        isDialogue = true;
        if (count == 0) 
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
        if (count == 0)
        {
            SoundManager.instance.SFXPlay("Bell", bell);
            fade.Fade();
        }
        if (count == 33)
        {
            SoundManager.instance.SFXPlay("Bell", bell);
            fade.Fade();
        }
        if (count == 152)
        {
            SoundManager.instance.SFXPlay("Bell", bell);
            fade.Fade();
        }
        count++;
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
        SaveData.TempScene = "Day2-1";
        count = SaveData.TempCount;
        SaveData.Saves();
    }
    private void FaceChange()
    {
        if (data[count]["Face"].ToString().Equals("9_1_1"))
        {
            facenum = 1;
        }
        if (data[count]["Face"].ToString().Equals("9_1_2"))
        {
            facenum = 2;
        }
        if (data[count]["Face"].ToString().Equals("9_1_3"))
        {
            facenum = 3;
        }
        if (data[count]["Face"].ToString().Equals("9_1_4"))
        {
            facenum = 4;
        }
        if (data[count]["Face"].ToString().Equals("9_2_1"))
        {
            facenum = 5;
        }
        if (data[count]["Face"].ToString().Equals("9_2_2"))
        {
            facenum = 6;
        }
        if (data[count]["Face"].ToString().Equals("9_2_3"))
        {
            facenum = 7;
        }
        if (data[count]["Face"].ToString().Equals("9_2_4"))
        {
            facenum = 8;
        }
         if (data[count]["Face"].ToString().Equals("1_1_1"))
        {
            facenum = 9;
        }
        if (data[count]["Face"].ToString().Equals("1_1_2"))
        {
            facenum = 10;
        }
        if (data[count]["Face"].ToString().Equals("1_1_3"))
        {
            facenum = 11;
        }
        if (data[count]["Face"].ToString().Equals("1_2_1"))
        {
            facenum = 12;
        }
        if (data[count]["Face"].ToString().Equals("1_2_2"))
        {
            facenum = 13;
        }
        if (data[count]["Face"].ToString().Equals("1_2_3"))
        {
            facenum = 14;
        }
        if (data[count]["Face"].ToString().Equals("111"))
        {
            facenum = 15;
        }
        if (data[count]["Face"].ToString().Equals("222"))
        {
            facenum = 16;
        }
        if (data[count]["Face"].ToString().Equals("333"))
        {
            facenum = 17;
        }

    }
    private void day2_1_JD()//ù��° �������� ����� ��� ������ ��ȭ�� �ٺ��� ���� ��ȭ�� �Ѿ�� �Լ�
    {
        if (count < data.Count)
        {
            Nextdialogue();

            if (count == 14)
            {
                count += 18 - 14;
            }

            if (count == 27)
            {
                count += 30 - 27;
            }
            if (count == 55)
            {
                count +=  66 - 55;
            }
           


            if (count == 64)
            {
                count += 66 - 64;
            }
            if (count == 91)
            {
                count += 106 - 91;
            }
            if (count == 104)
            {
                count += 106 - 104;
            }
           
            if (count == 108)
            {
                count += 110 - 108;
            }
            if (count == 70)
            {
                count += 110 - 70;
            }
            

            if (count == 125)
            {
                count += 151 - 125;
            }
            if (count == 143)
            {
                count += 151 - 143;
            }
            if (count == 150)
            {
                count += 151 - 150;
            }
            if (count == 165)
            {
                count += 183 - 165;
            }
            if (count == 169)
            {
                count += 183 - 169;
            }
            if (count == 177)
            {
                count += 181 - 177;
            }
            if (count == 182)
            {
                count += 160 - 182;
            }
            if (count == 201)
            {
                count += 205 - 201;
            }
            if (count == 210)
            {
                count += 217 - 210;
            }
            if (count == 217)
            {
                count += 217 - 217;
            }
            if (count == 221)
            {
                
                Hidedialogue();
            }
        }
        else
        {
            
            Hidedialogue();
            count = 1;
            GameController.GetComponent<JSChoice>().D2_JSChoice();
        }
    }

    private void day2_1_HC()
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
        if (count == 77)
        {
            SoundManager.instance.SFXPlay("Minus", minus);
            SaveData.JSName = " JS9";
            HealthControlScript.GetComponent<HealthControlScript>().health_decrease();
        }
        if (count == 98)
        {
            SoundManager.instance.SFXPlay("Minus", minus);
            SaveData.JSName = " JS9";
            HealthControlScript.GetComponent<HealthControlScript>().health_decrease();
        }
        if (count == 142)
        {
            SoundManager.instance.SFXPlay("Minus", minus);
            SaveData.JSName = " JS9";
            HealthControlScript.GetComponent<HealthControlScript>().health_decrease();
        }
        if (count == 164)
        {
            SoundManager.instance.SFXPlay("Minus", minus);
            SaveData.JSName = " JS1";
            HealthControlScript.GetComponent<HealthControlScript>().health_decrease();
        }
        if (count == 181)
        {
            SoundManager.instance.SFXPlay("Minus", minus);
            SaveData.JSName = " JS1";
            HealthControlScript.GetComponent<HealthControlScript>().health_decrease();
        }
       
    }
    private void Start()
    {
        data = CSVReader.Read("Day2-1");
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
                    day2_1_JD();
                    day2_1_HC();
                    SaveData.TempCount = count - 1;
                    SaveData.Saves();
                }
            }
        }
        else
            Hidedialogue();
    }
}
