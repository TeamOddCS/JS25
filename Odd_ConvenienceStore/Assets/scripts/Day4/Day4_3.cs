using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Day4_3 : MonoBehaviour 
{ 
    [SerializeField] private Text txt_name;// �̸� ��� ��ü 
    [SerializeField] private Text txt_dialogue; //��ȭ���� ��� ��ü
    public static bool isDialogue = false;
    public static int count = 0;
    public AudioClip touchclip;
    private List<Dictionary<string, object>> data;
    public FadeInOut fade;
    public GameObject HealthControlScript;
    public AudioClip bell;
    public AudioClip Pos;
    public AudioClip hiccups;
    public AudioClip minus;



    public void Showdialogue()// ó�������Ҷ� �� �ʱ�ȭ�ϰ� ��ȭ������ �����ִ� �Լ�
    {
        txt_dialogue.gameObject.SetActive(true);
        txt_name.gameObject.SetActive(true);
        //count = 0;
        isDialogue = true;
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
        }
        if (count == 39)
        {
            SoundManager.instance.SFXPlay("Bell", bell);
        }
        if (count == 55)
        {
            SoundManager.instance.SFXPlay("Pos", Pos);
        }
        if (count == 71)
        {
            SoundManager.instance.SFXPlay("Bell", bell);
        }
        if (count == 73)
        {
            SoundManager.instance.SFXPlay("Hiccups", hiccups);
        }
        if (count == 93)
        {
            SoundManager.instance.SFXPlay("Hiccups", hiccups);
        }
        if (count == 119)
        {
            SoundManager.instance.SFXPlay("Hiccups", hiccups);
        }
        count++;
    
    }

    public void TextColorChange()
    {
        data[count]["Script"] = data[count]["Script"].ToString().Replace("��", "<color=#2782cc>");//�Ķ��� "�߿��Ѻκ�"
        data[count]["Script"] = data[count]["Script"].ToString().Replace("��", "<color=#a83a22>");//������ (����� -)
        data[count]["Script"] = data[count]["Script"].ToString().Replace("��", "<color=#13c216>");//�ʷϻ� (����� +) 
        data[count]["Script"] = data[count]["Script"].ToString().Replace("��", "</color>");// �ٲ� ������ �������� ���� ��ȣ
    }
    private void Hidedialogue()//��ȭ�� �������� ��ȭ���� ����� �Լ�
    {
        txt_name.gameObject.SetActive(false);
        txt_dialogue.gameObject.SetActive(false);
        isDialogue = false;
    }
    private void day4_3_JD()//ù��° �������� ����� ��� ������ ��ȭ�� �ٺ��� ���� ��ȭ�� �Ѿ�� �Լ�
    {
        if (count < data.Count)
        {
            Nextdialogue();
            
            if (count == 11)
            {
                count += 6;
            }
            if (count == 30)
            {
                count += 8;
            }
            if (count == 67)
            {
                count += 4;
            }
            if (count == 86)
            {
                count += 4;
            }
            if (count == 97)
            {
                count += 7;
            }
            if (count == 126)
            {
                count += 11;
            }
            if (count == 158)
            {
                count += 6;
            }
            if (count == 187)
            {
                count += 38;
            }
            if (count == 194)
            {
                count += 31;
            }
            if (count == 213)
            {
                count +=12;
            }
            if (count == 227)
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
            SceneManager.LoadScene("Day4-F");
        }
    }
    private void day4_3_HC()
    {

        if (count == 182)
        {
            SoundManager.instance.SFXPlay("Minus", minus);
            SaveData.JSName = " JS8";
            HealthControlScript.GetComponent<HealthControlScript>().health_decrease();
        }
        if (count == 201)
        {
            SoundManager.instance.SFXPlay("Minus", minus);
            SaveData.JSName = " JS8";
            HealthControlScript.GetComponent<HealthControlScript>().health_decrease();
        }

        if (count == 221)
        {
            SoundManager.instance.SFXPlay("Minus", minus);
            SaveData.JSName = " JS8";
            HealthControlScript.GetComponent<HealthControlScript>().health_decrease();
        }
      

    }
    public void Awake()
    {
        SaveData.DoLoadData = true;
        SaveData.TempScene = "Day4-3";
        count = SaveData.TempCount;
        SaveData.Saves();
    }
    private void Start()
    {
        data = CSVReader.Read("Day4-3");
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
                day4_3_JD();
                day4_3_HC();
                SaveData.TempCount = count - 1;
                SaveData.Saves();
            }
        }
        else
            Hidedialogue();
    }
}
