using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class JinSang6_1 : MonoBehaviour
{
    [SerializeField] private Text txt_dialogue; //��ȭ���� ��� ��ü
    [SerializeField] private Text txt_name;// �̸� ��� ��ü 
    public static bool isDialogue = false;
    public static int count = 0;
    private List<Dictionary<string, object>> data;
    public FadeInOut fade;
    public AudioClip touchclip;
    public AudioClip kbdclip;
    public static int facenum = 0;

    public void Showdialogue()// ó�������Ҷ� �� �ʱ�ȭ�ϰ� ��ȭ������ �����ִ� �Լ�
    {
        txt_dialogue.gameObject.SetActive(true);
        txt_name.gameObject.SetActive(true);
        count = 0;
        isDialogue = true;
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
    private void FaceChange()
    {
        if (data[count]["Face"].ToString().Equals("6_1_1"))
        {
            facenum = 1;
        }
        if (data[count]["Face"].ToString().Equals("6_1_2"))
        {
            facenum = 2;
        }
        if (data[count]["Face"].ToString().Equals("6_1_3"))
        {
            facenum = 3;
        }
        if (data[count]["Face"].ToString().Equals("6_1_4"))
        {
            facenum = 4;
        }
        if (data[count]["Face"].ToString().Equals("6_2_1"))
        {
            facenum = 5;
        }
        if (data[count]["Face"].ToString().Equals("6_2_2"))
        {
            facenum = 6;
        }
        if (data[count]["Face"].ToString().Equals("6_2_3"))
        {
            facenum = 7;
        }
        if (data[count]["Face"].ToString().Equals("6_2_4"))
        {
            facenum = 8;
        }
    }
    public void Awake()
    {
        SaveData.DoLoadData = true;
        SaveData.TempScene = "JinSang6_1";
        count = SaveData.TempCount;
        SaveData.Saves();
    }
    private void Start()
    {
        data = CSVReader.Read("����6-1");
        Showdialogue();
    }

    // Update is called once per frame
    void Update()
    {
        if (isDialogue)
        {
            if (Input.GetMouseButtonUp(0))
            {
                if (count < data.Count)
                {
                    Nextdialogue();
                    if (count == 22)
                    {
                        count += 4;
                    }
                    if (count == 24)
                    {
                        count ++;
                    }
                }
                else
                {
                    fade.Fade();
                    Hidedialogue();
                    count = 1;
                    SceneManager.LoadScene("Day1-3");
                }
                SaveData.TempCount = count - 1;
                SaveData.Saves();
            }
        }
        else
            Hidedialogue();
    }
}
