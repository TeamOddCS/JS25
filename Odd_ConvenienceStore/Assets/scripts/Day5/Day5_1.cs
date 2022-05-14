using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Day5_1 : MonoBehaviour
{
    [SerializeField] private Text txt_dialogue; //��ȭ���� ��� ��ü
    [SerializeField] private Text txt_name;// �̸� ��� ��ü 
    public static bool isDialogue = false;
    public static int count = 0;
    private List<Dictionary<string, object>> data;
    public FadeInOut fade;
    public AudioClip touchclip;
    public static int facenum = 0;

    public GameObject GameController;

    public void Showdialogue()// ó�������Ҷ� �� �ʱ�ȭ�ϰ� ��ȭ������ �����ִ� �Լ�
    {
        txt_dialogue.gameObject.SetActive(true);
        txt_name.gameObject.SetActive(true);
        //count = 0;
        isDialogue = true;
        Nextdialogue();
    }
    public void TextColorChange()
    {
        data[count]["Script"] = data[count]["Script"].ToString().Replace("��", "<color=#2782cc>");//�Ķ��� "�߿��Ѻκ�"
        data[count]["Script"] = data[count]["Script"].ToString().Replace("��", "<color=#a83a22>");//������ (����� -)
        data[count]["Script"] = data[count]["Script"].ToString().Replace("��", "<color=#13c216>");//�ʷϻ� (����� +) 
        data[count]["Script"] = data[count]["Script"].ToString().Replace("��", "</color>");// �ٲ� ������ �������� ���� ��ȣ
        data[count]["Script"] = data[count]["Script"].ToString().Replace("��", "<color=#a8a3a2>");//���ΰ� ���� 
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
        count++;
    }
    private void FaceChange()
    {
        if (data[count]["Face"].ToString().Equals("4_1_1"))
        {
            facenum = 1;
        }
        if (data[count]["Face"].ToString().Equals("4_1_2"))
        {
            facenum = 2;
        }
        if (data[count]["Face"].ToString().Equals("4_2_1"))
        {
            facenum = 3;
        }
        if (data[count]["Face"].ToString().Equals("4_2_2"))
        {
            facenum = 4;
        }
        if (data[count]["Face"].ToString().Equals("4_3_1"))
        {
            facenum = 5;
        }
        if (data[count]["Face"].ToString().Equals("4_3_2"))
        {
            facenum = 6;
        }


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
        SaveData.TempScene = "Day5-1";
        count = SaveData.TempCount;
        SaveData.Saves();
    }
    private void Start()
    {
        data = CSVReader.Read("Day5-1");
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
                    if (count == 32)
                    {// �׷��� �� ����ּ��� ������
                        count += 8;
                    }
                    if (count == 52)
                    {//������ ���� ������. ������
                        count += 40;
                    }
                    if (count == 58)
                    {// �׷��Ա��� ����.. ������
                        count += 34;
                    }
                    if (count == 69)
                        count += 6;
                    if (count == 85)
                        count += 7;
                    if (count == 125)
                        count += 5;
                    if (count == 135)
                        count += 34;
                    if (count == 157)
                        count += 15;
                }
                else
                {
                    fade.Fade();
                    Hidedialogue();
                    count = 1;
                    GameController.GetComponent<JSChoice>().D5_JSChoice();
                }

                SaveData.TempCount = count - 1;
                SaveData.Saves();
            }
        }
        else
            Hidedialogue();
    }
}
