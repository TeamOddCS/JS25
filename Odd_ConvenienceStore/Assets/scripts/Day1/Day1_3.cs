using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Day1_3 : MonoBehaviour
{
    [SerializeField] private Text txt_name;// �̸� ��� ��ü 
    [SerializeField] private Text txt_dialogue; //��ȭ���� ��� ��ü
    public static bool isDialogue = false;
    public static int count = 0;
    private List<Dictionary<string, object>> data;
    public AudioClip touchclip;
    public AudioClip bell;
    public FadeInOut fade;

    public GameObject HealthControlScript;

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
            SoundManager.instance.SFXPlay("bell", bell);
        }

        if (count == 21)
        {
            SoundManager.instance.SFXPlay("bell", bell);
        }
      
        if (count == 43)
        {
            SoundManager.instance.SFXPlay("bell", bell);
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
        SaveData.TempScene = "Day1-3";
        count = SaveData.TempCount;
        SaveData.Saves();
    }

    private void Start()
    {
        data = CSVReader.Read("Day1-3");
        HealthControlScript.GetComponent<HealthControlScript>().Show_Health();
        Showdialogue();
    }

    private void day1_3_HC()
    {
        if (count < data.Count)
        {
            if (count == 68)
            { //��?! �� ���� ����׷���
                //SoundManager.instance.SFXPlay("Minus", minus);
                SaveData.JSName = "JS5";
                HealthControlScript.GetComponent<HealthControlScript>().health_decrease();
            }

            if (count == 77)
            { //�ʡ� �ΰ� ��. 
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
                if (EventSystem.current.IsPointerOverGameObject() == false) 
                { 
                    if (count < data.Count)
                {
                    Nextdialogue();
                    if (count == 14)
                    {
                        count += 3;
                    }
                    if (count == 36)
                    {
                        count += 3;
                    }
                    if (count == 51)
                    {
                        count += 2;
                    }
                    if (count == 67)
                    {
                        count += 3;
                    }
                    if (count == 76)
                    {
                        count += 4;
                    }
                }
                else
                {
                    fade.Fade();
                    Hidedialogue();
                    count = 1;
                    SceneManager.LoadScene("Day1-F");
                }
                day1_3_HC();
                SaveData.TempCount = count - 1;
                SaveData.Saves();
                }
            }
        }
        else
            Hidedialogue();
    }
}
